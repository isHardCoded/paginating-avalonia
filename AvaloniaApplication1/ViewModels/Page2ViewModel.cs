using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication1.ViewModels
{
    public partial class Page2ViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string text = "Это вторая страница";
    }
}
