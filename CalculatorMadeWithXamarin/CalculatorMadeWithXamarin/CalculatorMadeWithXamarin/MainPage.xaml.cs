using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Arithmetic_evaluator;

namespace CalculatorMadeWithXamarin
{
	public partial class MainPage : ContentPage
	{
        string text;
        public string Text { get { return text; } set { text = value; OperationResult.Text = Text; } }

        public MainPage()
        {
            InitializeComponent();
            Text = "";

            
        }
        public void AddSymbol(object sender, EventArgs e)
        {

            var click = (Button)sender;
            if (click.Text == "DEL")
            {
                Text = "";
            }
            else if (click.Text == "=")
            {
                try
                {
                    Text = Parser.Evaluator(Text).ToString();
                }
                catch (Exception err)
                {

                    Text = err.ToString();
                }
            }
            else
            {
                Text += click.Text;
            }

        }
        public double Result()
        {


            return 0;
        }


    }
}
