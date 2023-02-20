namespace UserAuth
{
    partial class login
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.signin = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uname = new Krypton.Toolkit.KryptonTextBox();
            this.password = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // signin
            // 
            this.signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signin.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.signin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.signin.BorderRadius = 5;
            this.signin.BorderSize = 2;
            this.signin.FlatAppearance.BorderSize = 0;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.DimGray;
            this.signin.Location = new System.Drawing.Point(40, 124);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(250, 34);
            this.signin.TabIndex = 10;
            this.signin.Text = "Sign In";
            this.signin.TextColor = System.Drawing.Color.DimGray;
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(45, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 23);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // uname
            // 
            this.uname.CueHint.Color1 = System.Drawing.Color.DarkGray;
            this.uname.CueHint.CueHintText = "User Name";
            this.uname.CueHint.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.uname.Location = new System.Drawing.Point(40, 21);
            this.uname.Name = "uname";
            this.uname.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.uname.Size = new System.Drawing.Size(250, 37);
            this.uname.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.uname.StateActive.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.uname.StateActive.Border.Color2 = System.Drawing.Color.MediumSlateBlue;
            this.uname.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.uname.StateActive.Border.Rounding = 5F;
            this.uname.StateActive.Border.Width = 2;
            this.uname.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.uname.StateCommon.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.uname.StateCommon.Border.Color2 = System.Drawing.Color.MediumSlateBlue;
            this.uname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.uname.StateCommon.Border.Rounding = 0F;
            this.uname.StateCommon.Border.Width = 2;
            this.uname.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.uname.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.StateCommon.Content.Padding = new System.Windows.Forms.Padding(23, 4, 0, 0);
            this.uname.TabIndex = 14;
            // 
            // password
            // 
            this.password.CueHint.Color1 = System.Drawing.Color.DarkGray;
            this.password.CueHint.CueHintText = "Password";
            this.password.CueHint.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.password.Location = new System.Drawing.Point(40, 74);
            this.password.Name = "password";
            this.password.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(250, 37);
            this.password.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.password.StateActive.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.password.StateActive.Border.Color2 = System.Drawing.Color.MediumSlateBlue;
            this.password.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password.StateActive.Border.Rounding = 5F;
            this.password.StateActive.Border.Width = 2;
            this.password.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.password.StateCommon.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.password.StateCommon.Border.Color2 = System.Drawing.Color.MediumSlateBlue;
            this.password.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password.StateCommon.Border.Rounding = 0F;
            this.password.StateCommon.Border.Width = 2;
            this.password.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.password.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.StateCommon.Content.Padding = new System.Windows.Forms.Padding(23, 4, 0, 0);
            this.password.TabIndex = 15;
            this.password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.password);
            this.Name = "login";
            this.Size = new System.Drawing.Size(330, 194);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton signin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Krypton.Toolkit.KryptonTextBox uname;
        public Krypton.Toolkit.KryptonTextBox password;
    }
}
