using System;
using Android.Graphics.Drawables;
using Microsoft.Maui.Controls;
namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        double n1, n2, r = 0, mem ;
        string op = " ";
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(Calculator.Text);
            if (op == "+")
            {
                r = n1 + n2;
            }
            else if (op == "-")
            {
                r = n1 - n2;
            }
            else if(op == "x")
            {
                r = n1 * n2;
            }
            else if(op == "/")
            {
                  r = n1 / n2;
            }
            else if(op == "%")
            {
                r = n1 * n2 / 100;
            }
            Calculator.Text = r.ToString();
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Calculator.Text = Calculator.Text + btn.Text;
        }
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = btn.Text;
            n1 = Convert.ToDouble(Calculator.Text);
            Calculator.Text = "";
        }
        private void Button_Clicked_3(object sender, EventArgs e)
        {
           
            if(Calculator.Text.Length> 0)
            {
                Calculator.Text=Calculator.Text.Substring(0,Calculator.Text.Length-1);
            }
        }
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Calculator.Text = " ";
            n1 = 0;
            n2 = 0;
        }
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            if (Calculator.Text.IndexOf(".") == -1)
            {
                Calculator.Text += ".";
            }
        }
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            n1=Convert.ToDouble(Calculator.Text);
            r = -n1;
            Calculator.Text=r.ToString();
        }
        private void Button_Clicked_7(object sender, EventArgs e)
        {
            mem = 0;
        }
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            mem = mem+Convert.ToDouble(Calculator.Text);
        }
        private void Button_Clicked_9(object sender, EventArgs e)
        {
            mem = mem-Convert.ToDouble(Calculator.Text);
        }
        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Calculator.Text = mem.ToString();
        }
    }
}
