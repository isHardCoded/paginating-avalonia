using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication1.ViewModels
{
    public partial class Page1ViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string text = "Это первая страница";
    }
}
