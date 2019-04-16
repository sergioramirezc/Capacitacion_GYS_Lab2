using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab1.ViewModels
{
    public class MainViewModel : BindableObject
    {
        public ICommand TapCommand { get; set; }

        private string _calcValue;

        public string CalcValue
        {
            get { return _calcValue; }
            set
            {
                _calcValue = value;
                OnPropertyChanged("CalcValue");
            }
        }

        public MainViewModel()
        {
            TapCommand = new Command<string>((value) => OnTap(value));
        }

        private void OnTap(string value)
        {
            CalcValue += value;
        }

    }
}
