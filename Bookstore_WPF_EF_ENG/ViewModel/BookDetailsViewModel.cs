using System.Collections.ObjectModel;
using Bookstore.Domain;

namespace Bookstore_WPF_EF_ENG.ViewModel
{
    internal class BookDetailsViewModel
    {
        public ObservableCollection<Book> Books { get; set; } //TODO: vi har samma observablecollection i mainwindowviewmodel, blir det ett problem?
        public BookDetailsViewModel(Book book)
        {
            LoadBookDetails(book);
        }

        private void LoadBookDetails(Book book)
        {

        }
    }
}
