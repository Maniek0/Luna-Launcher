using CmlLib.Core;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;

namespace Luna_Launcher.Controls
{
    public partial class settings : UserControl
    {
        public delegate void InstalingVersionEvent();
        public event InstalingVersionEvent InstalingEvent;
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
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            progress.Visible = true;
            progress.Value = 0;
            button3.Text = "Instalowanie";
            button3.Enabled = false;
            otherVersions.Enabled = false;

            System.Net.ServicePointManager.DefaultConnectionLimit = 512;
            CMLauncher launcher = new(Properties.Settings.Default.minecraftPath);
            launcher.ProgressChanged += (s, e) =>
            {
                progress.Value = e.ProgressPercentage;
            };

            string version = otherVersions.Text.ToString();

            await launcher.CheckAndDownloadAsync(launcher.GetVersion(version));
            InstalingEvent();

            progress.Visible = false;
            button3.Text = "Instaluj";
            button3.Enabled = true;

            otherVersions.Enabled = true;
            otherVersions.Items.Remove(version);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = userName.Text;
            Properties.Settings.Default.Snapshot = Snapshot.Checked;
            Properties.Settings.Default.OldAlfa = OldAlpha.Checked;
            Properties.Settings.Default.OldBeta = OldBeta.Checked;
            Properties.Settings.Default.MinimuRam = (int)minimumMb.Value;
            Properties.Settings.Default.MaximumRam = (int)maximumMb.Value;
            Properties.Settings.Default.Save();
        }
    }
}