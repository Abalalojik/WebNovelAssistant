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
            if (e.Node.Name == "tvnode_BasicsTitle")
            {
                gb_content.Controls.Clear();
                var custPan = new CustPanels.TitlePanel
                {
                    Dock = DockStyle.Fill
                };
                gb_content.Controls.Add(custPan);
            }

            if (e.Node.Name == "tvnode_BasicsLogline")
            {
                gb_content.Controls.Clear();
                var custPan = new CustPanels.LogLinePanel
                {
                    Dock = DockStyle.Fill
                };
                gb_content.Controls.Add(custPan);
            }
        }
    }


}
