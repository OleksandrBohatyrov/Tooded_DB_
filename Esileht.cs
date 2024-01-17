using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Esileht : Form
    {
        PictureBox pb_logo_pood;
        public Esileht()
        {
            InitializeComponent();
            Pildid();
        }
        private void Logi_sisse(object sender, EventArgs e)
        {           
            Login loginForm = new Login();
            loginForm.Show();

        }

        private void Pildid()
        {
            pb_logo_pood = new PictureBox();
            pb_logo_pood.Image = new Bitmap("../../ATB.png");
            pb_logo_pood.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_logo_pood.Location = new Point(170,12);
            pb_logo_pood.ClientSize = new Size(150, 150);

 

            Controls.Add(pb_logo_pood);

        }
    }
}
