using System;
using System.Windows.Forms;

namespace WebNovelAssistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Tsmi_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_HelpAbout_Click(object sender, EventArgs e)
        {
            UriBuilder uri = new UriBuilder("http://I.Havent.Set.It.Yet");
            MessageBox.Show("Made By all the contributors found here: " + uri, "About this software");
        }

        private void Tv_Story_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
