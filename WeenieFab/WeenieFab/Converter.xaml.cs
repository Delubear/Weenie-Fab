﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WeenieFab.Properties;

namespace WeenieFab
{
    /// <summary>
    /// Interaction logic for Converter.xaml
    /// </summary>
    public partial class Converter : Window
    {
        public Converter()
        {
            InitializeComponent();
            tbConvertFilePath.Text = WeenieFabUser.Default.DefaultSqlPath;
        }

        private void btnJsonFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Select JSON Files to Convert";
            ofd.Filter = "JSON files|*.json";
            ofd.InitialDirectory = WeenieFabUser.Default.DefaultJsonPath;
            Nullable<bool> result = ofd.ShowDialog();

            if (result == true)
            {
                foreach (String filename in ofd.FileNames)
                {
                    tbJsonFiles.Text += filename + "\r\n";
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string jsonConvertFiles = tbJsonFiles.Text;
            string[] tempJsonFiles = jsonConvertFiles.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            int c = 0;
            foreach (var fileLine in tempJsonFiles)
            {
                c++;

                FileInfo jfileinfo = new FileInfo(fileLine);
                DirectoryInfo directoryInfo = new DirectoryInfo(tbConvertFilePath.Text);

                try
                {
                    ACDataLib.Converter.json2sql(jfileinfo, null, directoryInfo);
                }
                catch (Exception)
                {

                    
                }
                
            }
            MessageBox.Show($"{c} files were converted.");
        }
    }
}
