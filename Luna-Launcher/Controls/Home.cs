using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;

namespace Luna_Launcher.Controls
{
    public partial class Home : UserControl
    {
        MLaunchOption LaunchOption;
        public Home()
        {
            InitializeComponent();
            LaunchOption = new();

            VersionsBox.SelectedIndexChanged += (s, e) =>
            {
                Properties.Settings.Default.version = VersionsBox.Text;
                Properties.Settings.Default.Save();
            };

            updateVersions();
        }
        public void updateVersions()
        {
            DefaultVersionLoader versionLoader = new(new MinecraftPath(Properties.Settings.Default.minecraftPath));
            var versions = versionLoader.GetVersionMetadatas();
            foreach (var version in versions)
            {
                if (version.MType == MVersionType.Custom)
                {
                    VersionsBox.Items.Add(version.Name.ToString());
                    Console.WriteLine(version.Name);
                }
            }

            int index = VersionsBox.Items.IndexOf(Properties.Settings.Default.version);
            if (index >= 0)
            {
                VersionsBox.SelectedIndex = index;
            }
        }
        private async void playBtn_Click(object sender, EventArgs e)
        {
            if (LaunchOption.StartVersion == null && Properties.Settings.Default.version != "")
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 512;

                LaunchOption.MaximumRamMb = Properties.Settings.Default.MaximumRam;
                LaunchOption.MinimumRamMb = Properties.Settings.Default.MinimuRam;
                LaunchOption.Session = MSession.GetOfflineSession(Properties.Settings.Default.Username);

                CMLauncher launcher = new(Properties.Settings.Default.minecraftPath);
                await launcher.LaunchAsync(Properties.Settings.Default.version, LaunchOption);
            }
        }
    }
}