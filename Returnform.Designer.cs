
namespace d2_rentals
{
    partial class Returnform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Returnform));
            this.UserPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.returndatecldr = new System.Windows.Forms.DateTimePicker();
            this.labelFine = new System.Windows.Forms.Label();
            this.regbox = new System.Windows.Forms.ComboBox();
            this.labelreturndate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labeldelay = new System.Windows.Forms.Label();
            this.Nameleft = new System.Windows.Forms.Label();
            this.more = new System.Windows.Forms.Label();
            this.lets = new System.Windows.Forms.Label();
            this.BACKuser = new System.Windows.Forms.Button();
            this.DELETEuser = new System.Windows.Forms.Button();
            this.EDITuser = new System.Windows.Forms.Button();
            this.ADDuser = new System.Windows.Forms.Button();
            this.Uid = new System.Windows.Forms.TextBox();
            this.Regleft = new System.Windows.Forms.Label();
            this.rentleft = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cartoppanel = new System.Windows.Forms.Panel();
            this.Rent = new System.Windows.Forms.Label();
            this.rentdate = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelreg = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.Rentlabel = new System.Windows.Forms.Label();
            this.upergrid = new System.Windows.Forms.DataGridView();
            this.onrent = new System.Windows.Forms.Label();
            this.carsreturned = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelfineupper = new System.Windows.Forms.Label();
            this.labeldelayupper = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelreturnid = new System.Windows.Forms.Label();
            this.lowergrid = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cartoppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upergrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPanel.Controls.Add(this.textBox3);
            this.UserPanel.Controls.Add(this.textBox2);
            this.UserPanel.Controls.Add(this.returndatecldr);
            this.UserPanel.Controls.Add(this.labelFine);
            this.UserPanel.Controls.Add(this.regbox);
            this.UserPanel.Controls.Add(this.labelreturndate);
            this.UserPanel.Controls.Add(this.textBox1);
            this.UserPanel.Controls.Add(this.labeldelay);
            this.UserPanel.Controls.Add(this.Nameleft);
            this.UserPanel.Controls.Add(this.more);
            this.UserPanel.Controls.Add(this.lets);
            this.UserPanel.Controls.Add(this.BACKuser);
            this.UserPanel.Controls.Add(this.DELETEuser);
            this.UserPanel.Controls.Add(this.EDITuser);
            this.UserPanel.Controls.Add(this.ADDuser);
            this.UserPanel.Controls.Add(this.Uid);
            this.UserPanel.Controls.Add(this.Regleft);
            this.UserPanel.Controls.Add(this.rentleft);
            this.UserPanel.Controls.Add(this.pictureBox1);
            this.UserPanel.Location = new System.Drawing.Point(-4, -2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(309, 563);
            this.UserPanel.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 13;
            // 
            // returndatecldr
            // 
            this.returndatecldr.Location = new System.Drawing.Point(144, 278);
            this.returndatecldr.Name = "returndatecldr";
            this.returndatecldr.Size = new System.Drawing.Size(157, 20);
            this.returndatecldr.TabIndex = 12;
            this.returndatecldr.ValueChanged += new System.EventHandler(this.returndatecldr_ValueChanged);
            // 
            // labelFine
            // 
            this.labelFine.AutoSize = true;
            this.labelFine.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFine.Location = new System.Drawing.Point(20, 356);
            this.labelFine.Name = "labelFine";
            this.labelFine.Size = new System.Drawing.Size(48, 24);
            this.labelFine.TabIndex = 8;
            this.labelFine.Text = "Fine";
            // 
            // regbox
            // 
            this.regbox.FormattingEnabled = true;
            this.regbox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.regbox.Location = new System.Drawing.Point(117, 191);
            this.regbox.Name = "regbox";
            this.regbox.Size = new System.Drawing.Size(166, 21);
            this.regbox.TabIndex = 9;
            // 
            // labelreturndate
            // 
            this.labelreturndate.AutoSize = true;
            this.labelreturndate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelreturndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreturndate.Location = new System.Drawing.Point(20, 274);
            this.labelreturndate.Name = "labelreturndate";
            this.labelreturndate.Size = new System.Drawing.Size(109, 24);
            this.labelreturndate.TabIndex = 7;
            this.labelreturndate.Text = "Return Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 11;
            // 
            // labeldelay
            // 
            this.labeldelay.AutoSize = true;
            this.labeldelay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labeldelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldelay.Location = new System.Drawing.Point(20, 316);
            this.labeldelay.Name = "labeldelay";
            this.labeldelay.Size = new System.Drawing.Size(57, 24);
            this.labeldelay.TabIndex = 6;
            this.labeldelay.Text = "Delay";
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
            // 
            // DELETEuser
            // 
            this.DELETEuser.BackColor = System.Drawing.SystemColors.Info;
            this.DELETEuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEuser.Location = new System.Drawing.Point(216, 448);
            this.DELETEuser.Name = "DELETEuser";
            this.DELETEuser.Size = new System.Drawing.Size(67, 24);
            this.DELETEuser.TabIndex = 7;
            this.DELETEuser.Text = "DELETE";
            this.DELETEuser.UseVisualStyleBackColor = false;
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
            // 
            // Uid
            // 
            this.Uid.Location = new System.Drawing.Point(117, 151);
            this.Uid.Name = "Uid";
            this.Uid.Size = new System.Drawing.Size(166, 20);
            this.Uid.TabIndex = 1;
            // 
            // Regleft
            // 
            this.Regleft.AutoSize = true;
            this.Regleft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Regleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regleft.Location = new System.Drawing.Point(16, 188);
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
            this.rentleft.Location = new System.Drawing.Point(16, 147);
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
            // Cartoppanel
            // 
            this.Cartoppanel.BackColor = System.Drawing.SystemColors.Info;
            this.Cartoppanel.Controls.Add(this.Rent);
            this.Cartoppanel.Controls.Add(this.rentdate);
            this.Cartoppanel.Controls.Add(this.labelReturn);
            this.Cartoppanel.Controls.Add(this.labelreg);
            this.Cartoppanel.Controls.Add(this.namelabel);
            this.Cartoppanel.Controls.Add(this.Rentlabel);
            this.Cartoppanel.Location = new System.Drawing.Point(303, 25);
            this.Cartoppanel.Name = "Cartoppanel";
            this.Cartoppanel.Size = new System.Drawing.Size(663, 47);
            this.Cartoppanel.TabIndex = 5;
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.BackColor = System.Drawing.SystemColors.Info;
            this.Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.ForeColor = System.Drawing.Color.Salmon;
            this.Rent.Location = new System.Drawing.Point(599, 11);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(49, 24);
            this.Rent.TabIndex = 8;
            this.Rent.Text = "Rent";
            // 
            // rentdate
            // 
            this.rentdate.AutoSize = true;
            this.rentdate.BackColor = System.Drawing.SystemColors.Info;
            this.rentdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentdate.ForeColor = System.Drawing.Color.Salmon;
            this.rentdate.Location = new System.Drawing.Point(342, 11);
            this.rentdate.Name = "rentdate";
            this.rentdate.Size = new System.Drawing.Size(87, 24);
            this.rentdate.TabIndex = 6;
            this.rentdate.Text = "RentDate";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.BackColor = System.Drawing.SystemColors.Info;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.ForeColor = System.Drawing.Color.Salmon;
            this.labelReturn.Location = new System.Drawing.Point(464, 11);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(104, 24);
            this.labelReturn.TabIndex = 7;
            this.labelReturn.Text = "ReturnDate";
            // 
            // labelreg
            // 
            this.labelreg.AutoSize = true;
            this.labelreg.BackColor = System.Drawing.SystemColors.Info;
            this.labelreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreg.ForeColor = System.Drawing.Color.Salmon;
            this.labelreg.Location = new System.Drawing.Point(110, 11);
            this.labelreg.Name = "labelreg";
            this.labelreg.Size = new System.Drawing.Size(70, 24);
            this.labelreg.TabIndex = 5;
            this.labelreg.Text = "RegNo";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.SystemColors.Info;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.Salmon;
            this.namelabel.Location = new System.Drawing.Point(215, 11);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(98, 24);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "CustName";
            // 
            // Rentlabel
            // 
            this.Rentlabel.AutoSize = true;
            this.Rentlabel.BackColor = System.Drawing.SystemColors.Info;
            this.Rentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentlabel.ForeColor = System.Drawing.Color.Salmon;
            this.Rentlabel.Location = new System.Drawing.Point(8, 11);
            this.Rentlabel.Name = "Rentlabel";
            this.Rentlabel.Size = new System.Drawing.Size(71, 24);
            this.Rentlabel.TabIndex = 2;
            this.Rentlabel.Text = "Rent ID";
            // 
            // upergrid
            // 
            this.upergrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upergrid.Location = new System.Drawing.Point(303, 65);
            this.upergrid.Name = "upergrid";
            this.upergrid.Size = new System.Drawing.Size(663, 208);
            this.upergrid.TabIndex = 6;
            // 
            // onrent
            // 
            this.onrent.AutoSize = true;
            this.onrent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.onrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onrent.Location = new System.Drawing.Point(552, -2);
            this.onrent.Name = "onrent";
            this.onrent.Size = new System.Drawing.Size(152, 24);
            this.onrent.TabIndex = 7;
            this.onrent.Text = "CARS ON RENT";
            this.onrent.Click += new System.EventHandler(this.onrent_Click);
            // 
            // carsreturned
            // 
            this.carsreturned.AutoSize = true;
            this.carsreturned.BackColor = System.Drawing.SystemColors.HighlightText;
            this.carsreturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsreturned.Location = new System.Drawing.Point(552, 287);
            this.carsreturned.Name = "carsreturned";
            this.carsreturned.Size = new System.Drawing.Size(170, 24);
            this.carsreturned.TabIndex = 8;
            this.carsreturned.Text = "CARS RETURNED";
            this.carsreturned.Click += new System.EventHandler(this.carsreturned_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelfineupper);
            this.panel1.Controls.Add(this.labeldelayupper);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelreturnid);
            this.panel1.Location = new System.Drawing.Point(303, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 47);
            this.panel1.TabIndex = 9;
            // 
            // labelfineupper
            // 
            this.labelfineupper.AutoSize = true;
            this.labelfineupper.BackColor = System.Drawing.SystemColors.Info;
            this.labelfineupper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfineupper.ForeColor = System.Drawing.Color.Salmon;
            this.labelfineupper.Location = new System.Drawing.Point(599, 11);
            this.labelfineupper.Name = "labelfineupper";
            this.labelfineupper.Size = new System.Drawing.Size(48, 24);
            this.labelfineupper.TabIndex = 8;
            this.labelfineupper.Text = "Fine";
            // 
            // labeldelayupper
            // 
            this.labeldelayupper.AutoSize = true;
            this.labeldelayupper.BackColor = System.Drawing.SystemColors.Info;
            this.labeldelayupper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldelayupper.ForeColor = System.Drawing.Color.Salmon;
            this.labeldelayupper.Location = new System.Drawing.Point(372, 11);
            this.labeldelayupper.Name = "labeldelayupper";
            this.labeldelayupper.Size = new System.Drawing.Size(57, 24);
            this.labeldelayupper.TabIndex = 6;
            this.labeldelayupper.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(464, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ReturnDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(128, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "RegNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(232, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "CustName";
            // 
            // labelreturnid
            // 
            this.labelreturnid.AutoSize = true;
            this.labelreturnid.BackColor = System.Drawing.SystemColors.Info;
            this.labelreturnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreturnid.ForeColor = System.Drawing.Color.Salmon;
            this.labelreturnid.Location = new System.Drawing.Point(8, 11);
            this.labelreturnid.Name = "labelreturnid";
            this.labelreturnid.Size = new System.Drawing.Size(88, 24);
            this.labelreturnid.TabIndex = 2;
            this.labelreturnid.Text = "Return ID";
            // 
            // lowergrid
            // 
            this.lowergrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lowergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowergrid.Location = new System.Drawing.Point(303, 358);
            this.lowergrid.Name = "lowergrid";
            this.lowergrid.Size = new System.Drawing.Size(663, 200);
            this.lowergrid.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 15;
            // 
            // Returnform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lowergrid);
            this.Controls.Add(this.carsreturned);
            this.Controls.Add(this.onrent);
            this.Controls.Add(this.upergrid);
            this.Controls.Add(this.Cartoppanel);
            this.Controls.Add(this.UserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Returnform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cartoppanel.ResumeLayout(false);
            this.Cartoppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upergrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker returndatecldr;
        private System.Windows.Forms.Label labelFine;
        private System.Windows.Forms.ComboBox regbox;
        private System.Windows.Forms.Label labelreturndate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labeldelay;
        private System.Windows.Forms.Label Nameleft;
        private System.Windows.Forms.Label more;
        private System.Windows.Forms.Label lets;
        private System.Windows.Forms.Button BACKuser;
        private System.Windows.Forms.Button DELETEuser;
        private System.Windows.Forms.Button EDITuser;
        private System.Windows.Forms.Button ADDuser;
        private System.Windows.Forms.TextBox Uid;
        private System.Windows.Forms.Label Regleft;
        private System.Windows.Forms.Label rentleft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Cartoppanel;
        private System.Windows.Forms.Label Rent;
        private System.Windows.Forms.Label rentdate;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelreg;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label Rentlabel;
        private System.Windows.Forms.DataGridView upergrid;
        private System.Windows.Forms.Label onrent;
        private System.Windows.Forms.Label carsreturned;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelfineupper;
        private System.Windows.Forms.Label labeldelayupper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelreturnid;
        private System.Windows.Forms.DataGridView lowergrid;
        private System.Windows.Forms.TextBox textBox3;
    }
}