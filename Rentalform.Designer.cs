
namespace d2_rentals
{
    partial class Rentalform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rentalform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.custbox = new System.Windows.Forms.ComboBox();
            this.Renttb = new System.Windows.Forms.TextBox();
            this.returndatecldr = new System.Windows.Forms.DateTimePicker();
            this.rentdatecldr = new System.Windows.Forms.DateTimePicker();
            this.labelRent = new System.Windows.Forms.Label();
            this.regbox = new System.Windows.Forms.ComboBox();
            this.labelreturndate = new System.Windows.Forms.Label();
            this.Cname = new System.Windows.Forms.TextBox();
            this.labelrentdate = new System.Windows.Forms.Label();
            this.Nameleft = new System.Windows.Forms.Label();
            this.more = new System.Windows.Forms.Label();
            this.lets = new System.Windows.Forms.Label();
            this.BACKuser = new System.Windows.Forms.Button();
            this.EDITuser = new System.Windows.Forms.Button();
            this.ADDuser = new System.Windows.Forms.Button();
            this.Custleft = new System.Windows.Forms.Label();
            this.Regleft = new System.Windows.Forms.Label();
            this.rentleft = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Rentalgrid = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.RRentid = new System.Windows.Forms.TextBox();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rentalgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPanel.Controls.Add(this.RRentid);
            this.UserPanel.Controls.Add(this.Deletebtn);
            this.UserPanel.Controls.Add(this.custbox);
            this.UserPanel.Controls.Add(this.Renttb);
            this.UserPanel.Controls.Add(this.returndatecldr);
            this.UserPanel.Controls.Add(this.rentdatecldr);
            this.UserPanel.Controls.Add(this.labelRent);
            this.UserPanel.Controls.Add(this.regbox);
            this.UserPanel.Controls.Add(this.labelreturndate);
            this.UserPanel.Controls.Add(this.Cname);
            this.UserPanel.Controls.Add(this.labelrentdate);
            this.UserPanel.Controls.Add(this.Nameleft);
            this.UserPanel.Controls.Add(this.more);
            this.UserPanel.Controls.Add(this.lets);
            this.UserPanel.Controls.Add(this.BACKuser);
            this.UserPanel.Controls.Add(this.EDITuser);
            this.UserPanel.Controls.Add(this.ADDuser);
            this.UserPanel.Controls.Add(this.Custleft);
            this.UserPanel.Controls.Add(this.Regleft);
            this.UserPanel.Controls.Add(this.rentleft);
            this.UserPanel.Controls.Add(this.pictureBox1);
            this.UserPanel.Location = new System.Drawing.Point(-4, -2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(309, 563);
            this.UserPanel.TabIndex = 3;
            this.UserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserPanel_Paint);
            // 
            // custbox
            // 
            this.custbox.FormattingEnabled = true;
            this.custbox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.custbox.Location = new System.Drawing.Point(117, 193);
            this.custbox.Name = "custbox";
            this.custbox.Size = new System.Drawing.Size(166, 21);
            this.custbox.TabIndex = 14;
            this.custbox.SelectionChangeCommitted += new System.EventHandler(this.custbox_SelectionChangeCommitted);
            // 
            // Renttb
            // 
            this.Renttb.Location = new System.Drawing.Point(117, 360);
            this.Renttb.Name = "Renttb";
            this.Renttb.Size = new System.Drawing.Size(166, 20);
            this.Renttb.TabIndex = 13;
            // 
            // returndatecldr
            // 
            this.returndatecldr.Location = new System.Drawing.Point(144, 320);
            this.returndatecldr.Name = "returndatecldr";
            this.returndatecldr.Size = new System.Drawing.Size(157, 20);
            this.returndatecldr.TabIndex = 12;
            // 
            // rentdatecldr
            // 
            this.rentdatecldr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rentdatecldr.Location = new System.Drawing.Point(126, 278);
            this.rentdatecldr.Name = "rentdatecldr";
            this.rentdatecldr.Size = new System.Drawing.Size(157, 20);
            this.rentdatecldr.TabIndex = 6;
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(20, 356);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(49, 24);
            this.labelRent.TabIndex = 8;
            this.labelRent.Text = "Rent";
            // 
            // regbox
            // 
            this.regbox.FormattingEnabled = true;
            this.regbox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.regbox.Location = new System.Drawing.Point(117, 152);
            this.regbox.Name = "regbox";
            this.regbox.Size = new System.Drawing.Size(166, 21);
            this.regbox.TabIndex = 9;
            this.regbox.SelectedIndexChanged += new System.EventHandler(this.regbox_SelectedIndexChanged);
            this.regbox.SelectionChangeCommitted += new System.EventHandler(this.regbox_SelectionChangeCommitted);
            // 
            // labelreturndate
            // 
            this.labelreturndate.AutoSize = true;
            this.labelreturndate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelreturndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreturndate.Location = new System.Drawing.Point(16, 316);
            this.labelreturndate.Name = "labelreturndate";
            this.labelreturndate.Size = new System.Drawing.Size(109, 24);
            this.labelreturndate.TabIndex = 7;
            this.labelreturndate.Text = "Return Date";
            // 
            // Cname
            // 
            this.Cname.BackColor = System.Drawing.SystemColors.Window;
            this.Cname.Enabled = false;
            this.Cname.Location = new System.Drawing.Point(117, 235);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(166, 20);
            this.Cname.TabIndex = 11;
            // 
            // labelrentdate
            // 
            this.labelrentdate.AutoSize = true;
            this.labelrentdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelrentdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrentdate.Location = new System.Drawing.Point(20, 274);
            this.labelrentdate.Name = "labelrentdate";
            this.labelrentdate.Size = new System.Drawing.Size(92, 24);
            this.labelrentdate.TabIndex = 6;
            this.labelrentdate.Text = "Rent Date";
            // 
            // Nameleft
            // 
            this.Nameleft.AutoSize = true;
            this.Nameleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Nameleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nameleft.Location = new System.Drawing.Point(20, 231);
            this.Nameleft.Name = "Nameleft";
            this.Nameleft.Size = new System.Drawing.Size(61, 24);
            this.Nameleft.TabIndex = 10;
            this.Nameleft.Text = "Name";
            // 
            // more
            // 
            this.more.AutoSize = true;
            this.more.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.ForeColor = System.Drawing.Color.OrangeRed;
            this.more.Location = new System.Drawing.Point(184, 47);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(117, 24);
            this.more.TabIndex = 9;
            this.more.Text = "once more...";
            // 
            // lets
            // 
            this.lets.AutoSize = true;
            this.lets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lets.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lets.Location = new System.Drawing.Point(71, 23);
            this.lets.Name = "lets";
            this.lets.Size = new System.Drawing.Size(113, 24);
            this.lets.TabIndex = 1;
            this.lets.Text = "Let\'s rent it...";
            this.lets.Click += new System.EventHandler(this.lets_Click);
            // 
            // BACKuser
            // 
            this.BACKuser.BackColor = System.Drawing.SystemColors.Info;
            this.BACKuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKuser.Location = new System.Drawing.Point(117, 489);
            this.BACKuser.Name = "BACKuser";
            this.BACKuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BACKuser.Size = new System.Drawing.Size(67, 24);
            this.BACKuser.TabIndex = 8;
            this.BACKuser.Text = "BACK";
            this.BACKuser.UseVisualStyleBackColor = false;
            this.BACKuser.Click += new System.EventHandler(this.BACKuser_Click);
            // 
            // EDITuser
            // 
            this.EDITuser.BackColor = System.Drawing.SystemColors.Info;
            this.EDITuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITuser.Location = new System.Drawing.Point(117, 448);
            this.EDITuser.Name = "EDITuser";
            this.EDITuser.Size = new System.Drawing.Size(67, 24);
            this.EDITuser.TabIndex = 6;
            this.EDITuser.Text = "EDIT";
            this.EDITuser.UseVisualStyleBackColor = false;
            // 
            // ADDuser
            // 
            this.ADDuser.BackColor = System.Drawing.SystemColors.Info;
            this.ADDuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDuser.Location = new System.Drawing.Point(20, 448);
            this.ADDuser.Name = "ADDuser";
            this.ADDuser.Size = new System.Drawing.Size(67, 24);
            this.ADDuser.TabIndex = 1;
            this.ADDuser.Text = "ADD";
            this.ADDuser.UseVisualStyleBackColor = false;
            this.ADDuser.Click += new System.EventHandler(this.ADDuser_Click);
            // 
            // Custleft
            // 
            this.Custleft.AutoSize = true;
            this.Custleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Custleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custleft.Location = new System.Drawing.Point(20, 190);
            this.Custleft.Name = "Custleft";
            this.Custleft.Size = new System.Drawing.Size(69, 24);
            this.Custleft.TabIndex = 3;
            this.Custleft.Text = "Cust ID";
            // 
            // Regleft
            // 
            this.Regleft.AutoSize = true;
            this.Regleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Regleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regleft.Location = new System.Drawing.Point(20, 149);
            this.Regleft.Name = "Regleft";
            this.Regleft.Size = new System.Drawing.Size(75, 24);
            this.Regleft.TabIndex = 2;
            this.Regleft.Text = "Reg No";
            // 
            // rentleft
            // 
            this.rentleft.AutoSize = true;
            this.rentleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rentleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentleft.Location = new System.Drawing.Point(20, 109);
            this.rentleft.Name = "rentleft";
            this.rentleft.Size = new System.Drawing.Size(71, 24);
            this.rentleft.TabIndex = 1;
            this.rentleft.Text = "Rent ID";
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
            // Rentalgrid
            // 
            this.Rentalgrid.AllowDrop = true;
            this.Rentalgrid.AllowUserToAddRows = false;
            this.Rentalgrid.AllowUserToDeleteRows = false;
            this.Rentalgrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentalgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Rentalgrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rentalgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rentalgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Rentalgrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rentalgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Rentalgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Rentalgrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.Rentalgrid.Enabled = false;
            this.Rentalgrid.GridColor = System.Drawing.SystemColors.Highlight;
            this.Rentalgrid.Location = new System.Drawing.Point(303, 1);
            this.Rentalgrid.MultiSelect = false;
            this.Rentalgrid.Name = "Rentalgrid";
            this.Rentalgrid.ReadOnly = true;
            this.Rentalgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rentalgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Rentalgrid.RowHeadersVisible = false;
            this.Rentalgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Rentalgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Rentalgrid.ShowCellErrors = false;
            this.Rentalgrid.ShowCellToolTips = false;
            this.Rentalgrid.ShowRowErrors = false;
            this.Rentalgrid.Size = new System.Drawing.Size(663, 559);
            this.Rentalgrid.TabIndex = 5;
            this.Rentalgrid.VirtualMode = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.Info;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(216, 448);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(67, 24);
            this.Deletebtn.TabIndex = 15;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // RRentid
            // 
            this.RRentid.Location = new System.Drawing.Point(117, 113);
            this.RRentid.Name = "RRentid";
            this.RRentid.Size = new System.Drawing.Size(166, 20);
            this.RRentid.TabIndex = 16;
            // 
            // Rentalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.Rentalgrid);
            this.Controls.Add(this.UserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rentalform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rentalform_Load);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rentalgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.Label Nameleft;
        private System.Windows.Forms.Label more;
        private System.Windows.Forms.Label lets;
        private System.Windows.Forms.Button BACKuser;
        private System.Windows.Forms.Button EDITuser;
        private System.Windows.Forms.Button ADDuser;
        private System.Windows.Forms.Label Custleft;
        private System.Windows.Forms.Label Regleft;
        private System.Windows.Forms.Label rentleft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelrentdate;
        private System.Windows.Forms.Label labelreturndate;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.TextBox Renttb;
        private System.Windows.Forms.DateTimePicker returndatecldr;
        private System.Windows.Forms.DateTimePicker rentdatecldr;
        private System.Windows.Forms.ComboBox regbox;
        private System.Windows.Forms.ComboBox custbox;
        private System.Windows.Forms.DataGridView Rentalgrid;
        private System.Windows.Forms.TextBox RRentid;
        private System.Windows.Forms.Button Deletebtn;
    }
}