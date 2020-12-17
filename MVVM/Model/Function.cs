using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestTask
{
    public class Function : INotifyPropertyChanged
    {
        private string title;
        private double variableA;
        private double variableB;
        private List<int> variableC;
        private double variableX;
        private int variableCNumber;
        private double variableY;


        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public double VariableA
        {
            get { return variableA; }
            set
            {
                if (variableA != value)
                {
                    variableA = value;
                    OnPropertyChanged("VariableA");
                    CalculateSum();
                }
            }
        }
        public double VariableB
        {
            get { return variableB; }
            set
            {
                if (variableB != value)
                {
                    variableB = value;
                    OnPropertyChanged("VariableB");
                    CalculateSum();
                }
            }
        }
        public List<int> VariableC
        {
            get { return variableC; }
            set
            {
                variableC = value;
                OnPropertyChanged("VariableC");
                CalculateSum();
            }
        }
        public double VariableX
        {
            get { return variableX; }
            set
            {
                if (variableB != value)
                {
                    variableX = value;
                    OnPropertyChanged("VariableX");
                    CalculateSum();
                }
            }
        }
        public int VariableCNumber
        {
            get { return variableCNumber; }
            set
            {
                variableCNumber = value;
                OnPropertyChanged("VariableCNumber");
                CalculateSum();
            }
        }
        public double VariableY
        {
            get { return variableY; }
            set
            {
                if (variableB != value)
                {
                    variableY = value;
                    OnPropertyChanged("VariableY");
                    CalculateSum();
                }
            }
        }
        public double Result
        {
            get; set;
        }


        /// <summary>
        /// метод вычеслиния f(x,y)
        /// </summary>
        public static double LinearFunction(double VariableA, double VariableB, int VariableCNumber, double VariableX, double VariableY)
            =>(VariableA * VariableX) + (VariableB * Math.Pow(VariableY, 0)) + VariableCNumber;

        public static double QuadraticFunction(double VariableA, double VariableB, int VariableCNumber, double VariableX, double VariableY)
            =>(VariableA * Math.Pow(VariableX, 2)) + (VariableB * Math.Pow(VariableY, 1)) + VariableCNumber;

        public static double СubicFunction(double VariableA, double VariableB, int VariableCNumber, double VariableX, double VariableY)
            => (VariableA * Math.Pow(VariableX, 3)) + (VariableB * Math.Pow(VariableY, 2)) + VariableCNumber;

        public static double FourthDegreeFunction(double VariableA, double VariableB, int VariableCNumber, double VariableX, double VariableY)
            => (VariableA * Math.Pow(VariableX, 4)) + (VariableB * Math.Pow(VariableY, 3)) + VariableCNumber;

        public static double FifthDegreeFunction(double VariableA, double VariableB, int VariableCNumber, double VariableX, double VariableY)
            => (VariableA * Math.Pow(VariableX, 5)) + (VariableB * Math.Pow(VariableY, 4)) + VariableCNumber;

        private void CalculateSum()
        {
            switch (Title)
            {
                case "Линейная":
                    Result= LinearFunction(VariableA,VariableB,VariableCNumber,VariableX,VariableY);
                    OnPropertyChanged("Result");
                    break;
                case "квадратичная":
                    Result = QuadraticFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
                    OnPropertyChanged("Result");
                    break;
                case "кубическая":
                    Result = СubicFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
                    OnPropertyChanged("Result");
                    break;
                case "4-ой степени":
                    Result = FourthDegreeFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
                    OnPropertyChanged("Result");
                    break;
                case "5-ой степени":
                    Result = FifthDegreeFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
                    OnPropertyChanged("Result");
                    break;
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
