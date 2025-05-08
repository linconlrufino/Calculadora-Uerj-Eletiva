namespace CalculadoraBase
{
    public partial class CreditosForm : Form
    {
        public CreditosForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/linconlrufino",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/linconl-rufino/",
                UseShellExecute = true
            });
        }
    }
}
