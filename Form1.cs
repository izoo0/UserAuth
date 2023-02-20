using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace UserAuth
{
    public partial class Form : KryptonForm
    {
        public Form()
        {
            InitializeComponent();
          
        }
     
        private void register_Click(object sender, EventArgs e)
        {
            this.register1.Visible = true;
            this.label1.Text = "Register";
            this.login1.Visible = false;
            
        }

        private void login_Click(object sender, EventArgs e)
        {
         this.register1.Visible=false;
            this.login1.Visible = true;
            this.label1.Text = "Login";
        }
    }
}
