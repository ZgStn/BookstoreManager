using System.Windows;
using Bookstore.Domain;
using Bookstore_WPF_EF_ENG.ViewModel;

namespace Bookstore_WPF_EF_ENG.Windows
{
    /// <summary>
    /// Interaction logic for BookDetailsWindow.xaml
    /// </summary>
    public partial class BookDetailsWindow : Window
    {
        public BookDetailsWindow(Book book)
        {
            InitializeComponent();
            DataContext = new BookDetailsViewModel(book);
        }
    }
}
