
namespace d2_rentals
{
    partial class loginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.d2 = new System.Windows.Forms.Label();
            this.Rentals = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.drive = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Usertb = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.pswtb = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clearlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.BackColor = System.Drawing.SystemColors.Info;
            this.d2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Location = new System.Drawing.Point(130, 108);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(48, 45);
            this.d2.TabIndex = 1;
            this.d2.Text = "d²";
            this.d2.Click += new System.EventHandler(this.d2_Click);
            // 
            // Rentals
            // 
            this.Rentals.AutoSize = true;
            this.Rentals.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentals.Location = new System.Drawing.Point(144, 142);
            this.Rentals.Name = "Rentals";
            this.Rentals.Size = new System.Drawing.Size(110, 36);
            this.Rentals.TabIndex = 2;
            this.Rentals.Text = "Rentals";
            this.Rentals.Click += new System.EventHandler(this.Rentals_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.welcome.Location = new System.Drawing.Point(310, 73);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(482, 33);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "\"Welcome to the team - Together,";
            // 
            // drive
            // 
            this.drive.AutoSize = true;
            this.drive.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive.ForeColor = System.Drawing.Color.Salmon;
            this.drive.Location = new System.Drawing.Point(491, 106);
            this.drive.Name = "drive";
            this.drive.Size = new System.Drawing.Size(460, 33);
            this.drive.TabIndex = 4;
            this.drive.Text = "let\'s drive our success forward!\"";
            this.drive.Click += new System.EventHandler(this.drive_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Salmon;
            this.Username.Location = new System.Drawing.Point(375, 264);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(110, 25);
            this.Username.TabIndex = 5;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usertb
            // 
            this.Usertb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Usertb.Location = new System.Drawing.Point(380, 292);
            this.Usertb.Name = "Usertb";
            this.Usertb.Size = new System.Drawing.Size(244, 20);
            this.Usertb.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Salmon;
            this.Password.Location = new System.Drawing.Point(375, 324);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 25);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // pswtb
            // 
            this.pswtb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pswtb.Location = new System.Drawing.Point(380, 352);
            this.pswtb.Name = "pswtb";
            this.pswtb.Size = new System.Drawing.Size(244, 20);
            this.pswtb.TabIndex = 8;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.IndianRed;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginButton.Location = new System.Drawing.Point(453, 387);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(92, 37);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Salmon;
            this.exit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.exit.Location = new System.Drawing.Point(937, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(23, 20);
            this.exit.TabIndex = 11;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Clearlbl
            // 
            this.Clearlbl.AutoSize = true;
            this.Clearlbl.BackColor = System.Drawing.SystemColors.Info;
            this.Clearlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearlbl.ForeColor = System.Drawing.Color.Red;
            this.Clearlbl.Location = new System.Drawing.Point(476, 437);
            this.Clearlbl.Name = "Clearlbl";
            this.Clearlbl.Size = new System.Drawing.Size(40, 16);
            this.Clearlbl.TabIndex = 12;
            this.Clearlbl.Text = "Clear";
            this.Clearlbl.Click += new System.EventHandler(this.Clearlbl_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.Clearlbl);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pswtb);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Usertb);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.drive);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.Rentals);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label d2;
        private System.Windows.Forms.Label Rentals;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label drive;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox Usertb;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox pswtb;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label Clearlbl;
    }
}

