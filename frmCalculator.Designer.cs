namespace BankStand
{
    partial class frmCalculator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnCalcLookup = new System.Windows.Forms.Button();
            this.cbSkills = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWantedLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReqXP = new System.Windows.Forms.Label();
            this.lblCurLvl = new System.Windows.Forms.Label();
            this.dgvCalculator = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iterations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLvlXP = new System.Windows.Forms.Label();
            this.tbCurXP = new System.Windows.Forms.TextBox();
            this.chbOnTop = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(129, 18);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // btnCalcLookup
            // 
            this.btnCalcLookup.Location = new System.Drawing.Point(235, 17);
            this.btnCalcLookup.Name = "btnCalcLookup";
            this.btnCalcLookup.Size = new System.Drawing.Size(91, 21);
            this.btnCalcLookup.TabIndex = 1;
            this.btnCalcLookup.Text = "Get XP";
            this.btnCalcLookup.UseVisualStyleBackColor = true;
            this.btnCalcLookup.Click += new System.EventHandler(this.btnCalcLookup_Click);
            // 
            // cbSkills
            // 
            this.cbSkills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Items.AddRange(new object[] {
            "Agility",
            "Construction",
            "Cooking",
            "Crafting",
            "Divination",
            "Farming",
            "Firemaking",
            "Fishing",
            "Fletching",
            "Herblore",
            "Hunter",
            "Magic",
            "Mining",
            "Prayer",
            "Runecrafting",
            "Smithing",
            "Summoning",
            "Thieving",
            "Woodcutting"});
            this.cbSkills.Location = new System.Drawing.Point(247, 12);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(91, 21);
            this.cbSkills.TabIndex = 3;
            this.cbSkills.SelectedIndexChanged += new System.EventHandler(this.cbSkills_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current XP:";
            // 
            // tbWantedLevel
            // 
            this.tbWantedLevel.Location = new System.Drawing.Point(141, 117);
            this.tbWantedLevel.MaxLength = 3;
            this.tbWantedLevel.Name = "tbWantedLevel";
            this.tbWantedLevel.Size = new System.Drawing.Size(43, 20);
            this.tbWantedLevel.TabIndex = 7;
            this.tbWantedLevel.TextChanged += new System.EventHandler(this.tbWantedLevel_TextChanged);
            this.tbWantedLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWantedLevel_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCalcLookup);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Desired Level:";
            // 
            // lblReqXP
            // 
            this.lblReqXP.AutoSize = true;
            this.lblReqXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqXP.Location = new System.Drawing.Point(25, 141);
            this.lblReqXP.Name = "lblReqXP";
            this.lblReqXP.Size = new System.Drawing.Size(103, 20);
            this.lblReqXP.TabIndex = 12;
            this.lblReqXP.Text = "Required XP:";
            // 
            // lblCurLvl
            // 
            this.lblCurLvl.AutoSize = true;
            this.lblCurLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurLvl.Location = new System.Drawing.Point(218, 93);
            this.lblCurLvl.Name = "lblCurLvl";
            this.lblCurLvl.Size = new System.Drawing.Size(0, 20);
            this.lblCurLvl.TabIndex = 13;
            // 
            // dgvCalculator
            // 
            this.dgvCalculator.AllowUserToAddRows = false;
            this.dgvCalculator.AllowUserToDeleteRows = false;
            this.dgvCalculator.AllowUserToResizeColumns = false;
            this.dgvCalculator.AllowUserToResizeRows = false;
            this.dgvCalculator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Members,
            this.Level,
            this.Experience,
            this.Iterations});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalculator.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalculator.Location = new System.Drawing.Point(12, 164);
            this.dgvCalculator.MultiSelect = false;
            this.dgvCalculator.Name = "dgvCalculator";
            this.dgvCalculator.ReadOnly = true;
            this.dgvCalculator.RowHeadersVisible = false;
            this.dgvCalculator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCalculator.Size = new System.Drawing.Size(365, 182);
            this.dgvCalculator.TabIndex = 14;
            this.dgvCalculator.TabStop = false;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Action.Frozen = true;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.Width = 62;
            // 
            // Members
            // 
            this.Members.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Members.Frozen = true;
            this.Members.HeaderText = "Members?";
            this.Members.Name = "Members";
            this.Members.ReadOnly = true;
            this.Members.Width = 81;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Level.Frozen = true;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 58;
            // 
            // Experience
            // 
            this.Experience.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Experience.Frozen = true;
            this.Experience.HeaderText = "Experience";
            this.Experience.Name = "Experience";
            this.Experience.ReadOnly = true;
            this.Experience.Width = 85;
            // 
            // Iterations
            // 
            this.Iterations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Iterations.HeaderText = "Iterations";
            this.Iterations.Name = "Iterations";
            this.Iterations.ReadOnly = true;
            this.Iterations.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Iterations.Width = 75;
            // 
            // lblLvlXP
            // 
            this.lblLvlXP.AutoSize = true;
            this.lblLvlXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvlXP.Location = new System.Drawing.Point(218, 117);
            this.lblLvlXP.Name = "lblLvlXP";
            this.lblLvlXP.Size = new System.Drawing.Size(0, 20);
            this.lblLvlXP.TabIndex = 15;
            // 
            // tbCurXP
            // 
            this.tbCurXP.Location = new System.Drawing.Point(141, 93);
            this.tbCurXP.MaxLength = 9;
            this.tbCurXP.Name = "tbCurXP";
            this.tbCurXP.Size = new System.Drawing.Size(71, 20);
            this.tbCurXP.TabIndex = 5;
            this.tbCurXP.TextChanged += new System.EventHandler(this.tbCurXP_TextChanged);
            this.tbCurXP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurXP_KeyPress);
            // 
            // chbOnTop
            // 
            this.chbOnTop.AutoSize = true;
            this.chbOnTop.Location = new System.Drawing.Point(29, 16);
            this.chbOnTop.Name = "chbOnTop";
            this.chbOnTop.Size = new System.Drawing.Size(104, 17);
            this.chbOnTop.TabIndex = 16;
            this.chbOnTop.Text = "Always On Top?";
            this.chbOnTop.UseVisualStyleBackColor = true;
            this.chbOnTop.CheckedChanged += new System.EventHandler(this.chbOnTop_CheckedChanged);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 355);
            this.Controls.Add(this.chbOnTop);
            this.Controls.Add(this.lblLvlXP);
            this.Controls.Add(this.cbSkills);
            this.Controls.Add(this.dgvCalculator);
            this.Controls.Add(this.lblCurLvl);
            this.Controls.Add(this.lblReqXP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbWantedLevel);
            this.Controls.Add(this.tbCurXP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCalculator";
            this.Text = "Skill Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnCalcLookup;
        private System.Windows.Forms.ComboBox cbSkills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWantedLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReqXP;
        private System.Windows.Forms.Label lblCurLvl;
        private System.Windows.Forms.DataGridView dgvCalculator;
        private System.Windows.Forms.Label lblLvlXP;
        private System.Windows.Forms.TextBox tbCurXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Members;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iterations;
        private System.Windows.Forms.CheckBox chbOnTop;
    }
}