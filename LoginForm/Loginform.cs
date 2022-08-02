using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataDBLib;
using System.Configuration;

namespace WindowsFormsAppDB
{
    public partial class LoginForm : Form
    {
        EmpDataSource empDataSource;
        public LoginForm()
        {
            InitializeComponent();
            empDataSource = new EmpDataSource(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            USERDATA user = new USERDATA();

            try
            {
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                if (empDataSource.ValidateUser(user))
                {
                    MessageBox.Show("Login Successful..");
                    this.Hide();
                    DataDML page2 = new DataDML();
                    page2.Show();
                }
                else { MessageBox.Show("Login Failed..!"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { clearTextbox(); }
        }

        void clearTextbox() {
            txtPassword.Text = String.Empty;
            txtUsername.Text = String.Empty;
        }
    }
}
