using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UserAuth
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }
         
        private void signin_Click(object sender, EventArgs e)
        {

            if (uname.Text.Trim().Length < 3)
            {
                MessageBox.Show("username can not be empty or less than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            if (password.Text.Trim().Length < 6)
            {
                MessageBox.Show("password can not be empty or less tha 6 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                string username,pass;

                username = uname.Text;
                pass = password.Text;

                userDb.Select(("SELECT username,password FROM users WHERE username = '"+username+"' AND password = '"+pass+"'"));

                
                Clear();
            }
        }

        private void Clear()
        {
            uname.Text = password.Text = String.Empty;
        }
    }
}
