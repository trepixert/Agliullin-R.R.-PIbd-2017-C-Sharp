using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class MultiLevelHangar
    {
        List<Hangar<IArmorAirCraft>> hangarStages;
        private const int countPlaces = 2;
        private int pictureWidth;
        private int pictureHeight;

        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<IArmorAirCraft>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                hangarStages.Add(new Hangar<IArmorAirCraft>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Hangar<IArmorAirCraft> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < hangarStages.Count)
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    WriteToFile("CountLevels:" + hangarStages.Count + Environment.NewLine, fs);
                    foreach (var level in hangarStages)
                    {
                        WriteToFile("Level:" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            try
                            {
                                var airCraft = level[i];
                                if (airCraft.GetType().Name.Equals("BaseArmorAirCraft"))
                                    WriteToFile(i + ":BaseArmorAirCraft:", fs);
                                if (airCraft.GetType().Name.Equals("AirCraft"))
                                    WriteToFile(i + ":AirCraft:", fs);
                                WriteToFile(airCraft + Environment.NewLine, fs);
                            }
                            finally { }
                        }
                    }
                }
            }
            return true;
        }

        public void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool LoadData(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                        bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLevels"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (hangarStages != null)
                    hangarStages.Clear();
                hangarStages = new List<Hangar<IArmorAirCraft>>(count);
            }
            else
                throw new Exception("Неверный формат файла");
            int counter = -1;
            IArmorAirCraft armorAirCraft = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i].Equals("Level:"))
                {
                    //начинаем новый уровень
                    counter++;
                    hangarStages.Add(new Hangar<IArmorAirCraft>(countPlaces, pictureWidth,
                    pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                    continue;
                if (strs[i].Split(':')[1].Equals("BaseArmorAirCraft"))
                    armorAirCraft = new BaseArmorAirCraft(strs[i].Split(':')[2]);
                else if (strs[i].Split(':')[1].Equals("AirCraft"))
                    armorAirCraft = new AirCraft(strs[i].Split(':')[2]);
                hangarStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = armorAirCraft;
            }   
            return true;
        }
    }
}
