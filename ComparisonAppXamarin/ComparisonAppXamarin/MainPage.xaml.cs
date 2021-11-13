using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComparisonAppXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int _count = 0;
        private void ResetCounter(object sender, EventArgs e)
        {
            _count = 0;
            countLabel.Text = "Times Clicked " + _count.ToString();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            _count++;
            countLabel.Text = "Times Clicked " + _count.ToString();
        }
    }
}
