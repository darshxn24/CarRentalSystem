
namespace d2_rentals
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.CarButton = new System.Windows.Forms.Button();
            this.Customerbutton = new System.Windows.Forms.Button();
            this.Rentalbutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.Usersbutton = new System.Windows.Forms.Button();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarButton
            // 
            this.CarButton.BackColor = System.Drawing.SystemColors.Info;
            this.CarButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CarButton.Location = new System.Drawing.Point(32, 13);
            this.CarButton.Name = "CarButton";
            this.CarButton.Size = new System.Drawing.Size(135, 39);
            this.CarButton.TabIndex = 11;
            this.CarButton.Text = "Car";
            this.CarButton.UseVisualStyleBackColor = false;
            this.CarButton.Click += new System.EventHandler(this.CarButton_Click);
            // 
            // Customerbutton
            // 
            this.Customerbutton.BackColor = System.Drawing.SystemColors.Info;
            this.Customerbutton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Customerbutton.Location = new System.Drawing.Point(223, 12);
            this.Customerbutton.Name = "Customerbutton";
            this.Customerbutton.Size = new System.Drawing.Size(135, 40);
            this.Customerbutton.TabIndex = 12;
            this.Customerbutton.Text = "Customer";
            this.Customerbutton.UseVisualStyleBackColor = false;
            this.Customerbutton.Click += new System.EventHandler(this.Customerbutton_Click);
            // 
            // Rentalbutton
            // 
            this.Rentalbutton.BackColor = System.Drawing.SystemColors.Info;
            this.Rentalbutton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentalbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Rentalbutton.Location = new System.Drawing.Point(416, 12);
            this.Rentalbutton.Name = "Rentalbutton";
            this.Rentalbutton.Size = new System.Drawing.Size(135, 40);
            this.Rentalbutton.TabIndex = 13;
            this.Rentalbutton.Text = "Rental";
            this.Rentalbutton.UseVisualStyleBackColor = false;
            this.Rentalbutton.Click += new System.EventHandler(this.Rentalbutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.BackColor = System.Drawing.SystemColors.Info;
            this.Returnbutton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Returnbutton.Location = new System.Drawing.Point(610, 12);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(135, 40);
            this.Returnbutton.TabIndex = 14;
            this.Returnbutton.Text = "Return";
            this.Returnbutton.UseVisualStyleBackColor = false;
            // 
            // Usersbutton
            // 
            this.Usersbutton.BackColor = System.Drawing.SystemColors.Info;
            this.Usersbutton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usersbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Usersbutton.Location = new System.Drawing.Point(800, 12);
            this.Usersbutton.Name = "Usersbutton";
            this.Usersbutton.Size = new System.Drawing.Size(135, 40);
            this.Usersbutton.TabIndex = 15;
            this.Usersbutton.Text = "Users";
            this.Usersbutton.UseVisualStyleBackColor = false;
            this.Usersbutton.Click += new System.EventHandler(this.Usersbutton_Click);
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.BackColor = System.Drawing.SystemColors.Info;
            this.Logoutbutton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Logoutbutton.Location = new System.Drawing.Point(416, 467);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(135, 40);
            this.Logoutbutton.TabIndex = 16;
            this.Logoutbutton.Text = "Logout";
            this.Logoutbutton.UseVisualStyleBackColor = false;
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.Usersbutton);
            this.Controls.Add(this.Returnbutton);
            this.Controls.Add(this.Rentalbutton);
            this.Controls.Add(this.Customerbutton);
            this.Controls.Add(this.CarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarButton;
        private System.Windows.Forms.Button Customerbutton;
        private System.Windows.Forms.Button Rentalbutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Button Usersbutton;
        private System.Windows.Forms.Button Logoutbutton;
    }
}