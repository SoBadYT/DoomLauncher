using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DoomLauncher
{
    public partial class MainForm : Form
    {
        private readonly string saveFile = @"\_sobad_doom_launcher.cfg";

        private string savePath;

        private string sourceportPath;
        private string demoDirectory;
        private string wadDirectory;


        public MainForm()
        {
            InitializeComponent();

            SetDirectories();
            TryLoadSettings();
        }

        #region Launcher Logic
        private bool ChangeDirectory(string message, out string newDirectory)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = message;
                fbd.ShowNewFolderButton = false;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    newDirectory = fbd.SelectedPath;
                    return true;
                }
                newDirectory = null;
                return false;
            }
        }


        private void ChangeMode(bool demoTime)
        {
            btnDemoMode.Enabled = !demoTime;
            btnDemoMode.Visible = !demoTime;
            btnPlayMode.Enabled = demoTime;
            btnPlayMode.Visible = demoTime;

            btnDemoDirectory.Enabled = demoTime;
            btnDemoDirectory.Visible = demoTime;

            lblDemo.Visible = demoTime;

            lstDemos.Enabled = demoTime;
            lstDemos.Visible = demoTime;

            pnlPlaySettings.Enabled = !demoTime;
            pnlPlaySettings.Visible = !demoTime;
        }


        private void ChangeSourcePort()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Source Ports (*.exe)|*.exe|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] splitPath = openFileDialog.FileName.Split('\\');
                    string executable = splitPath[splitPath.Length - 1];
                    lblSourcePort.Text = executable;
                    sourceportPath = openFileDialog.FileName;
                }
            }
        }


        private bool CheckIfValidIWad(string wadName)
        {
            byte[] identifier = new byte[4];
            FileStream stream = File.OpenRead(wadName);
            stream.Read(identifier, 0, 4);
            return System.Text.Encoding.UTF8.GetString(identifier, 0, identifier.Length) == "IWAD";
        }


        private void DefaultComboBoxes()
        {
            cboCompLevel.SelectedIndex = 0;
            cboSkill.SelectedIndex = 0;
            cboWarp.SelectedIndex = 0;
            cboWarpDoom1.SelectedIndex = 0;
        }


        private void DisplayError(string message, string header)
        {
            MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void EnableProperWarpComboBox()
        {
            bool doom1Selected = lstIWads.Items.Count > 0 ? lstIWads.SelectedItem.ToString() == "doom.wad" : false;
            cboWarp.Enabled = !doom1Selected;
            cboWarp.Visible = !doom1Selected;
            cboWarpDoom1.Enabled = doom1Selected;
            cboWarpDoom1.Visible = doom1Selected;
        }


        private void LoadFiles(string fileDirectory, string fileType)
        {
            if (!Directory.Exists(fileDirectory))
                return;

            string[] splitPath;
            string fileToLoad;

            string[] allFiles = Directory.GetFiles(fileDirectory);

            foreach (string file in allFiles)
            {
                if (!file.ToLower().EndsWith(fileType))
                    continue;

                splitPath = file.Split('\\');
                fileToLoad = splitPath[splitPath.Length - 1].ToLower();

                if (fileType == ".wad")
                {
                    if (CheckIfValidIWad(file))
                    {
                        lstIWads.Items.Add(fileToLoad);
                    }
                    else
                    {
                        lstPWads.Items.Add(fileToLoad);
                    }
                }
                else if (fileType == ".deh")
                {
                    lstPWads.Items.Add(fileToLoad);
                }
                else // Therefore must be a demo.
                {
                    lstDemos.Items.Add(fileToLoad);
                }
            }
        }


        private void LoadDemos()
        {
            LoadFiles(demoDirectory, ".lmp");
        }


        private void LoadWads()
        {
            LoadFiles(wadDirectory, ".wad");
            LoadFiles(wadDirectory, ".deh");
            lstPWads.Sorted = true; // Puts same-named .deh next to .wad files.
        }


        private string PrepareLaunchCommand()
        {
            StringBuilder launchCommand = new StringBuilder();
            launchCommand.Append($"-iwad \"{wadDirectory + @"\" + lstIWads.SelectedItem}\" ");

            if (lstPWads.SelectedIndices.Count > 0)
            {
                launchCommand.Append($"-file ");
                foreach (object wad in lstPWads.SelectedItems)
                {
                    launchCommand.Append($"\"{wadDirectory + @"\" + wad}\" ");
                }
            }

            if (!pnlPlaySettings.Enabled) // Early exit if only playing demo file.
            {
                launchCommand.Append($"-playdemo \"{demoDirectory + @"\" + lstDemos.SelectedItem}\" ");
                return launchCommand.ToString();
            }

            if (cboCompLevel.SelectedIndex > 0) // Allows for default comp level.
            {
                launchCommand.Append($"-complevel {cboCompLevel.SelectedItem} ");
            }

            if (cboWarp.Enabled && cboWarp.SelectedIndex > 0) // Allows for main menu access.
            {
                launchCommand.Append($"-warp {cboWarp.SelectedIndex} ");
            }
            else if (cboWarpDoom1.Enabled && cboWarpDoom1.SelectedIndex > 0)
            {
                string mapCode = cboWarpDoom1.SelectedItem.ToString();
                launchCommand.Append($"-warp {mapCode[1]} {mapCode[3]} ");
            }

            if (cboSkill.SelectedIndex > 0) // Allows for main menu access.
            {
                launchCommand.Append($"-skill {cboSkill.SelectedIndex} ");
            }
            if (chkNoMonsters.Checked)
            {
                launchCommand.Append($"-nomonsters 1 ");
            }
            if (chkFast.Checked)
            {
                launchCommand.Append($"-fast 1 ");
            }
            if (chkRespawn.Checked)
            {
                launchCommand.Append($"-respawn 1 ");
            }
            if (chkNoMusic.Checked)
            {
                launchCommand.Append($"-nomusic 1 ");
            }
            if (chkShortTics.Checked)
            {
                launchCommand.Append($"-shorttics 1 ");
            }
            if (chkSoloNet.Checked)
            {
                launchCommand.Append($"-solo-net 1 ");
            }
            if (chkRecordDemo.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDemoName.Text))
                {
                    DisplayError($"Please choose a name for your demo.", "No demo filename.");
                    return null; // Checked for in TryLaunchDoom, which aborts process.
                }
                if (txtDemoName.Text.Contains(" "))
                {
                    DisplayError($"Please remove whitespace from your demo name.", "Whitespace in filename.");
                    return null; // Checked for in TryLaunchDoom, which aborts process.
                }
                
                launchCommand.Append($"-record {txtDemoName.Text}");
            }

            return launchCommand.ToString();
        }


        private void SaveSettings()
        {
            StringBuilder settings = new StringBuilder();

            // Launcher Parameters
            settings.Append(lblSourcePort.Text + "|");
            settings.Append(lstIWads.SelectedItem.ToString() + "|");
            settings.Append(lstPWads.SelectedIndices.Count > 0 ? SaveMultiplePWads() + "|" : "no_pwad|");
            settings.Append(cboCompLevel.SelectedIndex.ToString() + "|");
            settings.Append(cboSkill.SelectedIndex.ToString() + "|");
            settings.Append(cboWarp.SelectedIndex.ToString() + "|");
            settings.Append(cboWarpDoom1.SelectedIndex.ToString() + "|"); // Special Doom1 Map names added.
            settings.Append(chkNoMonsters.Checked.ToString() + "|");
            settings.Append(chkFast.Checked.ToString() + "|");
            settings.Append(chkRespawn.Checked.ToString() + "|");
            settings.Append(chkNoMusic.Checked.ToString() + "|");
            settings.Append(chkSoloNet.Checked.ToString() + "|");
            settings.Append(chkShortTics.Checked.ToString() + "|");
            settings.Append(chkRecordDemo.Checked.ToString() + "|");
            settings.Append(txtDemoName.Text + "|");

            // Demo Info
            settings.Append(lstDemos.SelectedIndex > -1 ? lstDemos.SelectedItem.ToString() + "|" : "no_demo|");
            settings.Append(pnlPlaySettings.Enabled + "|");

            // Directories
            settings.Append(sourceportPath + "|");
            settings.Append(demoDirectory + "|");
            settings.Append(wadDirectory);

            using (StreamWriter writer = File.CreateText(savePath))
            {
                writer.Write(settings.ToString());
            }

            // Local helper just for cleanliness.
            string SaveMultiplePWads()
            {
                StringBuilder builder = new StringBuilder();

                foreach (object wad in lstPWads.SelectedItems)
                {
                    builder.Append($"{wad}&"); // Can't use '|' as delimiter here.
                }

                string result = builder.ToString();
                return result.Remove(result.Length - 1); // Don't need extra '&' at end of string.
            }
        }


        private void SetDirectories()
        {
            try
            {
                savePath = Environment.CurrentDirectory + saveFile;
            }
            catch
            {
                DisplayError($"Can't find current directory or don't have permission to access it. " +
                    $"Please move me somewhere else.", "Directory Lookup Error.");
            }
        }


        private void TryLaunchDoom(string launchCommand)
        {
            if (launchCommand == null) // Null in case of unnamed demo during recording attempt.
                return;

            try
            {
                System.Diagnostics.Process.Start(sourceportPath, launchCommand);
            }
            catch (FileNotFoundException)
            {
                DisplayError($"Your {lblSourcePort.Text} can't be found. " +
                    $"Have you moved or deleted it since your last session?", "Whoa hold on.");
            }
            catch
            {
                DisplayError($"Something went wrong. You can try again or inform me of the error by reaching " +
                    $"out on itch or YouTube.", "Unknown error.");
            }
        }


        private void TryLoadSettings()
        {
            if (!File.Exists(savePath))
            {
                DefaultComboBoxes();
                return;
            }

            string[] loadData = File.ReadAllText(savePath).Split('|');

            if (loadData.Length != 20) // In case user manually altered .cfg file, or old version.
                return; 

            wadDirectory = loadData[loadData.Length - 1];
            demoDirectory = loadData[loadData.Length - 2];
            sourceportPath = loadData[loadData.Length - 3];

            if (wadDirectory == "")
            {
                wadDirectory = null;
            }

            if (demoDirectory == "")
            {
                demoDirectory = null;
            }

            LoadWads();
            LoadDemos();

            lblSourcePort.Text = loadData[0];
            lstIWads.SelectedIndex = lstIWads.FindString(loadData[1]);

            string[] pwads = loadData[2].Split('&');
            foreach (string pwad in pwads)
            {
                int index = lstPWads.FindString(pwad);
                if (index == -1)
                    continue;

                lstPWads.SetSelected(index, true);
            }

            cboCompLevel.SelectedIndex = int.Parse(loadData[3]);
            cboSkill.SelectedIndex = int.Parse(loadData[4]);
            cboWarp.SelectedIndex = int.Parse(loadData[5]);
            cboWarpDoom1.SelectedIndex = int.Parse(loadData[6]);
            chkNoMonsters.Checked = bool.Parse(loadData[7]);
            chkFast.Checked = bool.Parse(loadData[8]);
            chkRespawn.Checked = bool.Parse(loadData[9]);
            chkNoMusic.Checked = bool.Parse(loadData[10]);
            chkSoloNet.Checked = bool.Parse(loadData[11]);
            chkShortTics.Checked = bool.Parse(loadData[12]);
            chkRecordDemo.Checked = bool.Parse(loadData[13]);
            txtDemoName.Text = loadData[14];
            lstDemos.SelectedIndex = lstDemos.FindString(loadData[15]);

            if (chkRecordDemo.Checked)
            {
                txtDemoName.Enabled = true;
            }
            if (chkNoMonsters.Checked)
            {
                chkFast.Enabled = false;
                chkRespawn.Enabled = false;
            }

            EnableProperWarpComboBox();
            ChangeMode(!bool.Parse(loadData[16]));
        }
        #endregion

        #region WinForms Controls Events
        private void btnDemoDirectory_Click(object sender, EventArgs e)
        {
            if (!ChangeDirectory("Please select your demos folder.", out string newDirectory))
                return;

            demoDirectory = newDirectory;
            lstDemos.Items.Clear();
            LoadDemos();
        }


        private void btnDemoMode_Click(object sender, EventArgs e)
        {
            ChangeMode(true);
        }


        private void btnDeselectPWad_Click(object sender, EventArgs e)
        {
            lstPWads.SelectedIndex = -1;
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!lblSourcePort.Text.EndsWith(".exe"))
            {
                DisplayError("No source port selected.", "You goofed!");
                return;
            }

            if (lstIWads.SelectedIndex == -1)
            {
                DisplayError("No iwad selected.", "You goofed!");
                return;
            }

            if (!pnlPlaySettings.Enabled && lstDemos.SelectedIndex == -1)
            {
                DisplayError("No demo selected.", "You goofed!");
                return;
            }

            SaveSettings();
            TryLaunchDoom(PrepareLaunchCommand());
        }


        private void btnPlayMode_Click(object sender, EventArgs e)
        {
            ChangeMode(false);
        }


        private void btnSourcePort_Click(object sender, EventArgs e)
        {
            ChangeSourcePort();
        }


        private void btnWadDirectory_Click(object sender, EventArgs e)
        {
            if (!ChangeDirectory("Please select your wads folder.", out string newDirectory))
                return;

            wadDirectory = newDirectory;
            lstIWads.Items.Clear();
            lstPWads.Items.Clear();
            LoadWads();
        }


        private void chkNoMonsters_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoMonsters.Checked)
            {
                chkFast.Checked = false;
                chkFast.Enabled = false;
                chkRespawn.Checked = false;
                chkRespawn.Enabled = false;
            }
            else
            {
                chkFast.Enabled = true;
                chkRespawn.Enabled = true;
            }
        }


        private void chkRecordDemo_CheckedChanged(object sender, EventArgs e)
        {
            txtDemoName.Enabled = ((CheckBox)sender).Checked;
        }


        private void lstIWads_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableProperWarpComboBox();
        }
        #endregion
    }
}