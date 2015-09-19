using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psyTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://thepsyfamily.com/psy-counter-strike-global-offensive/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://thepsyfamily.com/psy-counter-strike-source/"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://thepsyfamily.com/psy-counter-strike-1-6/");
        
        }

        private void psySteamCommunityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/groups/psy");
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://thepsyfamily.com/index.php?page=page4115");
        }

        private void psyStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://play.thepsyfamily.com/stats/");
        }

        private void psyClanCommunityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/groups/psywars");
        }

        private void psyRUSTCommunityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/groups/psy-rust");
        }

        private void psyYoutubeChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC1hEU1HWfab5EsescSvNTaQ");
        }

        private void psyIRCChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://widget00.mibbit.com/?settings=1e88119d2e818f0c6994f864f5d487c8&server=irc.quakenet.org&channel=%23thepsyfamily");
        }

        private void psyTwitterPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/thepsyfamily");
        }

        private void psyFacebookPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/thepsyfamily");
        }

        private void psyFacebookGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/72973165041/");
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://thepsyfamily.com/index.php?action=register");
        }

        private void visitThePsyFamilycomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://thepsyfamily.com");
        }
    }
}
