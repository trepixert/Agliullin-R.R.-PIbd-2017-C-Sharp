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
        MultiLevelHangar hangar;
        private const int countLevel = 5;
        FormAirCraftConfig form;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new MultiLevelHangar(countLevel, pictureBox1.Width, pictureBox2.Height);
            for(int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень: " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangar[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBox1.Image = bmp;
            }
        }

        

        private void buttonGetCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    var airCraft = hangar[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
                    if (airCraft != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        airCraft.SetPosition(40, 40, pictureBox2.Width, pictureBox2.Height);
                        airCraft.DrawArmorAirCraft(gr);
                        pictureBox2.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        pictureBox2.Image = bmp;
                    }
                    Draw();
                }
            }
        }

        private void listBoxLevels_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Draw();
        }

        private void button_addAirCraft_Click(object sender, EventArgs e)
        {
            form = new FormAirCraftConfig();
            form.AddEvent(AddAirCraft);
            form.Show();
        }

        private void AddAirCraft(IArmorAirCraft airCraft)
        {
            if (airCraft != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = hangar[listBoxLevels.SelectedIndex] + airCraft;
                if (place > -1)
                    Draw();
                else
                    MessageBox.Show("Машину не удалось поставить!");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (hangar.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }


        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (hangar.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
