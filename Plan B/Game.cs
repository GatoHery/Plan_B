using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plan_B
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            Hearts1.Image = imageListHearts.Images[0]; 
            Hearts2.Image = imageListHearts.Images[0];
            Hearts3.Image = imageListHearts.Images[0];
        }
        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {    
          Hearts1.Image = imageListHearts.Images[1];
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
          Hearts3.Image = imageListHearts.Images[1]; 
        }
    }
}
