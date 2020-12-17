using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestTask
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
            List<int> Numbers1 = new List<int> { 10, 20, 30, 40, 50 };
            List<int> Numbers2 = new List<int> { 100, 200, 300, 400, 500 };
            List<int> Numbers3 = new List<int> { 1000, 200, 300, 400, 500 };
            List<int> Numbers4 = new List<int> { 10000, 20000, 30000, 40000, 50000 };
            Functions = new ObservableCollection<Function>
            {

                new Function {Title="Линейная",VariableC=Numbers},
                new Function {Title="квадратичная",VariableC=Numbers1},
                new Function {Title="кубическая",VariableC=Numbers2},
                new Function {Title="4-ой степени",VariableC=Numbers3},
                new Function {Title="5-ой степени",VariableC=Numbers4}
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
