namespace Luna_Launcher
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
            settings1.InstalingEvent += home1.updateVersions;
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            settings1.Visible = false;
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            settings1.Visible = true;
        }
    }
}