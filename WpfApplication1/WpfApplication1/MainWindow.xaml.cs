﻿using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(IsInitialized)
            {
                double value = Math.Round(HeightSlider.Value, 1);
                HeightText.Text = value.ToString();
                Canvas.SetLeft(Height, value * 1.6);

                //bmi
                double h = double.Parse(HeightText.Text);
                double w = double.Parse(WeightText.Text);
                double bmi = w / Math.Pow((h / 100), 2);


                //SPLIT
                string[] parts = Math.Round(bmi, 1).ToString().Split('.');
                bminumber1.Text = parts[0];
                if (parts.Length > 1)
                {
                    bminumber2.Text = "." + parts[1];

                }
                else
                {
                    bminumber2.Text = ".0";
                }
            }
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value2 = Math.Round(WeightSlider.Value, 1);
            WeightText.Text = value2.ToString();

        }
    }
}
