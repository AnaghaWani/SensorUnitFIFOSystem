using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReelManagement
{
    public partial class Inventory : Form
    {
        private readonly string connectionString = @"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True";
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        public Inventory()
        {
            InitializeComponent();
            LoadData();
            GetStatus();
            quantity.Text = string.Empty;
        }

        private DataTable ExecuteQuery(string query, List<SqlParameter> parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    SqlCommand command = new SqlCommand(query, connect);

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }
        private void LoadData()
        {
            string query = @"
SELECT 
    tr.type_no AS 'Type No.',
    a.reading AS 'Reading Type/ASIC ver.',
    COALESCE(SUM(CASE WHEN tr.txn_type = 'IN' THEN tr.quantity ELSE 0 END), 0) - 
    COALESCE(SUM(CASE WHEN tr.txn_type = 'OUT' THEN tr.quantity ELSE 0 END), 0) AS 'Available Qty (Pcs)'
FROM 
    TransactionRecords tr 
INNER JOIN 
    ReadingType a ON tr.type_no = a.type_no
GROUP BY 
    tr.type_no, a.reading, a.srno
ORDER BY a.srno";

            inventory_display.DataSource = ExecuteQuery(query);
            UpdateAvailable();
            GetStatus();
        }
        private void UpdateAvailable()
        {
            string updateQuery = @"
UPDATE a
SET 
    a.Available = av.[Available Qty (Pcs)]
FROM 
    ReadingType a
JOIN (
    SELECT 
        tr.type_no,
        COALESCE(SUM(CASE WHEN tr.txn_type = 'IN' THEN tr.quantity ELSE 0 END), 0) - 
        COALESCE(SUM(CASE WHEN tr.txn_type = 'OUT' THEN tr.quantity ELSE 0 END), 0) AS [Available Qty (Pcs)]
    FROM 
        TransactionRecords tr 
    GROUP BY 
        tr.type_no
) av ON a.type_no = av.type_no";

            ExecuteNonQuery(updateQuery);
        }
        private int ExecuteNonQuery(string query, List<SqlParameter> parameters = null)
        {
            int rowsAffected = 0;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    SqlCommand command = new SqlCommand(query, connect);

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }

                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing non-query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return rowsAffected;
        }
        private void GetStatus()
        {
            List<string> typeNumbers = new List<string>
            {
                "F0C12H1266", "F0C12H1267", "F0C12H1268", "F0C12H1269",
                "F00C1H3182", "F00C1H3183", "F00C1H3184", "F00C1H3185"
            };

            Dictionary<string, Panel> panels = new Dictionary<string, Panel>
            {
                { "F0C12H1266", panel_F0C12H1266 }, { "F0C12H1267", panel_F0C12H1267 },
                { "F0C12H1268", panel_F0C12H1268 }, { "F0C12H1269", panel_F0C12H1269 },
                { "F00C1H3182", panel_F00C1H3182 }, { "F00C1H3183", panel_F00C1H3183 },
                { "F00C1H3184", panel_F00C1H3184 }, { "F00C1H3185", panel_F00C1H3185 }
            };

            foreach (var typeNo in typeNumbers)
            {
                string status = GetStatusForTypeNo(typeNo);
                Color color;

                switch (status)
                {
                    case "High":
                        color = Color.FromArgb(255, 153, 51);
                        break;
                    case "Low":
                        color = Color.FromArgb(255, 0, 0);
                        break;
                    default:
                        color = Color.FromArgb(0, 153, 76);
                        break;
                }

                panels[typeNo].BackColor = color;
            }
        }
        private string GetStatusForTypeNo(string typeNo)
        {
            string status = "Normal";

            string query = @"SELECT Available, MinValue, MaxValue 
                             FROM ReadingType 
                             WHERE Type_no = @typeNo";

            DataTable dataTable = ExecuteQuery(query, new List<SqlParameter> { new SqlParameter("@typeNo", typeNo) });

            if (dataTable.Rows.Count > 0)
            {
                int available = Convert.ToInt32(dataTable.Rows[0]["Available"]);
                int minValue = Convert.ToInt32(dataTable.Rows[0]["MinValue"]);
                int maxValue = Convert.ToInt32(dataTable.Rows[0]["MaxValue"]);

                if (available < minValue)
                {
                    status = "Low";
                }
                else if (available > maxValue)
                {
                    status = "High";
                }
            }

            return status;
        }
        private void GetTotalQuantity()
        {
            DateTime fromDate = FromDate.Value;
            DateTime toDate = ToDate.Value;
            string txnType = txn_type.SelectedItem?.ToString();

            // Construct the SQL query to get the total quantity for the selected date range and transaction type
            string query = @"SELECT COALESCE(SUM(quantity), 0) AS TotalQuantity
                             FROM TransactionRecords 
                             WHERE txn_date BETWEEN @fromDate AND @toDate";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@fromDate", fromDate),
                new SqlParameter("@toDate", toDate)
            };

            if (!string.IsNullOrEmpty(txnType))
            {
                query += " AND txn_type = @txnType";
                parameters.Add(new SqlParameter("@txnType", txnType));
            }

            List<string> selectedTypeNumbers = new List<string>();
            foreach (var item in TypeNo.CheckedItems)
            {
                selectedTypeNumbers.Add(item.ToString());
            }

            // Add filter by selected type numbers
            if (selectedTypeNumbers.Count > 0)
            {
                string typeNumberFilter = string.Join(",", selectedTypeNumbers.Select(x => "'" + x + "'"));
                query += $" AND type_no IN ({typeNumberFilter})";
            }

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddRange(parameters.ToArray());
                // Execute the query and get the total quantity
                object result = command.ExecuteScalar();
                int totalQuantity = Convert.ToInt32(result);
                // Update the quantity label
                quantity.Text = totalQuantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total quantity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        private void SelectAllTypeNumbers()
        {
            for (int i = 0; i < TypeNo.Items.Count; i++)
            {
                TypeNo.SetItemChecked(i, true);
            }
        }
        private void clearSelections()
        {
            // Clear all selections
            for (int i = 0; i < TypeNo.Items.Count; i++)
            {
                TypeNo.SetItemChecked(i, false);
            }
            txn_type.Text = "";
            FromDate.Text = "";
            ToDate.Text = "";
            SelectAll.Checked = false;
            panel2.Text=string.Empty;
        }
      
        private void IN_Click(object sender, EventArgs e)
        {
            GetTotalQuantity();
        }
        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                SelectAllTypeNumbers();
            }
            else if (!checkBox.Checked)
            {
                // Clear all selections
                for (int i = 0; i < TypeNo.Items.Count; i++)
                {
                    TypeNo.SetItemChecked(i, false);
                }
            }
        }
        private void ClearSelections_Click(object sender, EventArgs e)
        {
            clearSelections();
        }
       
    }
}
