using Avalonia.Svg.Skia;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AlertNotes.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Alert Notes!";
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(MenuWidth))]
    private bool _sideMenuExpanded = true;

    public int MenuWidth => _sideMenuExpanded ? 220 : 80;

    [RelayCommand]
    private void SideMenuResize() {
        SideMenuExpanded = !SideMenuExpanded;
    }
}
