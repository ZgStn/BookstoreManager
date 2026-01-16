using System.Windows;
using Bookstore.Presentation.ViewModel;

namespace Bookstore.Presentation.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainWindowViewModel viewModel;
    public MainWindow()
    {
        InitializeComponent();
        DataContext = viewModel = new MainWindowViewModel();
    }

    
}