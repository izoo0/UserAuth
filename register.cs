using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAuth
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            runame.Text=rupassword.Text=rrpassword.Text=String.Empty;   
        }

        private void signup_Click(object sender, EventArgs e)
        {
      if (runame.Text.Trim().Length<3)
            {
                MessageBox.Show("username can not be empty or less than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }else
            if(rupassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("password can not be empty or less tha 6 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }else
            if(rupassword.Text != rrpassword.Text)
            {
                MessageBox.Show("password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            else
            {
                users usr = new users(runame.Text.Trim(), rupassword.Text.Trim());
                userDb.addUser(usr);
                Clear();
           }
        }
    }
}
