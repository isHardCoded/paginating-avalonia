using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication1.ViewModels
{
    public partial class Page3ViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string text = "Это третья страница";
    }
}
