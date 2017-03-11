using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TEST
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TEST\TNCT.accdb");

            con.Open();
            OleDbDataAdapter dta = new OleDbDataAdapter("select * from PRODUCTS", con);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            var sqlQuery = "";
            if (IfProductExists(con, txtProductCode.Text))
            {
                sqlQuery = @"UPDATE PRODUCTS SET [PRODUCT_NAME] = '" + txtProductName.Text + "' WHERE [PRODUCT_CODE] = '" + txtProductCode.Text + "' ";
            }
            else
            {
                sqlQuery = @"INSERT INTO PRODUCTS (`PRODUCT_CODE`, `PRODUCT_NAME`) VALUES 
                            ('" + txtProductCode.Text + "', '" + txtProductName.Text + "')";
            }

            OleDbCommand cmd = new OleDbCommand(sqlQuery, con);
                //(@"INSERT INTO PRODUCTS (`PRODUCT_CODE`, `PRODUCT_NAME`) VALUES ('" + txtProductCode.Text + "', '" + txtProductName.Text + "')");
            cmd.ExecuteNonQuery();
            con.Close();
             
            //REDING DATA
            LoadData();
        }
        private bool IfProductExists(OleDbConnection con, string productCode)
        {
            OleDbDataAdapter dta = new OleDbDataAdapter(@"Select * From PRODUCTS WHERE PRODUCT_CODE = '" + productCode +"' ", con);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void LoadData()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TEST\TNCT.accdb");
            OleDbDataAdapter dta = new OleDbDataAdapter("SELECT * FROM PRODUCTS", con);
            DataTable dt = new DataTable();
            dta.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["PRODUCT_CODE"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["PRODUCT_NAME"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtProductCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\TEST\TNCT.accdb");
            
            var sqlQuery = "";
            if (IfProductExists(con, txtProductCode.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [PRODUCTS] WHERE [PRODUCT_CODE] = '" + txtProductCode.Text + "' ";
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

