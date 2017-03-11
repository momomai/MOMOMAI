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

namespace TEST
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            
        }


        //CHECK LOGIN BY USERNAME VS. PASSWORD
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\file visual studio\test\TNCT.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from LOGIN where USERNAME= '" + txtUsername.Text + "' and PASSWORD='" + txtPass.Text + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {

                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง !!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }


        // BUTTON EXIT
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณแน่ใจ ว่าจะออกจากโปรแกรม ?", "ออก", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

