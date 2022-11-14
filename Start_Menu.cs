using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_of_Games
{
    public partial class Start_Menu : Form
    {
        public Start_Menu()
        {
            InitializeComponent();
        }

        private void UnoGame_Click(object sender, EventArgs e)
        {
            Uno uno = new Uno();
            uno.Show();
            Hide();
            
        }

        private void UnoGame_MouseHover(object sender, EventArgs e)
        {

        }

        private void UnoGame_MouseLeave(object sender, EventArgs e)
        {

        }

        
    }
}
