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
    public partial class nachalo_game_history : Form
    {
        public nachalo_game_history()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LvLdisign lvLdisign = new LvLdisign();
            lvLdisign.Show();
        }
    }
}
