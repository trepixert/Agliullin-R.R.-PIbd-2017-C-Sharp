using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsArmorAirCraft
{
    public partial class FormHangar : Form
    {
        MultiLevelHangar hangar;
        private const int countLevel = 5;
        FormAirCraftConfig form;
        private Logger logger;
        private Logger errorsLogger;
        public FormHangar()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            hangar = new MultiLevelHangar(countLevel, pictureBoxMain.Width, pictureBoxRemoved.Height);
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
                Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangar[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxMain.Image = bmp;
            }
        }

        private void buttonGetCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    try
                    {
                        var airCraft = hangar[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
                        Bitmap bmp = new Bitmap(pictureBoxRemoved.Width, pictureBoxRemoved.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        airCraft.SetPosition(40, 40, pictureBoxRemoved.Width, pictureBoxRemoved.Height);
                        airCraft.DrawArmorAirCraft(gr);
                        pictureBoxRemoved.Image = bmp;
                        logger.Info("Изъят самолет " + airCraft.ToString() + " с места: " + maskedTextBox1.Text);
                        Draw();
                    }
                    catch (HangarNotFoundException ex)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxRemoved.Width, pictureBoxRemoved.Height);
                        pictureBoxRemoved.Image = bmp;
                        MessageBox.Show(ex.Message, "Не найден самолет", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Не найден самолет по месту: " + maskedTextBox1.Text);
                        Draw();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                try
                {
                    int place = hangar[listBoxLevels.SelectedIndex] + airCraft;
                    logger.Info("Добавлен самолет " + airCraft.ToString() + " на место: " + place);
                    Draw();
                }
                catch (HangarOverfowException ex)
                {
                    logger.Error("Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (HangarAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try {
                    hangar.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    logger.Error("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    hangar.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (HangarOccupiedPlaceException ex)
                {
                    logger.Error("Занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();

            }
        }

        private void button_SortClick_Click(object sender, EventArgs e)
        {
            hangar.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}