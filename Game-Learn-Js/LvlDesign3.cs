using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Learn_Js
{
    public partial class LvlDesign3 : Form
    {
        public LvlDesign3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LvLfisign_2 lvLfisign_2 = new LvLfisign_2();
            lvLfisign_2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/tvc/source/repos/Game-Learn-Js/ArenaWar-c-sharp-master/Part1-4/AreneWar.sln");
        }
    }
}
