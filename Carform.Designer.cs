
namespace d2_rentals
{
    partial class Carform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.Available = new System.Windows.Forms.ComboBox();
            this.availableleft = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.priceleft = new System.Windows.Forms.Label();
            this.promise = new System.Windows.Forms.Label();
            this.onemore = new System.Windows.Forms.Label();
            this.BACKuser = new System.Windows.Forms.Button();
            this.DELETEuser = new System.Windows.Forms.Button();
            this.EDITuser = new System.Windows.Forms.Button();
            this.ADDuser = new System.Windows.Forms.Button();
            this.Model = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.TextBox();
            this.RegNum = new System.Windows.Forms.TextBox();
            this.Modelleft = new System.Windows.Forms.Label();
            this.brandleft = new System.Windows.Forms.Label();
            this.regleft = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CarDGV = new System.Windows.Forms.DataGridView();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPanel.Controls.Add(this.Available);
            this.UserPanel.Controls.Add(this.availableleft);
            this.UserPanel.Controls.Add(this.Price);
            this.UserPanel.Controls.Add(this.priceleft);
            this.UserPanel.Controls.Add(this.promise);
            this.UserPanel.Controls.Add(this.onemore);
            this.UserPanel.Controls.Add(this.BACKuser);
            this.UserPanel.Controls.Add(this.DELETEuser);
            this.UserPanel.Controls.Add(this.EDITuser);
            this.UserPanel.Controls.Add(this.ADDuser);
            this.UserPanel.Controls.Add(this.Model);
            this.UserPanel.Controls.Add(this.Brand);
            this.UserPanel.Controls.Add(this.RegNum);
            this.UserPanel.Controls.Add(this.Modelleft);
            this.UserPanel.Controls.Add(this.brandleft);
            this.UserPanel.Controls.Add(this.regleft);
            this.UserPanel.Controls.Add(this.pictureBox1);
            this.UserPanel.Location = new System.Drawing.Point(-4, -2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(309, 562);
            this.UserPanel.TabIndex = 1;
            this.UserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserPanel_Paint);
            // 
            // Available
            // 
            this.Available.FormattingEnabled = true;
            this.Available.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Available.Location = new System.Drawing.Point(117, 315);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(166, 21);
            this.Available.TabIndex = 4;
            // 
            // availableleft
            // 
            this.availableleft.AutoSize = true;
            this.availableleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.availableleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableleft.Location = new System.Drawing.Point(16, 312);
            this.availableleft.Name = "availableleft";
            this.availableleft.Size = new System.Drawing.Size(86, 24);
            this.availableleft.TabIndex = 12;
            this.availableleft.Text = "Available";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(117, 272);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(166, 20);
            this.Price.TabIndex = 11;
            // 
            // priceleft
            // 
            this.priceleft.AutoSize = true;
            this.priceleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.priceleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceleft.Location = new System.Drawing.Point(16, 268);
            this.priceleft.Name = "priceleft";
            this.priceleft.Size = new System.Drawing.Size(53, 24);
            this.priceleft.TabIndex = 10;
            this.priceleft.Text = "Price";
            // 
            // promise
            // 
            this.promise.AutoSize = true;
            this.promise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promise.ForeColor = System.Drawing.Color.OrangeRed;
            this.promise.Location = new System.Drawing.Point(199, 47);
            this.promise.Name = "promise";
            this.promise.Size = new System.Drawing.Size(102, 24);
            this.promise.TabIndex = 9;
            this.promise.Text = "I promise...";
            // 
            // onemore
            // 
            this.onemore.AutoSize = true;
            this.onemore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onemore.ForeColor = System.Drawing.Color.SaddleBrown;
            this.onemore.Location = new System.Drawing.Point(71, 23);
            this.onemore.Name = "onemore";
            this.onemore.Size = new System.Drawing.Size(161, 24);
            this.onemore.TabIndex = 1;
            this.onemore.Text = "Just one more car";
            // 
            // BACKuser
            // 
            this.BACKuser.BackColor = System.Drawing.SystemColors.Info;
            this.BACKuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKuser.Location = new System.Drawing.Point(117, 431);
            this.BACKuser.Name = "BACKuser";
            this.BACKuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BACKuser.Size = new System.Drawing.Size(67, 24);
            this.BACKuser.TabIndex = 8;
            this.BACKuser.Text = "BACK";
            this.BACKuser.UseVisualStyleBackColor = false;
            this.BACKuser.Click += new System.EventHandler(this.BACKuser_Click);
            // 
            // DELETEuser
            // 
            this.DELETEuser.BackColor = System.Drawing.SystemColors.Info;
            this.DELETEuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEuser.Location = new System.Drawing.Point(216, 389);
            this.DELETEuser.Name = "DELETEuser";
            this.DELETEuser.Size = new System.Drawing.Size(67, 24);
            this.DELETEuser.TabIndex = 7;
            this.DELETEuser.Text = "DELETE";
            this.DELETEuser.UseVisualStyleBackColor = false;
            this.DELETEuser.Click += new System.EventHandler(this.DELETEuser_Click);
            // 
            // EDITuser
            // 
            this.EDITuser.BackColor = System.Drawing.SystemColors.Info;
            this.EDITuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITuser.Location = new System.Drawing.Point(117, 389);
            this.EDITuser.Name = "EDITuser";
            this.EDITuser.Size = new System.Drawing.Size(67, 24);
            this.EDITuser.TabIndex = 6;
            this.EDITuser.Text = "EDIT";
            this.EDITuser.UseVisualStyleBackColor = false;
            this.EDITuser.Click += new System.EventHandler(this.EDITuser_Click);
            // 
            // ADDuser
            // 
            this.ADDuser.BackColor = System.Drawing.SystemColors.Info;
            this.ADDuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDuser.Location = new System.Drawing.Point(20, 389);
            this.ADDuser.Name = "ADDuser";
            this.ADDuser.Size = new System.Drawing.Size(67, 24);
            this.ADDuser.TabIndex = 1;
            this.ADDuser.Text = "ADD";
            this.ADDuser.UseVisualStyleBackColor = false;
            this.ADDuser.Click += new System.EventHandler(this.ADDuser_Click);
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(117, 226);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(166, 20);
            this.Model.TabIndex = 5;
            // 
            // Brand
            // 
            this.Brand.Location = new System.Drawing.Point(117, 181);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(166, 20);
            this.Brand.TabIndex = 4;
            // 
            // RegNum
            // 
            this.RegNum.Location = new System.Drawing.Point(117, 135);
            this.RegNum.Name = "RegNum";
            this.RegNum.Size = new System.Drawing.Size(166, 20);
            this.RegNum.TabIndex = 1;
            // 
            // Modelleft
            // 
            this.Modelleft.AutoSize = true;
            this.Modelleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Modelleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelleft.Location = new System.Drawing.Point(16, 222);
            this.Modelleft.Name = "Modelleft";
            this.Modelleft.Size = new System.Drawing.Size(63, 24);
            this.Modelleft.TabIndex = 3;
            this.Modelleft.Text = "Model";
            this.Modelleft.Click += new System.EventHandler(this.label3_Click);
            // 
            // brandleft
            // 
            this.brandleft.AutoSize = true;
            this.brandleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.brandleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandleft.Location = new System.Drawing.Point(16, 177);
            this.brandleft.Name = "brandleft";
            this.brandleft.Size = new System.Drawing.Size(60, 24);
            this.brandleft.TabIndex = 2;
            this.brandleft.Text = "Brand";
            // 
            // regleft
            // 
            this.regleft.AutoSize = true;
            this.regleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.regleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regleft.Location = new System.Drawing.Point(16, 131);
            this.regleft.Name = "regleft";
            this.regleft.Size = new System.Drawing.Size(70, 24);
            this.regleft.TabIndex = 1;
            this.regleft.Text = "RegNo";
            this.regleft.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 47);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CarDGV
            // 
            this.CarDGV.AllowDrop = true;
            this.CarDGV.AllowUserToAddRows = false;
            this.CarDGV.AllowUserToDeleteRows = false;
            this.CarDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CarDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CarDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CarDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.CarDGV.Enabled = false;
            this.CarDGV.Location = new System.Drawing.Point(303, 1);
            this.CarDGV.MultiSelect = false;
            this.CarDGV.Name = "CarDGV";
            this.CarDGV.ReadOnly = true;
            this.CarDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CarDGV.RowHeadersVisible = false;
            this.CarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarDGV.ShowCellErrors = false;
            this.CarDGV.ShowCellToolTips = false;
            this.CarDGV.ShowRowErrors = false;
            this.CarDGV.Size = new System.Drawing.Size(663, 559);
            this.CarDGV.TabIndex = 3;
            this.CarDGV.VirtualMode = true;
            this.CarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarDGV_CellContentClick);
            // 
            // Carform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.CarDGV);
            this.Controls.Add(this.UserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carform";
            this.Load += new System.EventHandler(this.Carform_Load);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label promise;
        private System.Windows.Forms.Label onemore;
        private System.Windows.Forms.Button BACKuser;
        private System.Windows.Forms.Button DELETEuser;
        private System.Windows.Forms.Button EDITuser;
        private System.Windows.Forms.Button ADDuser;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.TextBox RegNum;
        private System.Windows.Forms.Label Modelleft;
        private System.Windows.Forms.Label brandleft;
        private System.Windows.Forms.Label regleft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView CarDGV;
        private System.Windows.Forms.ComboBox Available;
        private System.Windows.Forms.Label availableleft;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label priceleft;
    }
}