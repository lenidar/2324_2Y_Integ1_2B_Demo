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

namespace _2324_2Y_Integ1_2B_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] numPad = new Button[] { };
        int num1 = 0;
        int num2 = 0;
        int ope = -1;

        public MainWindow()
        {
            InitializeComponent();

            numPad = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9};

            for (int x = 0; x < numPad.Length; x++)
                numPad[x].Content = x;

            btnAdd.Content = "+";
            btnMin.Content = "-";
            btnMul.Content = "x";
            btnDiv.Content = "/";
            btnAns.Content = "=";
        }

        private void addNumbers(int num)
        {
            string thing = tbCalc.Text;
            thing += num;

            if (thing.Length > 5)
            {
                thing = thing.Substring(1);
            }

            if (ope == -1)
                num1 = int.Parse(thing);
            else
                num2 = int.Parse(thing);

            tbCalc.Text = thing;
        }

        #region Numbers
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(9);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(8);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(7);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(6);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(5);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(4);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(3);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(2);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(1);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            addNumbers(0);
        }
        #endregion

        #region Operations
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ope = 0;
            tbCalc.Text = "";
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            ope = 1;
            tbCalc.Text = "";
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            ope = 2;
            tbCalc.Text = "";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            ope = 3;
            tbCalc.Text = "";
        } 
        #endregion

        private void btnAns_Click(object sender, RoutedEventArgs e)
        {
            switch(ope) 
            {
                case 0:
                    num1 += num2;
                    break;
                case 1:
                    num1 -= num2;
                    break;
                case 2:
                    num1 *= num2;
                    break;
                case 3:
                    num1 /= num2;
                    break;
            }

            if (ope > -1)
            {
                tbCalc.Text = num1.ToString();
                ope = -1;
                num2 = 0;
            }
        }
    }
}
