namespace TakDBReader
{
    partial class TakDBReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakDBReaderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfilelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numgameslabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.whitewinslabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blackwinslabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flatwinslabel = new System.Windows.Forms.Label();
            this.roadwinslabel = new System.Windows.Forms.Label();
            this.drawslabel = new System.Windows.Forms.Label();
            this.resignationlabel = new System.Windows.Forms.Label();
            this.resignwinspercent = new System.Windows.Forms.Label();
            this.flatwinspercent = new System.Windows.Forms.Label();
            this.roadwinspercent = new System.Windows.Forms.Label();
            this.drawwinspercent = new System.Windows.Forms.Label();
            this.blackwinspercent = new System.Windows.Forms.Label();
            this.whitewinspercent = new System.Windows.Forms.Label();
            this.gamespercent = new System.Windows.Forms.Label();
            this.selectedgamespercent = new System.Windows.Forms.Label();
            this.selectedgameslabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openings = new System.Windows.Forms.ListBox();
            this.minmovesinput = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fpa = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sizes = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.whiteplayerhb = new System.Windows.Forms.ListBox();
            this.blackplayerhb = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.datefromtext = new System.Windows.Forms.Label();
            this.datetotext = new System.Windows.Forms.Label();
            this.restrictdates = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minmovesinput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem1.Text = "Open...";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // openfilelabel
            // 
            this.openfilelabel.AutoEllipsis = true;
            this.openfilelabel.Location = new System.Drawing.Point(16, 262);
            this.openfilelabel.Name = "openfilelabel";
            this.openfilelabel.Size = new System.Drawing.Size(409, 26);
            this.openfilelabel.TabIndex = 1;
            this.openfilelabel.Text = "(none)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected:";
            // 
            // numgameslabel
            // 
            this.numgameslabel.Location = new System.Drawing.Point(87, 36);
            this.numgameslabel.Name = "numgameslabel";
            this.numgameslabel.Size = new System.Drawing.Size(60, 13);
            this.numgameslabel.TabIndex = 4;
            this.numgameslabel.Text = "0";
            this.numgameslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Enabled = false;
            this.RefreshButton.Location = new System.Drawing.Point(431, 265);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "White Wins:";
            // 
            // whitewinslabel
            // 
            this.whitewinslabel.Location = new System.Drawing.Point(87, 70);
            this.whitewinslabel.Name = "whitewinslabel";
            this.whitewinslabel.Size = new System.Drawing.Size(60, 13);
            this.whitewinslabel.TabIndex = 7;
            this.whitewinslabel.Text = "0";
            this.whitewinslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Black Wins:";
            // 
            // blackwinslabel
            // 
            this.blackwinslabel.Location = new System.Drawing.Point(87, 83);
            this.blackwinslabel.Name = "blackwinslabel";
            this.blackwinslabel.Size = new System.Drawing.Size(60, 13);
            this.blackwinslabel.TabIndex = 9;
            this.blackwinslabel.Text = "0";
            this.blackwinslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Draws:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Road Wins:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Flat Wins:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Resignation:";
            // 
            // flatwinslabel
            // 
            this.flatwinslabel.Location = new System.Drawing.Point(87, 122);
            this.flatwinslabel.Name = "flatwinslabel";
            this.flatwinslabel.Size = new System.Drawing.Size(60, 13);
            this.flatwinslabel.TabIndex = 16;
            this.flatwinslabel.Text = "0";
            this.flatwinslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roadwinslabel
            // 
            this.roadwinslabel.Location = new System.Drawing.Point(87, 109);
            this.roadwinslabel.Name = "roadwinslabel";
            this.roadwinslabel.Size = new System.Drawing.Size(60, 13);
            this.roadwinslabel.TabIndex = 15;
            this.roadwinslabel.Text = "0";
            this.roadwinslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawslabel
            // 
            this.drawslabel.Location = new System.Drawing.Point(87, 96);
            this.drawslabel.Name = "drawslabel";
            this.drawslabel.Size = new System.Drawing.Size(60, 13);
            this.drawslabel.TabIndex = 14;
            this.drawslabel.Text = "0";
            this.drawslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resignationlabel
            // 
            this.resignationlabel.Location = new System.Drawing.Point(87, 135);
            this.resignationlabel.Name = "resignationlabel";
            this.resignationlabel.Size = new System.Drawing.Size(60, 13);
            this.resignationlabel.TabIndex = 17;
            this.resignationlabel.Text = "0";
            this.resignationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resignwinspercent
            // 
            this.resignwinspercent.Location = new System.Drawing.Point(148, 135);
            this.resignwinspercent.Name = "resignwinspercent";
            this.resignwinspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resignwinspercent.Size = new System.Drawing.Size(60, 13);
            this.resignwinspercent.TabIndex = 24;
            this.resignwinspercent.Text = "0%";
            this.resignwinspercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flatwinspercent
            // 
            this.flatwinspercent.Location = new System.Drawing.Point(148, 122);
            this.flatwinspercent.Name = "flatwinspercent";
            this.flatwinspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flatwinspercent.Size = new System.Drawing.Size(60, 13);
            this.flatwinspercent.TabIndex = 23;
            this.flatwinspercent.Text = "0%";
            this.flatwinspercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roadwinspercent
            // 
            this.roadwinspercent.Location = new System.Drawing.Point(148, 109);
            this.roadwinspercent.Name = "roadwinspercent";
            this.roadwinspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roadwinspercent.Size = new System.Drawing.Size(60, 13);
            this.roadwinspercent.TabIndex = 22;
            this.roadwinspercent.Text = "0%";
            this.roadwinspercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawwinspercent
            // 
            this.drawwinspercent.Location = new System.Drawing.Point(148, 96);
            this.drawwinspercent.Name = "drawwinspercent";
            this.drawwinspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drawwinspercent.Size = new System.Drawing.Size(60, 13);
            this.drawwinspercent.TabIndex = 21;
            this.drawwinspercent.Text = "0%";
            this.drawwinspercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blackwinspercent
            // 
            this.blackwinspercent.Location = new System.Drawing.Point(148, 83);
            this.blackwinspercent.Name = "blackwinspercent";
            this.blackwinspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blackwinspercent.Size = new System.Drawing.Size(60, 13);
            this.blackwinspercent.TabIndex = 20;
            this.blackwinspercent.Text = "0%";
            this.blackwinspercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // whitewinspercent
            // 
            this.whitewinspercent.Location = new System.Drawing.Point(148, 70);
            this.whitewinspercent.Name = "whitewinspercent";
            this.whitewinspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.whitewinspercent.Size = new System.Drawing.Size(60, 13);
            this.whitewinspercent.TabIndex = 19;
            this.whitewinspercent.Text = "0%";
            this.whitewinspercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gamespercent
            // 
            this.gamespercent.Location = new System.Drawing.Point(148, 36);
            this.gamespercent.Name = "gamespercent";
            this.gamespercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gamespercent.Size = new System.Drawing.Size(60, 13);
            this.gamespercent.TabIndex = 18;
            this.gamespercent.Text = "0%";
            this.gamespercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedgamespercent
            // 
            this.selectedgamespercent.Location = new System.Drawing.Point(148, 57);
            this.selectedgamespercent.Name = "selectedgamespercent";
            this.selectedgamespercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedgamespercent.Size = new System.Drawing.Size(60, 13);
            this.selectedgamespercent.TabIndex = 35;
            this.selectedgamespercent.Text = "0%";
            this.selectedgamespercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectedgameslabel
            // 
            this.selectedgameslabel.Location = new System.Drawing.Point(87, 57);
            this.selectedgameslabel.Name = "selectedgameslabel";
            this.selectedgameslabel.Size = new System.Drawing.Size(60, 13);
            this.selectedgameslabel.TabIndex = 34;
            this.selectedgameslabel.Text = "0";
            this.selectedgameslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Total Games:";
            // 
            // openings
            // 
            this.openings.FormattingEnabled = true;
            this.openings.Items.AddRange(new object[] {
            "Any Opening",
            "Both in Corner",
            "Neither in Corner",
            "Only Black in Corner",
            "Only White in Corner",
            "Adjacent Corners",
            "Opposite Corners",
            "Black in Center",
            "... and White Corner",
            "White in Center",
            "... and Black Corner"});
            this.openings.Location = new System.Drawing.Point(317, 57);
            this.openings.Name = "openings";
            this.openings.Size = new System.Drawing.Size(120, 147);
            this.openings.TabIndex = 36;
            // 
            // minmovesinput
            // 
            this.minmovesinput.Location = new System.Drawing.Point(236, 184);
            this.minmovesinput.Name = "minmovesinput";
            this.minmovesinput.Size = new System.Drawing.Size(52, 20);
            this.minmovesinput.TabIndex = 37;
            this.minmovesinput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(233, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 26);
            this.label9.TabIndex = 38;
            this.label9.Text = "Minimum Moves:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "First Player Advantage:";
            // 
            // fpa
            // 
            this.fpa.Location = new System.Drawing.Point(149, 157);
            this.fpa.Name = "fpa";
            this.fpa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpa.Size = new System.Drawing.Size(60, 13);
            this.fpa.TabIndex = 40;
            this.fpa.Text = "0%";
            this.fpa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Board Sizes:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Opening Moves:";
            // 
            // sizes
            // 
            this.sizes.FormattingEnabled = true;
            this.sizes.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5",
            "6x6",
            "7x7",
            "8x8"});
            this.sizes.Location = new System.Drawing.Point(236, 57);
            this.sizes.Margin = new System.Windows.Forms.Padding(5);
            this.sizes.Name = "sizes";
            this.sizes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sizes.Size = new System.Drawing.Size(52, 82);
            this.sizes.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(451, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "White Player:";
            // 
            // whiteplayerhb
            // 
            this.whiteplayerhb.FormattingEnabled = true;
            this.whiteplayerhb.Items.AddRange(new object[] {
            "Human",
            "Bot",
            "Either"});
            this.whiteplayerhb.Location = new System.Drawing.Point(454, 57);
            this.whiteplayerhb.Margin = new System.Windows.Forms.Padding(5);
            this.whiteplayerhb.Name = "whiteplayerhb";
            this.whiteplayerhb.Size = new System.Drawing.Size(52, 43);
            this.whiteplayerhb.TabIndex = 51;
            // 
            // blackplayerhb
            // 
            this.blackplayerhb.FormattingEnabled = true;
            this.blackplayerhb.Items.AddRange(new object[] {
            "Human",
            "Bot",
            "Either"});
            this.blackplayerhb.Location = new System.Drawing.Point(454, 143);
            this.blackplayerhb.Margin = new System.Windows.Forms.Padding(5);
            this.blackplayerhb.Name = "blackplayerhb";
            this.blackplayerhb.Size = new System.Drawing.Size(52, 43);
            this.blackplayerhb.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(451, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Black Player:";
            // 
            // datefrom
            // 
            this.datefrom.Enabled = false;
            this.datefrom.Location = new System.Drawing.Point(62, 217);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(200, 20);
            this.datefrom.TabIndex = 55;
            this.datefrom.Value = new System.DateTime(2016, 3, 14, 0, 0, 0, 0);
            // 
            // dateto
            // 
            this.dateto.Enabled = false;
            this.dateto.Location = new System.Drawing.Point(306, 217);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(200, 20);
            this.dateto.TabIndex = 56;
            // 
            // datefromtext
            // 
            this.datefromtext.Enabled = false;
            this.datefromtext.Location = new System.Drawing.Point(10, 217);
            this.datefromtext.Name = "datefromtext";
            this.datefromtext.Size = new System.Drawing.Size(46, 20);
            this.datefromtext.TabIndex = 57;
            this.datefromtext.Text = "From:";
            this.datefromtext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datetotext
            // 
            this.datetotext.Enabled = false;
            this.datetotext.Location = new System.Drawing.Point(268, 217);
            this.datetotext.Name = "datetotext";
            this.datetotext.Size = new System.Drawing.Size(32, 20);
            this.datetotext.TabIndex = 58;
            this.datetotext.Text = "To:";
            this.datetotext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restrictdates
            // 
            this.restrictdates.AutoSize = true;
            this.restrictdates.Location = new System.Drawing.Point(19, 194);
            this.restrictdates.Name = "restrictdates";
            this.restrictdates.Size = new System.Drawing.Size(96, 17);
            this.restrictdates.TabIndex = 59;
            this.restrictdates.Text = "Restrict Dates:";
            this.restrictdates.UseVisualStyleBackColor = true;
            this.restrictdates.CheckedChanged += new System.EventHandler(this.restrictdates_CheckedChanged);
            // 
            // TakDBReaderForm
            // 
            this.AcceptButton = this.RefreshButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 296);
            this.Controls.Add(this.restrictdates);
            this.Controls.Add(this.datetotext);
            this.Controls.Add(this.datefromtext);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.datefrom);
            this.Controls.Add(this.blackplayerhb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.whiteplayerhb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.sizes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fpa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minmovesinput);
            this.Controls.Add(this.openings);
            this.Controls.Add(this.selectedgamespercent);
            this.Controls.Add(this.selectedgameslabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resignwinspercent);
            this.Controls.Add(this.flatwinspercent);
            this.Controls.Add(this.roadwinspercent);
            this.Controls.Add(this.drawwinspercent);
            this.Controls.Add(this.blackwinspercent);
            this.Controls.Add(this.whitewinspercent);
            this.Controls.Add(this.gamespercent);
            this.Controls.Add(this.resignationlabel);
            this.Controls.Add(this.flatwinslabel);
            this.Controls.Add(this.roadwinslabel);
            this.Controls.Add(this.drawslabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.blackwinslabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.whitewinslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.numgameslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openfilelabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TakDBReaderForm";
            this.Text = "Tak DB Reader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minmovesinput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label openfilelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numgameslabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label whitewinslabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blackwinslabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label flatwinslabel;
        private System.Windows.Forms.Label roadwinslabel;
        private System.Windows.Forms.Label drawslabel;
        private System.Windows.Forms.Label resignationlabel;
        private System.Windows.Forms.Label resignwinspercent;
        private System.Windows.Forms.Label flatwinspercent;
        private System.Windows.Forms.Label roadwinspercent;
        private System.Windows.Forms.Label drawwinspercent;
        private System.Windows.Forms.Label blackwinspercent;
        private System.Windows.Forms.Label whitewinspercent;
        private System.Windows.Forms.Label gamespercent;
        private System.Windows.Forms.Label selectedgamespercent;
        private System.Windows.Forms.Label selectedgameslabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox openings;
        private System.Windows.Forms.NumericUpDown minmovesinput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fpa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox sizes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox whiteplayerhb;
        private System.Windows.Forms.ListBox blackplayerhb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label datefromtext;
        private System.Windows.Forms.Label datetotext;
        private System.Windows.Forms.CheckBox restrictdates;
    }
}

