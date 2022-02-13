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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRagistration_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && txtPassword.Text != "") {
                string sel = "select * from form where name='" + txtName.Text + "' and password='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sel, Class1.cn);
                int a = sda.Fill(Class1.dt);
                if (a >= 0)
                {
                    home h = new home();
                    h.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Not Login");
                }
            } else { 
                MessageBox.Show("Pleas, Enter a name or password...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear() {
            txtName.Text = "";
            txtPassword.Text = "";
            txtName.Focus();
        }
    }
}
