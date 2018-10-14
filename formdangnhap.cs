using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace baitaplon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void butdangnhap_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Pass = txtpass.Text;
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Pass))
            {
                MessageBox.Show("Bạn cần nhập đủ User và pass", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // if (Username == "Admin" && Pass == "111")
                if (login(Username, Pass) == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("User hoặc Pass không đúng!!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        txtusername.Focus();
                    }
                }
            }


        }

        private bool login(string Username, string Pass)
        {
            string cnstr = "Server= . ; Database= NhânViên; Integrated Security=true";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();

            string sql = "SELECT COUNT(UserName) FROM NhânViên WHERE UserName = '" + Username + "'AND Password = '" + Pass + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            int count = (int)cmd.ExecuteScalar();
            cn.Close();
            if (count == 1)
               return true;
            else
                return false;


        }
    }
        
    }
