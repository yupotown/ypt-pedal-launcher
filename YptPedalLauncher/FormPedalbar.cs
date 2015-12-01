using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YptPedalLauncher
{
    public partial class FormPedalbar : Form
    {
        public FormPedalbar()
        {
            InitializeComponent();
        }

        private int screenW, screenH;

        private void FormPedalbar_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap("img/pedalbar.png");
            var transKey = Color.White;
            bmp.MakeTransparent(transKey);
            this.BackgroundImage = bmp;

            screenW = Screen.PrimaryScreen.WorkingArea.Width;
            screenH = Screen.PrimaryScreen.WorkingArea.Height;
            this.Size = bmp.Size;
            this.SetDesktopLocation((screenW - bmp.Width) / 2, screenH - bmp.Height);
        }
    }
}
