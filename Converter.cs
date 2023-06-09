﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KingITProject.Tools
{
    public class Convertimg
    {
        /*
         * string path = "C:\\Users\\ccc27\\Downloads\\Image Сотрудники";
            foreach (string file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
            {
                using (var db = new PovillonsEntities())
                {
                   var i = db.Empoloys.Where(a => file.Contains(a.surname+" "+a.name+" "+a.middlename)).FirstOrDefault();
                    if (i != null)
                    {
                        i.photo = KingITProject.Tools.Convertimg.ImageToBytes(file);
                        db.SaveChanges();
                    }
                }
            }
         */
        public static byte[] ImageToBytes(string filePath)
        {
            byte[] photo = null;
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    photo = reader.ReadBytes((int)stream.Length);
                }
            }
            return photo;
        }

        public static BitmapImage BytesToImage(byte[] bytes)
        {
            BitmapImage image = null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
            }
            return image;
        }
    }
}