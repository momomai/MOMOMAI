using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Globalization;

namespace TEST
{
    public partial class StockIn : Form
    {
        public StockIn()
        {
            InitializeComponent();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNCTDataSet.STOCK_IN' table. You can move, or remove it, as needed.
            this.sTOCK_INTableAdapter.Fill(this.tNCTDataSet.STOCK_IN);
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\file visual studio\test\TNCT.accdb");

            con.Open();
            OleDbDataAdapter dta = new OleDbDataAdapter("select * from [STOCK IN]", con);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            string d;
            if (dtp_trans.Checked == true)
            {
                d = dtp_trans.Value.ToString();
            }
            else
            {
                d = null;
            }

            var sqlQuery = "";
            if (IfProductExists(con, txt_productcode.Text))
            {
                sqlQuery = @"Update [STOCK IN] SET TRANSDATE = '" + this.dtp_trans.Text + "', DESCRIPTION = '" + txt_descrip.Text + "' "
                        + "PRODUCT_CODE = '" + txt_productcode.Text + "', QUANTITY = '" + txt_quan.Text + "'  AMOUNT = '" + txt_amount.Text + "' "
                        + "NOTATION='" + txt_notation.Text + "' WHERE PRODUCT_CODE = '" + txt_productcode.Text + "' ";
            }
            else
            {
                sqlQuery = @"INSERT INTO [STOCK IN] (TRANSDATE, DESCRIPTION, PRODUCT_CODE, QUANTITY, AMOUNT, NOTATION) VALUES 
                            ('" + this.dtp_trans.Text + "', '" + txt_descrip.Text + "', '" + txt_productcode.Text + "', '" + txt_quan.Text + "', '" + txt_amount.Text + "', '" + txt_notation.Text + "')";
            }

            OleDbCommand cmd = new OleDbCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();


            //READING DATA
            LoadData();
        }

        private bool IfProductExists(OleDbConnection con, string productCode)
        {
            OleDbDataAdapter dta = new OleDbDataAdapter(@"SELECT * FROM [STOCK IN] WHERE PRODUCT_CODE = '" + productCode + "' ", con);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void LoadData()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\file visual studio\test\TNCT.accdb");
            OleDbDataAdapter dta = new OleDbDataAdapter("SELECT * FROM [STOCK IN]", con);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item["TRANSDATE"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["DESCRIPTION"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["PRODUCT_CODE"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["QUANTITY"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["AMOUNT"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["NOTATION"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DateTime dt = DateTime.ParseExact(dataGridView1.CurrentCell.Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            dtp_trans.Value = dt;

            txt_descrip.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_productcode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_quan.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_amount.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_notation.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\file visual studio\test\TNCT.accdb");

            var sqlQuery = "";
            if (IfProductExists(con, txt_productcode.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [STOCK IN] WHERE [PRODUCT_CODE] = '" + txt_productcode.Text + "' ";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Record Not Exists...!");
            }

            //REDING DATA
            LoadData();
        }

    }
}
