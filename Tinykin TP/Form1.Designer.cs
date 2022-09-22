namespace Tinykin_TP {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lstbPositions = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbLevelSelect = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.chbFreezeZ = new System.Windows.Forms.CheckBox();
			this.chbFreezeY = new System.Windows.Forms.CheckBox();
			this.chbFreezeX = new System.Windows.Forms.CheckBox();
			this.btnCancelEdit = new System.Windows.Forms.Button();
			this.numHotkey = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.lbHudZ = new System.Windows.Forms.Label();
			this.lbHudY = new System.Windows.Forms.Label();
			this.lbHudX = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.positionReadClock = new System.Windows.Forms.Timer(this.components);
			this.connectToProcessClock = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHotkey)).BeginInit();
			this.SuspendLayout();
			// 
			// lstbPositions
			// 
			this.lstbPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstbPositions.FormattingEnabled = true;
			this.lstbPositions.ItemHeight = 15;
			this.lstbPositions.Location = new System.Drawing.Point(12, 42);
			this.lstbPositions.Name = "lstbPositions";
			this.lstbPositions.Size = new System.Drawing.Size(251, 274);
			this.lstbPositions.TabIndex = 0;
			this.lstbPositions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstbPositions_MouseDown);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.cbLevelSelect);
			this.panel1.Controls.Add(this.lstbPositions);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(266, 330);
			this.panel1.TabIndex = 1;
			// 
			// cbLevelSelect
			// 
			this.cbLevelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLevelSelect.FormattingEnabled = true;
			this.cbLevelSelect.Items.AddRange(new object[] {
            "Chrysal Workshop",
            "Transidor Crossing",
            "City of Sanctar",
            "Waters of Balnea",
            "Lands of Ambrose",
            "Celerion Park",
            "Ardwin"});
			this.cbLevelSelect.Location = new System.Drawing.Point(12, 12);
			this.cbLevelSelect.Name = "cbLevelSelect";
			this.cbLevelSelect.Size = new System.Drawing.Size(251, 23);
			this.cbLevelSelect.TabIndex = 1;
			this.cbLevelSelect.SelectedIndexChanged += new System.EventHandler(this.cbLevelSelect_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.chbFreezeZ);
			this.panel2.Controls.Add(this.chbFreezeY);
			this.panel2.Controls.Add(this.chbFreezeX);
			this.panel2.Controls.Add(this.btnCancelEdit);
			this.panel2.Controls.Add(this.numHotkey);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.lbHudZ);
			this.panel2.Controls.Add(this.lbHudY);
			this.panel2.Controls.Add(this.lbHudX);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.tbDescription);
			this.panel2.Location = new System.Drawing.Point(269, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 330);
			this.panel2.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(3, 214);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(185, 116);
			this.textBox1.TabIndex = 14;
			this.textBox1.Text = "Hotkeys:\r\nCTRL + [0-9] = Save position\r\n[0-9] = Teleport to position\r\n\r\nTip:\r\nYou" +
    " can right click and edit or delete saved positions.\r\n";
			// 
			// chbFreezeZ
			// 
			this.chbFreezeZ.AutoSize = true;
			this.chbFreezeZ.Location = new System.Drawing.Point(129, 43);
			this.chbFreezeZ.Name = "chbFreezeZ";
			this.chbFreezeZ.Size = new System.Drawing.Size(59, 19);
			this.chbFreezeZ.TabIndex = 13;
			this.chbFreezeZ.Text = "Freeze";
			this.chbFreezeZ.UseVisualStyleBackColor = true;
			this.chbFreezeZ.CheckedChanged += new System.EventHandler(this.chbFreezeZ_CheckedChanged);
			// 
			// chbFreezeY
			// 
			this.chbFreezeY.AutoSize = true;
			this.chbFreezeY.Location = new System.Drawing.Point(129, 27);
			this.chbFreezeY.Name = "chbFreezeY";
			this.chbFreezeY.Size = new System.Drawing.Size(59, 19);
			this.chbFreezeY.TabIndex = 12;
			this.chbFreezeY.Text = "Freeze";
			this.chbFreezeY.UseVisualStyleBackColor = true;
			this.chbFreezeY.CheckedChanged += new System.EventHandler(this.chbFreezeY_CheckedChanged);
			// 
			// chbFreezeX
			// 
			this.chbFreezeX.AutoSize = true;
			this.chbFreezeX.Location = new System.Drawing.Point(129, 11);
			this.chbFreezeX.Name = "chbFreezeX";
			this.chbFreezeX.Size = new System.Drawing.Size(59, 19);
			this.chbFreezeX.TabIndex = 11;
			this.chbFreezeX.Text = "Freeze";
			this.chbFreezeX.UseVisualStyleBackColor = true;
			this.chbFreezeX.CheckedChanged += new System.EventHandler(this.chbFreezeX_CheckedChanged);
			// 
			// btnCancelEdit
			// 
			this.btnCancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelEdit.Location = new System.Drawing.Point(99, 173);
			this.btnCancelEdit.Name = "btnCancelEdit";
			this.btnCancelEdit.Size = new System.Drawing.Size(89, 35);
			this.btnCancelEdit.TabIndex = 10;
			this.btnCancelEdit.Text = "Cancel Edit";
			this.btnCancelEdit.UseVisualStyleBackColor = true;
			this.btnCancelEdit.Visible = false;
			this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
			// 
			// numHotkey
			// 
			this.numHotkey.Location = new System.Drawing.Point(3, 138);
			this.numHotkey.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.numHotkey.Name = "numHotkey";
			this.numHotkey.ReadOnly = true;
			this.numHotkey.Size = new System.Drawing.Size(35, 23);
			this.numHotkey.TabIndex = 9;
			this.numHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numHotkey.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "Hotkey";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(99, 127);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(89, 40);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save Position";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbHudZ
			// 
			this.lbHudZ.AutoSize = true;
			this.lbHudZ.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lbHudZ.Location = new System.Drawing.Point(3, 44);
			this.lbHudZ.Name = "lbHudZ";
			this.lbHudZ.Size = new System.Drawing.Size(60, 15);
			this.lbHudZ.TabIndex = 6;
			this.lbHudZ.Text = "Z: ????????";
			// 
			// lbHudY
			// 
			this.lbHudY.AutoSize = true;
			this.lbHudY.ForeColor = System.Drawing.Color.SeaGreen;
			this.lbHudY.Location = new System.Drawing.Point(3, 28);
			this.lbHudY.Name = "lbHudY";
			this.lbHudY.Size = new System.Drawing.Size(60, 15);
			this.lbHudY.TabIndex = 5;
			this.lbHudY.Text = "Y: ????????";
			// 
			// lbHudX
			// 
			this.lbHudX.AutoSize = true;
			this.lbHudX.ForeColor = System.Drawing.Color.Crimson;
			this.lbHudX.Location = new System.Drawing.Point(3, 12);
			this.lbHudX.Name = "lbHudX";
			this.lbHudX.Size = new System.Drawing.Size(60, 15);
			this.lbHudX.TabIndex = 4;
			this.lbHudX.Text = "X: ????????";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Description";
			// 
			// tbDescription
			// 
			this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDescription.Location = new System.Drawing.Point(3, 90);
			this.tbDescription.MaxLength = 25;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(185, 23);
			this.tbDescription.TabIndex = 0;
			this.tbDescription.Text = "Position 0";
			// 
			// positionReadClock
			// 
			this.positionReadClock.Tick += new System.EventHandler(this.positionReadClock_Tick);
			// 
			// connectToProcessClock
			// 
			this.connectToProcessClock.Interval = 1000;
			this.connectToProcessClock.Tick += new System.EventHandler(this.connectToProcessClock_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 328);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Tinykin TP Tool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHotkey)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox lstbPositions;
		private Panel panel1;
		private Panel panel2;
		private Button btnSave;
		private Label lbHudZ;
		private Label lbHudY;
		private Label lbHudX;
		private Label label1;
		private TextBox tbDescription;
		private System.Windows.Forms.Timer positionReadClock;
		private ComboBox cbLevelSelect;
		private NumericUpDown numHotkey;
		private Label label2;
		private System.Windows.Forms.Timer connectToProcessClock;
		private Button btnCancelEdit;
		private CheckBox chbFreezeZ;
		private CheckBox chbFreezeY;
		private CheckBox chbFreezeX;
		private TextBox textBox1;
	}
}