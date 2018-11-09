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
        private AirCraft airCraft;
        public FormAirCraft()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureAirCraft.Width, pictureAirCraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airCraft.DrawAirCraft(gr);
            pictureAirCraft.Image = bmp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            airCraft = new AirCraft(rnd.Next(1000, 3000), rnd.Next(5000, 10000), Color.Black, Color.Gray);
            airCraft.SetPosition(rnd.Next(100, 300), rnd.Next(100, 300), pictureAirCraft.Width, pictureAirCraft.Height);
            Draw();
        }


        private void pictureAirCraft_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "Up":
                    airCraft.moveAirCraft(Direction.Up);
                    break;
                case "Down":
                    airCraft.moveAirCraft(Direction.Down);
                    break;
                case "ToLeft":
                    airCraft.moveAirCraft(Direction.Left);
                    break;
                case "ToRight":
                    airCraft.moveAirCraft(Direction.Right);
                    break;
            }
            Draw();
        }

        
    }
}
