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
    public partial class FormAirCraftConfig : Form
    {
        private event airCraftDelegate eventAddAirCraft;
        IArmorAirCraft airCraft = null;
        public FormAirCraftConfig()
        {
            InitializeComponent();
            panel_Black.MouseDown += panelColor_MouseDown;
            panel_Blue.MouseDown += panelColor_MouseDown;
            panel_Gray.MouseDown += panelColor_MouseDown;
            panel_Green.MouseDown += panelColor_MouseDown;
            panel_Orange.MouseDown += panelColor_MouseDown;
            panel_Red.MouseDown += panelColor_MouseDown;
            panel_White.MouseDown += panelColor_MouseDown;
            panel_Yellow.MouseDown += panelColor_MouseDown;
            button_cancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawAirCraft()
        {
            if (airCraft != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirCraft.Width, pictureBoxAirCraft.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airCraft.SetPosition(5, 40, pictureBoxAirCraft.Width, pictureBoxAirCraft.Height);
                airCraft.DrawArmorAirCraft(gr);
                pictureBoxAirCraft.Image = bmp;
            }
                
        }

        public void AddEvent(airCraftDelegate ev)
        {
            if (eventAddAirCraft == null)
                eventAddAirCraft = new airCraftDelegate(ev);
        }

        private void labelBaseAirCraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelBaseAirCraft.DoDragDrop(labelBaseAirCraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelAirCraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirCraft.DoDragDrop(labelAirCraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelAirCraft_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelAirCraft_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолет":
                    airCraft = new BaseArmorAirCraft(100, 500, Color.White);
                    break;
                case "Модернизированный самолет":
                    airCraft = new AirCraft(100, 500, Color.White, Color.Gray, true, true, Color.Black);
                    break;
            }
            DrawAirCraft();
        }

        private void MainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (airCraft != null)
            {
                airCraft.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAirCraft();
            }
        }

        private void DopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (airCraft != null)
            {
                if(airCraft is AirCraft)
                {
                    (airCraft as AirCraft).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAirCraft();
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            airCraftDelegate airCraft_Delegate = delegate(IArmorAirCraft airCraft) {
                eventAddAirCraft?.Invoke(airCraft);
            };
            airCraft_Delegate(airCraft);
            Close();
        }
    }
}
