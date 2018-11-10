using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsArmorAirCraft;

namespace WindowsArmorAirCraft
{
    public partial class FormAirCraft: Form
    {
        private IArmorAirCraft armorAirCraft;
        public FormAirCraft()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureAirCraft.Width, pictureAirCraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            armorAirCraft.DrawArmorAirCraft(gr);
            pictureAirCraft.Image = bmp;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            armorAirCraft = new BaseArmorAirCraft(rnd.Next(1000, 3000), rnd.Next(5000, 10000), Color.Gray);
            armorAirCraft.SetPosition(40, 40, pictureAirCraft.Width, pictureAirCraft.Height);
            Draw();
        }


        private void pictureAirCraft_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "Up":
                    armorAirCraft.MoveAirCraft(Direction.Up);
                    break;
                case "Down":
                    armorAirCraft.MoveAirCraft(Direction.Down);
                    break;
                case "ToLeft":
                    armorAirCraft.MoveAirCraft(Direction.Left);
                    break;
                case "ToRight":
                    armorAirCraft.MoveAirCraft(Direction.Right);
                    break;
            }
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            armorAirCraft = new AirCraft(rnd.Next(100,300), rnd.Next(1000,5000), Color.Gray, Color.Red, true, true, Color.Black);
            armorAirCraft.SetPosition(rnd.Next(100,500), rnd.Next(100,500), pictureAirCraft.Width, pictureAirCraft.Height);
            Draw();
        }
    }
}
