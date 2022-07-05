namespace DoomLauncher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSourcePort = new System.Windows.Forms.Button();
            this.lblSourcePort = new System.Windows.Forms.Label();
            this.lstIWads = new System.Windows.Forms.ListBox();
            this.lstPWads = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnDeselectPWad = new System.Windows.Forms.Button();
            this.cboCompLevel = new System.Windows.Forms.ComboBox();
            this.lblCompLevel = new System.Windows.Forms.Label();
            this.chkShortTics = new System.Windows.Forms.CheckBox();
            this.chkNoMonsters = new System.Windows.Forms.CheckBox();
            this.chkNoMusic = new System.Windows.Forms.CheckBox();
            this.chkRecordDemo = new System.Windows.Forms.CheckBox();
            this.txtDemoName = new System.Windows.Forms.TextBox();
            this.cboSkill = new System.Windows.Forms.ComboBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblWarp = new System.Windows.Forms.Label();
            this.cboWarp = new System.Windows.Forms.ComboBox();
            this.chkSoloNet = new System.Windows.Forms.CheckBox();
            this.lblIWads = new System.Windows.Forms.Label();
            this.lblPWads = new System.Windows.Forms.Label();
            this.chkFast = new System.Windows.Forms.CheckBox();
            this.chkRespawn = new System.Windows.Forms.CheckBox();
            this.cboWarpDoom1 = new System.Windows.Forms.ComboBox();
            this.btnWadDirectory = new System.Windows.Forms.Button();
            this.btnDemoMode = new System.Windows.Forms.Button();
            this.btnPlayMode = new System.Windows.Forms.Button();
            this.btnDemoDirectory = new System.Windows.Forms.Button();
            this.lblDemo = new System.Windows.Forms.Label();
            this.lstDemos = new System.Windows.Forms.ListBox();
            this.pnlPlaySettings = new System.Windows.Forms.Panel();
            this.pnlPlaySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSourcePort
            // 
            this.btnSourcePort.Location = new System.Drawing.Point(12, 12);
            this.btnSourcePort.Name = "btnSourcePort";
            this.btnSourcePort.Size = new System.Drawing.Size(90, 23);
            this.btnSourcePort.TabIndex = 0;
            this.btnSourcePort.Text = "Source Port";
            this.btnSourcePort.UseVisualStyleBackColor = true;
            this.btnSourcePort.Click += new System.EventHandler(this.btnSourcePort_Click);
            // 
            // lblSourcePort
            // 
            this.lblSourcePort.AutoSize = true;
            this.lblSourcePort.Location = new System.Drawing.Point(12, 38);
            this.lblSourcePort.Name = "lblSourcePort";
            this.lblSourcePort.Size = new System.Drawing.Size(125, 13);
            this.lblSourcePort.TabIndex = 1;
            this.lblSourcePort.Text = "No Source Port Selected";
            // 
            // lstIWads
            // 
            this.lstIWads.FormattingEnabled = true;
            this.lstIWads.Location = new System.Drawing.Point(18, 109);
            this.lstIWads.Name = "lstIWads";
            this.lstIWads.Size = new System.Drawing.Size(180, 69);
            this.lstIWads.TabIndex = 2;
            this.lstIWads.SelectedIndexChanged += new System.EventHandler(this.lstIWads_SelectedIndexChanged);
            // 
            // lstPWads
            // 
            this.lstPWads.FormattingEnabled = true;
            this.lstPWads.Location = new System.Drawing.Point(220, 33);
            this.lstPWads.Name = "lstPWads";
            this.lstPWads.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPWads.Size = new System.Drawing.Size(156, 342);
            this.lstPWads.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(17, 361);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(181, 43);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "PLAY DOOM";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnDeselectPWad
            // 
            this.btnDeselectPWad.Location = new System.Drawing.Point(301, 381);
            this.btnDeselectPWad.Name = "btnDeselectPWad";
            this.btnDeselectPWad.Size = new System.Drawing.Size(75, 23);
            this.btnDeselectPWad.TabIndex = 7;
            this.btnDeselectPWad.Text = "Deselect";
            this.btnDeselectPWad.UseVisualStyleBackColor = true;
            this.btnDeselectPWad.Click += new System.EventHandler(this.btnDeselectPWad_Click);
            // 
            // cboCompLevel
            // 
            this.cboCompLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompLevel.FormattingEnabled = true;
            this.cboCompLevel.Items.AddRange(new object[] {
            "Default",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "21"});
            this.cboCompLevel.Location = new System.Drawing.Point(3, 32);
            this.cboCompLevel.Name = "cboCompLevel";
            this.cboCompLevel.Size = new System.Drawing.Size(63, 21);
            this.cboCompLevel.TabIndex = 9;
            // 
            // lblCompLevel
            // 
            this.lblCompLevel.AutoSize = true;
            this.lblCompLevel.Location = new System.Drawing.Point(3, 8);
            this.lblCompLevel.Name = "lblCompLevel";
            this.lblCompLevel.Size = new System.Drawing.Size(66, 13);
            this.lblCompLevel.TabIndex = 10;
            this.lblCompLevel.Text = "Comp Level:";
            // 
            // chkShortTics
            // 
            this.chkShortTics.AutoSize = true;
            this.chkShortTics.Location = new System.Drawing.Point(95, 96);
            this.chkShortTics.Name = "chkShortTics";
            this.chkShortTics.Size = new System.Drawing.Size(74, 17);
            this.chkShortTics.TabIndex = 15;
            this.chkShortTics.Text = "Short Tics";
            this.chkShortTics.UseVisualStyleBackColor = true;
            // 
            // chkNoMonsters
            // 
            this.chkNoMonsters.AutoSize = true;
            this.chkNoMonsters.Location = new System.Drawing.Point(3, 73);
            this.chkNoMonsters.Name = "chkNoMonsters";
            this.chkNoMonsters.Size = new System.Drawing.Size(86, 17);
            this.chkNoMonsters.TabIndex = 16;
            this.chkNoMonsters.Text = "No Monsters";
            this.chkNoMonsters.UseVisualStyleBackColor = true;
            this.chkNoMonsters.CheckedChanged += new System.EventHandler(this.chkNoMonsters_CheckedChanged);
            // 
            // chkNoMusic
            // 
            this.chkNoMusic.AutoSize = true;
            this.chkNoMusic.Location = new System.Drawing.Point(95, 73);
            this.chkNoMusic.Name = "chkNoMusic";
            this.chkNoMusic.Size = new System.Drawing.Size(71, 17);
            this.chkNoMusic.TabIndex = 17;
            this.chkNoMusic.Text = "No Music";
            this.chkNoMusic.UseVisualStyleBackColor = true;
            // 
            // chkRecordDemo
            // 
            this.chkRecordDemo.AutoSize = true;
            this.chkRecordDemo.Location = new System.Drawing.Point(95, 119);
            this.chkRecordDemo.Name = "chkRecordDemo";
            this.chkRecordDemo.Size = new System.Drawing.Size(92, 17);
            this.chkRecordDemo.TabIndex = 18;
            this.chkRecordDemo.Text = "Record Demo";
            this.chkRecordDemo.UseVisualStyleBackColor = true;
            this.chkRecordDemo.CheckedChanged += new System.EventHandler(this.chkRecordDemo_CheckedChanged);
            // 
            // txtDemoName
            // 
            this.txtDemoName.Enabled = false;
            this.txtDemoName.Location = new System.Drawing.Point(95, 142);
            this.txtDemoName.Name = "txtDemoName";
            this.txtDemoName.Size = new System.Drawing.Size(100, 20);
            this.txtDemoName.TabIndex = 19;
            this.txtDemoName.Text = "demofilename";
            // 
            // cboSkill
            // 
            this.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill.FormattingEnabled = true;
            this.cboSkill.Items.AddRange(new object[] {
            "Default",
            "ITYTD",
            "HNTR",
            "HMP",
            "UV",
            "NM"});
            this.cboSkill.Location = new System.Drawing.Point(72, 32);
            this.cboSkill.Name = "cboSkill";
            this.cboSkill.Size = new System.Drawing.Size(63, 21);
            this.cboSkill.TabIndex = 21;
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(72, 8);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(29, 13);
            this.lblSkill.TabIndex = 22;
            this.lblSkill.Text = "Skill:";
            // 
            // lblWarp
            // 
            this.lblWarp.AutoSize = true;
            this.lblWarp.Location = new System.Drawing.Point(141, 8);
            this.lblWarp.Name = "lblWarp";
            this.lblWarp.Size = new System.Drawing.Size(36, 13);
            this.lblWarp.TabIndex = 23;
            this.lblWarp.Text = "Warp:";
            // 
            // cboWarp
            // 
            this.cboWarp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarp.FormattingEnabled = true;
            this.cboWarp.Items.AddRange(new object[] {
            "Default",
            "MAP01",
            "MAP02",
            "MAP03",
            "MAP04",
            "MAP05",
            "MAP06",
            "MAP07",
            "MAP08",
            "MAP09",
            "MAP10",
            "MAP11",
            "MAP12",
            "MAP13",
            "MAP14",
            "MAP15",
            "MAP16",
            "MAP17",
            "MAP18",
            "MAP19",
            "MAP20",
            "MAP21",
            "MAP22",
            "MAP23",
            "MAP24",
            "MAP25",
            "MAP26",
            "MAP27",
            "MAP28",
            "MAP29",
            "MAP30",
            "MAP31",
            "MAP32",
            "MAP33",
            "MAP34",
            "MAP35",
            "MAP36",
            "MAP37",
            "MAP38",
            "MAP39",
            "MAP40",
            "MAP41",
            "MAP42",
            "MAP43",
            "MAP44",
            "MAP45",
            "MAP46",
            "MAP47",
            "MAP48",
            "MAP49",
            "MAP50",
            "MAP51",
            "MAP52",
            "MAP53",
            "MAP54",
            "MAP55",
            "MAP56",
            "MAP57",
            "MAP58",
            "MAP59",
            "MAP60"});
            this.cboWarp.Location = new System.Drawing.Point(141, 32);
            this.cboWarp.Name = "cboWarp";
            this.cboWarp.Size = new System.Drawing.Size(63, 21);
            this.cboWarp.TabIndex = 24;
            // 
            // chkSoloNet
            // 
            this.chkSoloNet.AutoSize = true;
            this.chkSoloNet.Location = new System.Drawing.Point(3, 142);
            this.chkSoloNet.Name = "chkSoloNet";
            this.chkSoloNet.Size = new System.Drawing.Size(67, 17);
            this.chkSoloNet.TabIndex = 25;
            this.chkSoloNet.Text = "Solo Net";
            this.chkSoloNet.UseVisualStyleBackColor = true;
            // 
            // lblIWads
            // 
            this.lblIWads.AutoSize = true;
            this.lblIWads.Location = new System.Drawing.Point(18, 93);
            this.lblIWads.Name = "lblIWads";
            this.lblIWads.Size = new System.Drawing.Size(36, 13);
            this.lblIWads.TabIndex = 26;
            this.lblIWads.Text = "IWad:";
            // 
            // lblPWads
            // 
            this.lblPWads.AutoSize = true;
            this.lblPWads.Location = new System.Drawing.Point(220, 17);
            this.lblPWads.Name = "lblPWads";
            this.lblPWads.Size = new System.Drawing.Size(40, 13);
            this.lblPWads.TabIndex = 27;
            this.lblPWads.Text = "PWad:";
            // 
            // chkFast
            // 
            this.chkFast.AutoSize = true;
            this.chkFast.Location = new System.Drawing.Point(3, 96);
            this.chkFast.Name = "chkFast";
            this.chkFast.Size = new System.Drawing.Size(46, 17);
            this.chkFast.TabIndex = 28;
            this.chkFast.Text = "Fast";
            this.chkFast.UseVisualStyleBackColor = true;
            // 
            // chkRespawn
            // 
            this.chkRespawn.AutoSize = true;
            this.chkRespawn.Location = new System.Drawing.Point(3, 119);
            this.chkRespawn.Name = "chkRespawn";
            this.chkRespawn.Size = new System.Drawing.Size(71, 17);
            this.chkRespawn.TabIndex = 29;
            this.chkRespawn.Text = "Respawn";
            this.chkRespawn.UseVisualStyleBackColor = true;
            // 
            // cboWarpDoom1
            // 
            this.cboWarpDoom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarpDoom1.Enabled = false;
            this.cboWarpDoom1.FormattingEnabled = true;
            this.cboWarpDoom1.Items.AddRange(new object[] {
            "Default",
            "E1M1",
            "E1M2",
            "E1M3",
            "E1M4",
            "E1M5",
            "E1M6",
            "E1M7",
            "E1M8",
            "E1M9",
            "E2M1",
            "E2M2",
            "E2M3",
            "E2M4",
            "E2M5",
            "E2M6",
            "E2M7",
            "E2M8",
            "E2M9",
            "E3M1",
            "E3M2",
            "E3M3",
            "E3M4",
            "E3M5",
            "E3M6",
            "E3M7",
            "E3M8",
            "E3M9",
            "E4M1",
            "E4M2",
            "E4M3",
            "E4M4",
            "E4M5",
            "E4M6",
            "E4M7",
            "E4M8",
            "E4M9",
            "E5M1",
            "E5M2",
            "E5M3",
            "E5M4",
            "E5M5",
            "E5M6",
            "E5M7",
            "E5M8",
            "E5M9"});
            this.cboWarpDoom1.Location = new System.Drawing.Point(141, 32);
            this.cboWarpDoom1.Name = "cboWarpDoom1";
            this.cboWarpDoom1.Size = new System.Drawing.Size(63, 21);
            this.cboWarpDoom1.TabIndex = 30;
            this.cboWarpDoom1.Visible = false;
            // 
            // btnWadDirectory
            // 
            this.btnWadDirectory.Location = new System.Drawing.Point(12, 57);
            this.btnWadDirectory.Name = "btnWadDirectory";
            this.btnWadDirectory.Size = new System.Drawing.Size(90, 23);
            this.btnWadDirectory.TabIndex = 31;
            this.btnWadDirectory.Text = "Wad Directory";
            this.btnWadDirectory.UseVisualStyleBackColor = true;
            this.btnWadDirectory.Click += new System.EventHandler(this.btnWadDirectory_Click);
            // 
            // btnDemoMode
            // 
            this.btnDemoMode.Location = new System.Drawing.Point(108, 12);
            this.btnDemoMode.Name = "btnDemoMode";
            this.btnDemoMode.Size = new System.Drawing.Size(90, 23);
            this.btnDemoMode.TabIndex = 32;
            this.btnDemoMode.Text = "To Demo Mode";
            this.btnDemoMode.UseVisualStyleBackColor = true;
            this.btnDemoMode.Click += new System.EventHandler(this.btnDemoMode_Click);
            // 
            // btnPlayMode
            // 
            this.btnPlayMode.Enabled = false;
            this.btnPlayMode.Location = new System.Drawing.Point(109, 12);
            this.btnPlayMode.Name = "btnPlayMode";
            this.btnPlayMode.Size = new System.Drawing.Size(90, 23);
            this.btnPlayMode.TabIndex = 33;
            this.btnPlayMode.Text = "To Play Mode";
            this.btnPlayMode.UseVisualStyleBackColor = true;
            this.btnPlayMode.Visible = false;
            this.btnPlayMode.Click += new System.EventHandler(this.btnPlayMode_Click);
            // 
            // btnDemoDirectory
            // 
            this.btnDemoDirectory.Enabled = false;
            this.btnDemoDirectory.Location = new System.Drawing.Point(108, 57);
            this.btnDemoDirectory.Name = "btnDemoDirectory";
            this.btnDemoDirectory.Size = new System.Drawing.Size(90, 23);
            this.btnDemoDirectory.TabIndex = 34;
            this.btnDemoDirectory.Text = "Demo Directory";
            this.btnDemoDirectory.UseVisualStyleBackColor = true;
            this.btnDemoDirectory.Visible = false;
            this.btnDemoDirectory.Click += new System.EventHandler(this.btnDemoDirectory_Click);
            // 
            // lblDemo
            // 
            this.lblDemo.AutoSize = true;
            this.lblDemo.Location = new System.Drawing.Point(14, 190);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(38, 13);
            this.lblDemo.TabIndex = 35;
            this.lblDemo.Text = "Demo:";
            this.lblDemo.Visible = false;
            // 
            // lstDemos
            // 
            this.lstDemos.Enabled = false;
            this.lstDemos.FormattingEnabled = true;
            this.lstDemos.Location = new System.Drawing.Point(17, 206);
            this.lstDemos.Name = "lstDemos";
            this.lstDemos.Size = new System.Drawing.Size(181, 147);
            this.lstDemos.TabIndex = 36;
            this.lstDemos.Visible = false;
            // 
            // pnlPlaySettings
            // 
            this.pnlPlaySettings.Controls.Add(this.cboCompLevel);
            this.pnlPlaySettings.Controls.Add(this.lblCompLevel);
            this.pnlPlaySettings.Controls.Add(this.chkShortTics);
            this.pnlPlaySettings.Controls.Add(this.chkNoMonsters);
            this.pnlPlaySettings.Controls.Add(this.chkNoMusic);
            this.pnlPlaySettings.Controls.Add(this.cboWarpDoom1);
            this.pnlPlaySettings.Controls.Add(this.cboWarp);
            this.pnlPlaySettings.Controls.Add(this.chkRecordDemo);
            this.pnlPlaySettings.Controls.Add(this.chkRespawn);
            this.pnlPlaySettings.Controls.Add(this.txtDemoName);
            this.pnlPlaySettings.Controls.Add(this.chkFast);
            this.pnlPlaySettings.Controls.Add(this.cboSkill);
            this.pnlPlaySettings.Controls.Add(this.lblSkill);
            this.pnlPlaySettings.Controls.Add(this.lblWarp);
            this.pnlPlaySettings.Controls.Add(this.chkSoloNet);
            this.pnlPlaySettings.Location = new System.Drawing.Point(12, 184);
            this.pnlPlaySettings.Name = "pnlPlaySettings";
            this.pnlPlaySettings.Size = new System.Drawing.Size(207, 165);
            this.pnlPlaySettings.TabIndex = 37;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 416);
            this.Controls.Add(this.lblIWads);
            this.Controls.Add(this.lstIWads);
            this.Controls.Add(this.pnlPlaySettings);
            this.Controls.Add(this.lstDemos);
            this.Controls.Add(this.lblDemo);
            this.Controls.Add(this.btnDemoDirectory);
            this.Controls.Add(this.btnPlayMode);
            this.Controls.Add(this.btnDemoMode);
            this.Controls.Add(this.btnWadDirectory);
            this.Controls.Add(this.lblPWads);
            this.Controls.Add(this.btnDeselectPWad);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lstPWads);
            this.Controls.Add(this.lblSourcePort);
            this.Controls.Add(this.btnSourcePort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoBad\'s Doom Launcher";
            this.pnlPlaySettings.ResumeLayout(false);
            this.pnlPlaySettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSourcePort;
        private System.Windows.Forms.Label lblSourcePort;
        private System.Windows.Forms.ListBox lstIWads;
        private System.Windows.Forms.ListBox lstPWads;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnDeselectPWad;
        private System.Windows.Forms.ComboBox cboCompLevel;
        private System.Windows.Forms.Label lblCompLevel;
        private System.Windows.Forms.CheckBox chkShortTics;
        private System.Windows.Forms.CheckBox chkNoMonsters;
        private System.Windows.Forms.CheckBox chkNoMusic;
        private System.Windows.Forms.CheckBox chkRecordDemo;
        private System.Windows.Forms.TextBox txtDemoName;
        private System.Windows.Forms.ComboBox cboSkill;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblWarp;
        private System.Windows.Forms.ComboBox cboWarp;
        private System.Windows.Forms.CheckBox chkSoloNet;
        private System.Windows.Forms.Label lblIWads;
        private System.Windows.Forms.Label lblPWads;
        private System.Windows.Forms.CheckBox chkFast;
        private System.Windows.Forms.CheckBox chkRespawn;
        private System.Windows.Forms.ComboBox cboWarpDoom1;
        private System.Windows.Forms.Button btnWadDirectory;
        private System.Windows.Forms.Button btnDemoMode;
        private System.Windows.Forms.Button btnPlayMode;
        private System.Windows.Forms.Button btnDemoDirectory;
        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.ListBox lstDemos;
        private System.Windows.Forms.Panel pnlPlaySettings;
    }
}

