using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychologicalTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LuckyNumberPage : ContentPage
    {
        string _number1, _number2, _number3, _number4, _number5, _number6;
        public string number1
        {
            get => _number1;
            set
            {
                _number1 = value;
                OnPropertyChanged(nameof(number1));
            }
        }
        public string number2
        {
            get => _number2;
            set
            {
                _number2 = value;
                OnPropertyChanged(nameof(number2));
            }
        }
        public string number3
        {
            get => _number3;
            set
            {
                _number3 = value;
                OnPropertyChanged(nameof(number3));
            }
        }
        public string number4
        {
            get => _number4;
            set
            {
                _number4 = value;
                OnPropertyChanged(nameof(number4));
            }
        }
        public string number5
        {
            get => _number5;
            set
            {
                _number5 = value;
                OnPropertyChanged(nameof(number5));
            }
        }
        public string number6
        {
            get => _number6;
            set
            {
                _number6 = value;
                OnPropertyChanged(nameof(number6));
            }
        }

        
        //PropertyChanged(this, new PropertyChangedEventArgs(nameof(Email)));
        public LuckyNumberPage()
        {
            
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] numberArr = new int[6];
            for (int i = 0; i < 6; i++)
            {
                numberArr[i] = r.Next(1, 45);
                for(int ii=0; ii<i; ii++)
                {
                    System.Diagnostics.Debug.WriteLine(numberArr[i]);
                }
            }
            number1 = "ball_" + numberArr[0];
            number2 = "ball_" + numberArr[1];
            number3 = "ball_" + numberArr[2];
            number4 = "ball_" + numberArr[3];
            number5 = "ball_" + numberArr[4];
            number6 = "ball_" + numberArr[5];

        }
    }
}