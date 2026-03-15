using AvaloniaApplication1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace AvaloniaApplication1.ViewModels
{
    public partial class Page1ViewModel : ViewModelBase
    {
        private readonly CalculatorModel _calculator = new();

        [ObservableProperty]
        private string _display = "0";

        private double _firstNumber;
        private string _operation;

        [RelayCommand]
        private void Input(string value)
        {
            if (Display == "0")
            {
                Display = value;
            }
            else
            {
                Display += value;
            }
        }

        [RelayCommand]
        private void SetOperation(string operation)
        {
            _firstNumber = double.Parse(Display);
            _operation = operation;
            Display = "0";
        }

        [RelayCommand]
        private void ClearAll()
        {
            Display = "0";
            _firstNumber = 0;
            _operation = null;
        }

        [RelayCommand]
        private void ClearEntry()
        {
            Display = "0";
        }

        [RelayCommand]
        private void Calculate()
        {
            try
            {
                double secondNumber = double.Parse(Display);

                double result = _operation switch
                {
                    "+" => _calculator.Add(_firstNumber, secondNumber),
                    "-" => _calculator.Subtract(_firstNumber, secondNumber),
                    "*" => _calculator.Multiply(_firstNumber, secondNumber),
                    "/" => _calculator.Divide(_firstNumber, secondNumber),
                    _ => 0
                };

                Display = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                Display = ex.Message;
            }
        }

    }
}
