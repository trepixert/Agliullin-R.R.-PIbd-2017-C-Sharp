using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsArmorAirCraft
{
    public partial class FormHangar : Form
    {
        Hangar<IArmorAirCraft> hangar;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<IArmorAirCraft>(20, pictureBoxMain.Width, pictureBoxMain.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxMain.Image = bmp;
        }

        private void buttonSetAirCraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var airCraft = new BaseArmorAirCraft(100, 1000, dialog.Color);
                int place = hangar + airCraft;
                Draw();
            }
        }

        private void buttonSetCoolAirCraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var airCraft = new AirCraft(100, 1000, dialog.Color, dialogDop.Color, true, true, Color.Black);
                    int place = hangar + airCraft;
                    Draw();
                }
            }
        }

        private void buttonGetCar_Click(object sender, EventArgs e)
        {
            if(maskedTextToGetIndex.Text != "")
            {
                var airCraft = hangar - Convert.ToInt32(maskedTextToGetIndex.Text);
                if (airCraft != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxRemoved.Width, pictureBoxRemoved.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    airCraft.SetPosition(40, 40, pictureBoxRemoved.Width, pictureBoxRemoved.Height);
                    airCraft.DrawArmorAirCraft(gr);
                    pictureBoxRemoved.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxRemoved.Width, pictureBoxRemoved.Height);
                    pictureBoxRemoved.Image = bmp;
                }
                Draw();
            }
        }
    }
}
