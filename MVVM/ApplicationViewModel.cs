using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Function selectedFunction;
        public ObservableCollection<Function> Functions { get; set; }
        public double ResultAuto;
        public List<int> Numbers;
 
        public Function SelectedFunction
        {
            get { return selectedFunction; }
            set
            { 
                selectedFunction = value;
                OnPropertyChanged("SelectedFunction");
            }
        }
        

        public ApplicationViewModel()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5 };
            Functions = new ObservableCollection<Function>
            {
                
                new Function {Title="Линейная",VariableC=Numbers},
                new Function {Title="квадратичная"},
                new Function {Title="кубическая"},
                new Function {Title="4-ой степени"},
                new Function {Title="5-ой степени"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
