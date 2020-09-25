using PsychologicalTest.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PsychologicalTest.viewmodel
{
    class LuckyNumberViewModel : BindableObject, INotifyPropertyChanged
    {

        private LuckyNumberModel _numberModels = new LuckyNumberModel();
        public ICommand ClickEvent { get; set; }
        
        public LuckyNumberModel numberModels
        {
            get
            {
                return _numberModels;
            }
            set
            {
                _numberModels = value;
                OnPropertyChanged(nameof(numberModels));
            }
        }

        public LuckyNumberViewModel()
        {
            numberModels = new LuckyNumberModel();
            ClickEvent = new Command((e) => getNumber(e));

           
        }


        private void getNumber(object e)
        {
            var button = (string)e;

            Console.WriteLine(button);
            Random r = new Random();
            int[,] numberArr = new int[5,6];
            
            for (int i = 0; i < 5; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {
                    numberArr[i, ii] = r.Next(1, 45);
                    for(int iii = 0; iii < ii ; iii++)
                    {
                        if (numberArr[i, ii] == numberArr[i, iii])
                        {
                            ii--;
                            break;
                        }

                    }
                }
            }
           
            try
            {
                numberModels = (new LuckyNumberModel()
                {
                    number1_1 = "ball_" + numberArr[0, 0].ToString(),
                    number1_2 = "ball_" + numberArr[0, 1].ToString(),
                    number1_3 = "ball_" + numberArr[0, 2].ToString(),
                    number1_4 = "ball_" + numberArr[0, 3].ToString(),
                    number1_5 = "ball_" + numberArr[0, 4].ToString(),
                    number1_6 = "ball_" + numberArr[0, 5].ToString(),

                    number2_1 = "ball_" + numberArr[1, 0].ToString(),
                    number2_2 = "ball_" + numberArr[1, 1].ToString(),
                    number2_3 = "ball_" + numberArr[1, 2].ToString(),
                    number2_4 = "ball_" + numberArr[1, 3].ToString(),
                    number2_5 = "ball_" + numberArr[1, 4].ToString(),
                    number2_6 = "ball_" + numberArr[1, 5].ToString(),

                    number3_1 = "ball_" + numberArr[2, 0].ToString(),
                    number3_2 = "ball_" + numberArr[2, 1].ToString(),
                    number3_3 = "ball_" + numberArr[2, 2].ToString(),
                    number3_4 = "ball_" + numberArr[2, 3].ToString(),
                    number3_5 = "ball_" + numberArr[2, 4].ToString(),
                    number3_6 = "ball_" + numberArr[2, 5].ToString(),

                    number4_1 = "ball_" + numberArr[3, 0].ToString(),
                    number4_2 = "ball_" + numberArr[3, 1].ToString(),
                    number4_3 = "ball_" + numberArr[3, 2].ToString(),
                    number4_4 = "ball_" + numberArr[3, 3].ToString(),
                    number4_5 = "ball_" + numberArr[3, 4].ToString(),
                    number4_6 = "ball_" + numberArr[3, 5].ToString(),

                    number5_1 = "ball_" + numberArr[4, 0].ToString(),
                    number5_2 = "ball_" + numberArr[4, 1].ToString(),
                    number5_3 = "ball_" + numberArr[4, 2].ToString(),
                    number5_4 = "ball_" + numberArr[4, 3].ToString(),
                    number5_5 = "ball_" + numberArr[4, 4].ToString(),
                    number5_6 = "ball_" + numberArr[4, 5].ToString(),

                });

                Console.WriteLine(numberModels.number1_1);
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            

        }
    }
}
