using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ViewModelBase currentPage;

        public MainWindowViewModel()
        {
            currentPage = new Page1ViewModel();
        }

        [RelayCommand]
        private void GoPage1()
        {
            CurrentPage = new Page1ViewModel();
        }

        [RelayCommand]
        private void GoPage2()
        {
            CurrentPage = new Page2ViewModel();
        }

        [RelayCommand]
        private void GoPage3()
        {
            CurrentPage = new Page3ViewModel();
        }
    }
}
