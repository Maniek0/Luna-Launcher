using CmlLib.Core;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;

namespace Luna_Launcher.Controls
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
            UpdateControlsValue();
        }
        private async void UpdateControlsValue()
        {
            DefaultVersionLoader launcher = new(new MinecraftPath(Properties.Settings.Default.minecraftPath));
            var versionsMetaDatas = await launcher.GetVersionMetadatasAsync();

            foreach (var item in versionsMetaDatas)
            {
                switch (item.MType)
                {
                    case MVersionType.Custom:
                        Versions.Items.Add(item.Name.ToString());
                        break;
                    case MVersionType.Release:
                        otherVersions.Items.Add(item.Name.ToString());
                        break;
                    case MVersionType.Snapshot:
                        if (Properties.Settings.Default.Snapshot)
                        { otherVersions.Items.Add(item.Name.ToString()); }
                        break;
                    case MVersionType.OldAlpha:
                        if (Properties.Settings.Default.OldAlfa)
                        { otherVersions.Items.Add(item.Name.ToString()); }
                        break;
                    case MVersionType.OldBeta:
                        if (Properties.Settings.Default.OldBeta)
                        { otherVersions.Items.Add(item.Name.ToString()); }
                        break;
                }
            }

            userName.Text = Properties.Settings.Default.Username;
            Snapshot.Checked = Properties.Settings.Default.Snapshot;
            OldAlpha.Checked = Properties.Settings.Default.OldAlfa;
            OldBeta.Checked = Properties.Settings.Default.OldBeta;
            minimumMb.Value = Properties.Settings.Default.MinimuRam;
            maximumMb.Value = Properties.Settings.Default.MaximumRam;
            Versions.SelectedIndex = Versions.Items.IndexOf(Properties.Settings.Default.version);
        }

        private void button2_Click(object sender, EventArgs e) => panel1.Visible = !panel1.Visible;

        private async void button3_Click(object sender, EventArgs e)
        {
            progress.Visible = true;
            progress.Value = 0;
            button3.Text = "Instalowanie";
            button3.Enabled = false;

            System.Net.ServicePointManager.DefaultConnectionLimit = 512;
            CMLauncher launcher = new(Properties.Settings.Default.minecraftPath);
            launcher.ProgressChanged += (s, e) =>
            {
                progress.Value = e.ProgressPercentage;
            };

            await launcher.CheckAndDownloadAsync(launcher.GetVersion(otherVersions.Text.ToString()));

            progress.Visible = false;
            button3.Text = "Instaluj";

            Versions.Items.Add(otherVersions.Text);
            otherVersions.Items.Remove(otherVersions.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Versions.Items.Count > 0)
            {
                Directory.Delete(Properties.Settings.Default.minecraftPath + @"\versions\" + Versions.Text.ToString(), true);
                otherVersions.Items.Add(Versions.Text);
                Versions.Items.Remove(Versions.Text);
                Versions.SelectedText = Properties.Settings.Default.version;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var appSettings = new Properties.Settings
            {
                Username = userName.Text,
                Snapshot = Snapshot.Checked,
                OldAlfa = OldAlpha.Checked,
                OldBeta = OldBeta.Checked,
                MinimuRam = (int)minimumMb.Value,
                MaximumRam = (int)maximumMb.Value,
                version = Versions.Text
            };
            appSettings.Save();
        }
    }
}
