using PsychologicalTest.viewmodel;
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

        LuckyNumberViewModel LuckyNumberViewModel = new LuckyNumberViewModel();
        public LuckyNumberPage()
        {
            
            InitializeComponent();
            BindingContext = LuckyNumberViewModel;
        }
    }
}