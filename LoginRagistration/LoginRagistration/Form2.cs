using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LoginRagistration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnRagistration_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPassword.Text != "")
            {
                string ins = "insert into form values('" + txtName.Text + "','" + txtPassword.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(ins, Class1.cn);
                DataTable dt = new DataTable();
                int a = sda.Fill(dt);
                if (a >= 0)
                {
                    MessageBox.Show("Inserted");
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Not Inserted");
                    clear(); 
                }
            }
            else { 
                MessageBox.Show("Pleas enter a data...!"); 
            }
        }
        private void clear()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
