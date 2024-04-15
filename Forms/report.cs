using System;
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
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ReelManagement
{
    public partial class report : Form
    {

        private int flag = 0;
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        public report()
        {
            InitializeComponent();
            LoadData();
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
        }
        private void LoadData()
        {
            try
            {
                connect.Open();

                string query = @"
SELECT 
    txn_date AS Date, 
    txn_time AS Time, 
    txn_shift AS Shift,
    curr_user AS 'Txn User', 
    type_no AS 'Type No.', 
    quantity AS Quantity, 
    batch_no AS 'Batch No.', 
    txn_type AS 'Txn Type(IN/OUT)', 
    rack_loc AS 'Rack Location' 
FROM 
    TransactionRecords
WHERE 
    txn_date = @TodayDate
ORDER BY 
    txn_date DESC, txn_time DESC";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@TodayDate", DateTime.Today);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                report_display.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void ApplyFilters()
        {
            // Get filter values from controls
            DateTime fromDate = FromDate.Value;
            DateTime toDate = ToDate.Value;
            string txnType = txn_type.SelectedItem?.ToString();
            string typeNo = type_no.Text.Trim();

            // Construct SQL query with filter criteria
            string query = "SELECT * FROM TransactionRecords WHERE txn_date BETWEEN @fromDate AND @toDate";
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

            if (!string.IsNullOrEmpty(typeNo))
            {
                query += " AND type_no = @typeNo";
                parameters.Add(new SqlParameter("@typeNo", typeNo));
            }
            query += " ORDER BY txn_date DESC, txn_time DESC";
            try
            {
                {
                    connect.Open();

                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddRange(parameters.ToArray());
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    report_display.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying filters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void refresh_screen()
        {
            LoadData();
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
            type_no.Text = string.Empty;
            txn_type.Text = string.Empty;
        }
        private void ClearSelections_Click(object sender, EventArgs e)
        {
            refresh_screen();
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
