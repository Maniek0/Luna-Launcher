using CmlLib.Core;
using CmlLib.Core.Auth;

namespace Luna_Launcher.Controls
{
    public partial class Home : UserControl
    {
        MLaunchOption LaunchOption;
        public Home()
        {
            InitializeComponent();
            LaunchOption = new();
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