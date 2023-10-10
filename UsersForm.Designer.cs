
namespace d2_rentals
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.honesty = new System.Windows.Forms.Label();
            this.BACKuser = new System.Windows.Forms.Button();
            this.DELETEuser = new System.Windows.Forms.Button();
            this.EDITuser = new System.Windows.Forms.Button();
            this.ADDuser = new System.Windows.Forms.Button();
            this.Upassword = new System.Windows.Forms.TextBox();
            this.Uname = new System.Windows.Forms.TextBox();
            this.Uid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserDatagrid = new System.Windows.Forms.DataGridView();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPanel.Controls.Add(this.label4);
            this.UserPanel.Controls.Add(this.honesty);
            this.UserPanel.Controls.Add(this.BACKuser);
            this.UserPanel.Controls.Add(this.DELETEuser);
            this.UserPanel.Controls.Add(this.EDITuser);
            this.UserPanel.Controls.Add(this.ADDuser);
            this.UserPanel.Controls.Add(this.Upassword);
            this.UserPanel.Controls.Add(this.Uname);
            this.UserPanel.Controls.Add(this.Uid);
            this.UserPanel.Controls.Add(this.label3);
            this.UserPanel.Controls.Add(this.label2);
            this.UserPanel.Controls.Add(this.label1);
            this.UserPanel.Controls.Add(this.pictureBox1);
            this.UserPanel.Location = new System.Drawing.Point(-4, -2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(309, 562);
            this.UserPanel.TabIndex = 0;
            this.UserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserPanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(191, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "as honesty...";
            // 
            // honesty
            // 
            this.honesty.AutoSize = true;
            this.honesty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honesty.ForeColor = System.Drawing.Color.SaddleBrown;
            this.honesty.Location = new System.Drawing.Point(71, 23);
            this.honesty.Name = "honesty";
            this.honesty.Size = new System.Drawing.Size(174, 24);
            this.honesty.TabIndex = 1;
            this.honesty.Text = "No legacy is so rich";
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
            // Upassword
            // 
            this.Upassword.Location = new System.Drawing.Point(117, 290);
            this.Upassword.Name = "Upassword";
            this.Upassword.Size = new System.Drawing.Size(166, 20);
            this.Upassword.TabIndex = 5;
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(117, 251);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(166, 20);
            this.Uname.TabIndex = 4;
            // 
            // Uid
            // 
            this.Uid.Location = new System.Drawing.Point(117, 208);
            this.Uid.Name = "Uid";
            this.Uid.Size = new System.Drawing.Size(166, 20);
            this.Uid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // UserDatagrid
            // 
            this.UserDatagrid.AllowDrop = true;
            this.UserDatagrid.AllowUserToAddRows = false;
            this.UserDatagrid.AllowUserToDeleteRows = false;
            this.UserDatagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserDatagrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserDatagrid.Enabled = false;
            this.UserDatagrid.GridColor = System.Drawing.SystemColors.Highlight;
            this.UserDatagrid.Location = new System.Drawing.Point(303, 1);
            this.UserDatagrid.MultiSelect = false;
            this.UserDatagrid.Name = "UserDatagrid";
            this.UserDatagrid.ReadOnly = true;
            this.UserDatagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserDatagrid.RowHeadersVisible = false;
            this.UserDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UserDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDatagrid.ShowCellErrors = false;
            this.UserDatagrid.ShowCellToolTips = false;
            this.UserDatagrid.ShowRowErrors = false;
            this.UserDatagrid.Size = new System.Drawing.Size(663, 559);
            this.UserDatagrid.TabIndex = 5;
            this.UserDatagrid.VirtualMode = true;
            this.UserDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDatagrid_CellContentClick);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.UserDatagrid);
            this.Controls.Add(this.UserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Upassword;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox Uid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EDITuser;
        private System.Windows.Forms.Button ADDuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label honesty;
        private System.Windows.Forms.Button BACKuser;
        private System.Windows.Forms.Button DELETEuser;
        private System.Windows.Forms.DataGridView UserDatagrid;
    }
}