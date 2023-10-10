
namespace d2_rentals
{
    partial class Customerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customerform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.seconds = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.phoneleft = new System.Windows.Forms.Label();
            this.acustomer = new System.Windows.Forms.Label();
            this.months = new System.Windows.Forms.Label();
            this.BACKuser = new System.Windows.Forms.Button();
            this.DELETEuser = new System.Windows.Forms.Button();
            this.EDITuser = new System.Windows.Forms.Button();
            this.ADDuser = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.Custid = new System.Windows.Forms.TextBox();
            this.Addressleft = new System.Windows.Forms.Label();
            this.Nameleft = new System.Windows.Forms.Label();
            this.Custleft = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustName = new System.Windows.Forms.TextBox();
            this.CustomerDatagrid = new System.Windows.Forms.DataGridView();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPanel.Controls.Add(this.CustName);
            this.UserPanel.Controls.Add(this.seconds);
            this.UserPanel.Controls.Add(this.Phone);
            this.UserPanel.Controls.Add(this.phoneleft);
            this.UserPanel.Controls.Add(this.acustomer);
            this.UserPanel.Controls.Add(this.months);
            this.UserPanel.Controls.Add(this.BACKuser);
            this.UserPanel.Controls.Add(this.DELETEuser);
            this.UserPanel.Controls.Add(this.EDITuser);
            this.UserPanel.Controls.Add(this.ADDuser);
            this.UserPanel.Controls.Add(this.Address);
            this.UserPanel.Controls.Add(this.Custid);
            this.UserPanel.Controls.Add(this.Addressleft);
            this.UserPanel.Controls.Add(this.Nameleft);
            this.UserPanel.Controls.Add(this.Custleft);
            this.UserPanel.Controls.Add(this.pictureBox1);
            this.UserPanel.Location = new System.Drawing.Point(-4, -2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(309, 563);
            this.UserPanel.TabIndex = 2;
            this.UserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserPanel_Paint);
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.ForeColor = System.Drawing.Color.OrangeRed;
            this.seconds.Location = new System.Drawing.Point(71, 71);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(206, 24);
            this.seconds.TabIndex = 12;
            this.seconds.Text = "seconds to loose one...";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(117, 305);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(166, 20);
            this.Phone.TabIndex = 11;
            // 
            // phoneleft
            // 
            this.phoneleft.AutoSize = true;
            this.phoneleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phoneleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneleft.Location = new System.Drawing.Point(16, 301);
            this.phoneleft.Name = "phoneleft";
            this.phoneleft.Size = new System.Drawing.Size(66, 24);
            this.phoneleft.TabIndex = 10;
            this.phoneleft.Text = "Phone";
            // 
            // acustomer
            // 
            this.acustomer.AutoSize = true;
            this.acustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acustomer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.acustomer.Location = new System.Drawing.Point(199, 47);
            this.acustomer.Name = "acustomer";
            this.acustomer.Size = new System.Drawing.Size(118, 24);
            this.acustomer.TabIndex = 9;
            this.acustomer.Text = "a customer...";
            // 
            // months
            // 
            this.months.AutoSize = true;
            this.months.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.months.ForeColor = System.Drawing.Color.SaddleBrown;
            this.months.Location = new System.Drawing.Point(71, 23);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(179, 24);
            this.months.TabIndex = 1;
            this.months.Text = "It take months to find";
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
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(117, 260);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(166, 20);
            this.Address.TabIndex = 5;
            // 
            // Custid
            // 
            this.Custid.Location = new System.Drawing.Point(117, 175);
            this.Custid.Name = "Custid";
            this.Custid.Size = new System.Drawing.Size(166, 20);
            this.Custid.TabIndex = 1;
            // 
            // Addressleft
            // 
            this.Addressleft.AutoSize = true;
            this.Addressleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Addressleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addressleft.Location = new System.Drawing.Point(16, 256);
            this.Addressleft.Name = "Addressleft";
            this.Addressleft.Size = new System.Drawing.Size(80, 24);
            this.Addressleft.TabIndex = 3;
            this.Addressleft.Text = "Address";
            // 
            // Nameleft
            // 
            this.Nameleft.AutoSize = true;
            this.Nameleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Nameleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nameleft.Location = new System.Drawing.Point(16, 213);
            this.Nameleft.Name = "Nameleft";
            this.Nameleft.Size = new System.Drawing.Size(61, 24);
            this.Nameleft.TabIndex = 2;
            this.Nameleft.Text = "Name";
            // 
            // Custleft
            // 
            this.Custleft.AutoSize = true;
            this.Custleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Custleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custleft.Location = new System.Drawing.Point(16, 171);
            this.Custleft.Name = "Custleft";
            this.Custleft.Size = new System.Drawing.Size(69, 24);
            this.Custleft.TabIndex = 1;
            this.Custleft.Text = "Cust ID";
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
            // CustName
            // 
            this.CustName.Location = new System.Drawing.Point(117, 218);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(166, 20);
            this.CustName.TabIndex = 13;
            // 
            // CustomerDatagrid
            // 
            this.CustomerDatagrid.AllowDrop = true;
            this.CustomerDatagrid.AllowUserToAddRows = false;
            this.CustomerDatagrid.AllowUserToDeleteRows = false;
            this.CustomerDatagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.CustomerDatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CustomerDatagrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomerDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDatagrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.CustomerDatagrid.Enabled = false;
            this.CustomerDatagrid.GridColor = System.Drawing.SystemColors.Highlight;
            this.CustomerDatagrid.Location = new System.Drawing.Point(303, 1);
            this.CustomerDatagrid.MultiSelect = false;
            this.CustomerDatagrid.Name = "CustomerDatagrid";
            this.CustomerDatagrid.ReadOnly = true;
            this.CustomerDatagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.CustomerDatagrid.RowHeadersVisible = false;
            this.CustomerDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CustomerDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDatagrid.ShowCellErrors = false;
            this.CustomerDatagrid.ShowCellToolTips = false;
            this.CustomerDatagrid.ShowRowErrors = false;
            this.CustomerDatagrid.Size = new System.Drawing.Size(663, 559);
            this.CustomerDatagrid.TabIndex = 4;
            this.CustomerDatagrid.VirtualMode = true;
            // 
            // Customerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.CustomerDatagrid);
            this.Controls.Add(this.UserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label phoneleft;
        private System.Windows.Forms.Label acustomer;
        private System.Windows.Forms.Label months;
        private System.Windows.Forms.Button BACKuser;
        private System.Windows.Forms.Button DELETEuser;
        private System.Windows.Forms.Button EDITuser;
        private System.Windows.Forms.Button ADDuser;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Custid;
        private System.Windows.Forms.Label Addressleft;
        private System.Windows.Forms.Label Nameleft;
        private System.Windows.Forms.Label Custleft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.DataGridView CustomerDatagrid;
    }
}