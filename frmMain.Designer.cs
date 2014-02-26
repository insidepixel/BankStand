namespace BankStand
{
    partial class frmMain
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnHSLookup = new System.Windows.Forms.Button();
            this.tbHSName = new System.Windows.Forms.TextBox();
            this.dgvHighScores = new System.Windows.Forms.DataGridView();
            this.cSkills = new System.Windows.Forms.DataGridViewImageColumn();
            this.cRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSkillLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalXP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMainTools = new System.Windows.Forms.TabControl();
            this.tabPageHS = new System.Windows.Forms.TabPage();
            this.lblHSInfo = new System.Windows.Forms.Label();
            this.tabPageGE = new System.Windows.Forms.TabPage();
            this.lbl180Change = new System.Windows.Forms.Label();
            this.lbl90Change = new System.Windows.Forms.Label();
            this.lbl30Change = new System.Windows.Forms.Label();
            this.lblTodayChange = new System.Windows.Forms.Label();
            this.lblGEInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCurPrice = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.tabPageSlayer = new System.Windows.Forms.TabPage();
            this.lblSlayMon = new System.Windows.Forms.Label();
            this.lbSlayerResults = new System.Windows.Forms.ListBox();
            this.cbSlayerMaster = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillCalculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScores)).BeginInit();
            this.tcMainTools.SuspendLayout();
            this.tabPageHS.SuspendLayout();
            this.tabPageGE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.tabPageSlayer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(801, 602);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.runescape.com/game", System.UriKind.Absolute);
            // 
            // btnHSLookup
            // 
            this.btnHSLookup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHSLookup.Location = new System.Drawing.Point(136, 70);
            this.btnHSLookup.Name = "btnHSLookup";
            this.btnHSLookup.Size = new System.Drawing.Size(120, 26);
            this.btnHSLookup.TabIndex = 1;
            this.btnHSLookup.Text = "Highscore Lookup";
            this.btnHSLookup.UseVisualStyleBackColor = true;
            this.btnHSLookup.Click += new System.EventHandler(this.btnHSLookup_Click);
            // 
            // tbHSName
            // 
            this.tbHSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHSName.Location = new System.Drawing.Point(6, 69);
            this.tbHSName.MaxLength = 12;
            this.tbHSName.Name = "tbHSName";
            this.tbHSName.Size = new System.Drawing.Size(120, 26);
            this.tbHSName.TabIndex = 2;
            // 
            // dgvHighScores
            // 
            this.dgvHighScores.AllowUserToAddRows = false;
            this.dgvHighScores.AllowUserToDeleteRows = false;
            this.dgvHighScores.AllowUserToResizeColumns = false;
            this.dgvHighScores.AllowUserToResizeRows = false;
            this.dgvHighScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvHighScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSkills,
            this.cRank,
            this.cSkillLevel,
            this.cTotalXP});
            this.dgvHighScores.Location = new System.Drawing.Point(3, 105);
            this.dgvHighScores.MultiSelect = false;
            this.dgvHighScores.Name = "dgvHighScores";
            this.dgvHighScores.ReadOnly = true;
            this.dgvHighScores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHighScores.RowHeadersVisible = false;
            this.dgvHighScores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHighScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHighScores.ShowEditingIcon = false;
            this.dgvHighScores.Size = new System.Drawing.Size(250, 405);
            this.dgvHighScores.TabIndex = 3;
            this.dgvHighScores.TabStop = false;
            this.dgvHighScores.SelectionChanged += new System.EventHandler(this.dataGridview1_SelectionChanged);
            // 
            // cSkills
            // 
            this.cSkills.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cSkills.Frozen = true;
            this.cSkills.HeaderText = "Skills";
            this.cSkills.Name = "cSkills";
            this.cSkills.ReadOnly = true;
            this.cSkills.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSkills.Width = 37;
            // 
            // cRank
            // 
            this.cRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cRank.HeaderText = "Rank";
            this.cRank.Name = "cRank";
            this.cRank.ReadOnly = true;
            this.cRank.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRank.Width = 39;
            // 
            // cSkillLevel
            // 
            this.cSkillLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cSkillLevel.HeaderText = "Skill Level";
            this.cSkillLevel.Name = "cSkillLevel";
            this.cSkillLevel.ReadOnly = true;
            this.cSkillLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSkillLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSkillLevel.Width = 61;
            // 
            // cTotalXP
            // 
            this.cTotalXP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTotalXP.HeaderText = "Total XP";
            this.cTotalXP.Name = "cTotalXP";
            this.cTotalXP.ReadOnly = true;
            this.cTotalXP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cTotalXP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tcMainTools
            // 
            this.tcMainTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainTools.Controls.Add(this.tabPageHS);
            this.tcMainTools.Controls.Add(this.tabPageGE);
            this.tcMainTools.Controls.Add(this.tabPageSlayer);
            this.tcMainTools.Location = new System.Drawing.Point(812, 87);
            this.tcMainTools.Name = "tcMainTools";
            this.tcMainTools.SelectedIndex = 0;
            this.tcMainTools.Size = new System.Drawing.Size(332, 539);
            this.tcMainTools.TabIndex = 4;
            // 
            // tabPageHS
            // 
            this.tabPageHS.Controls.Add(this.lblHSInfo);
            this.tabPageHS.Controls.Add(this.dgvHighScores);
            this.tabPageHS.Controls.Add(this.tbHSName);
            this.tabPageHS.Controls.Add(this.btnHSLookup);
            this.tabPageHS.Location = new System.Drawing.Point(4, 22);
            this.tabPageHS.Name = "tabPageHS";
            this.tabPageHS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHS.Size = new System.Drawing.Size(324, 513);
            this.tabPageHS.TabIndex = 0;
            this.tabPageHS.Text = "Highscore Lookup";
            this.tabPageHS.UseVisualStyleBackColor = true;
            // 
            // lblHSInfo
            // 
            this.lblHSInfo.AutoSize = true;
            this.lblHSInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSInfo.Location = new System.Drawing.Point(33, 3);
            this.lblHSInfo.Name = "lblHSInfo";
            this.lblHSInfo.Size = new System.Drawing.Size(265, 60);
            this.lblHSInfo.TabIndex = 4;
            this.lblHSInfo.Text = "Type a user\'s display name in to \r\nthe textbox and press the highscore \r\nlookup b" +
    "utton.";
            this.lblHSInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageGE
            // 
            this.tabPageGE.Controls.Add(this.lbl180Change);
            this.tabPageGE.Controls.Add(this.lbl90Change);
            this.tabPageGE.Controls.Add(this.lbl30Change);
            this.tabPageGE.Controls.Add(this.lblTodayChange);
            this.tabPageGE.Controls.Add(this.lblGEInfo);
            this.tabPageGE.Controls.Add(this.label2);
            this.tabPageGE.Controls.Add(this.lblName);
            this.tabPageGE.Controls.Add(this.lblCurPrice);
            this.tabPageGE.Controls.Add(this.lblMembers);
            this.tabPageGE.Controls.Add(this.pbItem);
            this.tabPageGE.Controls.Add(this.tbSearch);
            this.tabPageGE.Controls.Add(this.lbResults);
            this.tabPageGE.Location = new System.Drawing.Point(4, 22);
            this.tabPageGE.Name = "tabPageGE";
            this.tabPageGE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGE.Size = new System.Drawing.Size(324, 513);
            this.tabPageGE.TabIndex = 1;
            this.tabPageGE.Text = "GE Lookup";
            this.tabPageGE.UseVisualStyleBackColor = true;
            // 
            // lbl180Change
            // 
            this.lbl180Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl180Change.AutoSize = true;
            this.lbl180Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl180Change.Location = new System.Drawing.Point(197, 494);
            this.lbl180Change.Name = "lbl180Change";
            this.lbl180Change.Size = new System.Drawing.Size(46, 16);
            this.lbl180Change.TabIndex = 11;
            this.lbl180Change.Text = "Prices";
            this.lbl180Change.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl90Change
            // 
            this.lbl90Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl90Change.AutoSize = true;
            this.lbl90Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl90Change.Location = new System.Drawing.Point(197, 478);
            this.lbl90Change.Name = "lbl90Change";
            this.lbl90Change.Size = new System.Drawing.Size(46, 16);
            this.lbl90Change.TabIndex = 10;
            this.lbl90Change.Text = "Prices";
            this.lbl90Change.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl30Change
            // 
            this.lbl30Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl30Change.AutoSize = true;
            this.lbl30Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl30Change.Location = new System.Drawing.Point(197, 462);
            this.lbl30Change.Name = "lbl30Change";
            this.lbl30Change.Size = new System.Drawing.Size(46, 16);
            this.lbl30Change.TabIndex = 9;
            this.lbl30Change.Text = "Prices";
            this.lbl30Change.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTodayChange
            // 
            this.lblTodayChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayChange.AutoSize = true;
            this.lblTodayChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayChange.Location = new System.Drawing.Point(197, 446);
            this.lblTodayChange.Name = "lblTodayChange";
            this.lblTodayChange.Size = new System.Drawing.Size(46, 16);
            this.lblTodayChange.TabIndex = 8;
            this.lblTodayChange.Text = "Prices";
            this.lblTodayChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGEInfo
            // 
            this.lblGEInfo.AutoSize = true;
            this.lblGEInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGEInfo.Location = new System.Drawing.Point(23, 3);
            this.lblGEInfo.Name = "lblGEInfo";
            this.lblGEInfo.Size = new System.Drawing.Size(280, 60);
            this.lblGEInfo.TabIndex = 7;
            this.lblGEInfo.Text = "Type the name of the item in the text \r\nbox and press enter. Left click the item\r" +
    "\nyou wish to look up in the results box.";
            this.lblGEInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 64);
            this.label2.TabIndex = 6;
            this.label2.Text = "Today\'s Change:\r\n30 Day Change:\r\n90 Day Change:\r\n180 Day Change:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 284);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(312, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Item Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurPrice
            // 
            this.lblCurPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurPrice.Location = new System.Drawing.Point(6, 426);
            this.lblCurPrice.Name = "lblCurPrice";
            this.lblCurPrice.Size = new System.Drawing.Size(313, 20);
            this.lblCurPrice.TabIndex = 4;
            this.lblCurPrice.Text = "Price";
            this.lblCurPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMembers
            // 
            this.lblMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.Location = new System.Drawing.Point(6, 406);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(313, 20);
            this.lblMembers.TabIndex = 3;
            this.lblMembers.Text = "Is members?";
            this.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbItem
            // 
            this.pbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbItem.Location = new System.Drawing.Point(115, 307);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(96, 96);
            this.pbItem.TabIndex = 2;
            this.pbItem.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(6, 66);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(313, 26);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 20;
            this.lbResults.Location = new System.Drawing.Point(6, 98);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(313, 184);
            this.lbResults.TabIndex = 0;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // tabPageSlayer
            // 
            this.tabPageSlayer.Controls.Add(this.lblSlayMon);
            this.tabPageSlayer.Controls.Add(this.lbSlayerResults);
            this.tabPageSlayer.Controls.Add(this.cbSlayerMaster);
            this.tabPageSlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSlayer.Name = "tabPageSlayer";
            this.tabPageSlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSlayer.Size = new System.Drawing.Size(324, 513);
            this.tabPageSlayer.TabIndex = 2;
            this.tabPageSlayer.Text = "Slayer Lookup";
            this.tabPageSlayer.UseVisualStyleBackColor = true;
            // 
            // lblSlayMon
            // 
            this.lblSlayMon.AutoSize = true;
            this.lblSlayMon.Location = new System.Drawing.Point(6, 152);
            this.lblSlayMon.Name = "lblSlayMon";
            this.lblSlayMon.Size = new System.Drawing.Size(0, 13);
            this.lblSlayMon.TabIndex = 2;
            // 
            // lbSlayerResults
            // 
            this.lbSlayerResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlayerResults.FormattingEnabled = true;
            this.lbSlayerResults.ItemHeight = 16;
            this.lbSlayerResults.Location = new System.Drawing.Point(6, 33);
            this.lbSlayerResults.Name = "lbSlayerResults";
            this.lbSlayerResults.Size = new System.Drawing.Size(310, 116);
            this.lbSlayerResults.TabIndex = 1;
            this.lbSlayerResults.SelectedIndexChanged += new System.EventHandler(this.lbSlayerResults_SelectedIndexChanged);
            // 
            // cbSlayerMaster
            // 
            this.cbSlayerMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlayerMaster.FormattingEnabled = true;
            this.cbSlayerMaster.Items.AddRange(new object[] {
            "Turael",
            "Mazchna",
            "Vannaka",
            "Chaeldar",
            "Sumona",
            "Duradel",
            "Kuradal"});
            this.cbSlayerMaster.Location = new System.Drawing.Point(71, 6);
            this.cbSlayerMaster.Name = "cbSlayerMaster";
            this.cbSlayerMaster.Size = new System.Drawing.Size(184, 21);
            this.cbSlayerMaster.TabIndex = 0;
            this.cbSlayerMaster.SelectedIndexChanged += new System.EventHandler(this.cbSlayerMaster_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.skillCalculatorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // skillCalculatorsToolStripMenuItem
            // 
            this.skillCalculatorsToolStripMenuItem.Name = "skillCalculatorsToolStripMenuItem";
            this.skillCalculatorsToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.skillCalculatorsToolStripMenuItem.Text = "Skill Calculators";
            this.skillCalculatorsToolStripMenuItem.Click += new System.EventHandler(this.skillCalculatorsToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(812, 27);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(87, 35);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play RS3";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 626);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.tcMainTools);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1160, 664);
            this.Name = "frmMain";
            this.Text = "BankStand Beta v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScores)).EndInit();
            this.tcMainTools.ResumeLayout(false);
            this.tabPageHS.ResumeLayout(false);
            this.tabPageHS.PerformLayout();
            this.tabPageGE.ResumeLayout(false);
            this.tabPageGE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.tabPageSlayer.ResumeLayout(false);
            this.tabPageSlayer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHSLookup;
        private System.Windows.Forms.TextBox tbHSName;
        private System.Windows.Forms.DataGridView dgvHighScores;
        private System.Windows.Forms.DataGridViewImageColumn cSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSkillLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalXP;
        private System.Windows.Forms.TabControl tcMainTools;
        private System.Windows.Forms.TabPage tabPageHS;
        private System.Windows.Forms.TabPage tabPageGE;
        private System.Windows.Forms.Label lblHSInfo;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblCurPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGEInfo;
        private System.Windows.Forms.Label lbl180Change;
        private System.Windows.Forms.Label lbl90Change;
        private System.Windows.Forms.Label lbl30Change;
        private System.Windows.Forms.Label lblTodayChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillCalculatorsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageSlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cbSlayerMaster;
        private System.Windows.Forms.ListBox lbSlayerResults;
        private System.Windows.Forms.Label lblSlayMon;
    }
}

