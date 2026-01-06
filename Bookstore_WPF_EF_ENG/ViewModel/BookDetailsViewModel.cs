using System.Collections.ObjectModel;
using Bookstore.Domain;
using Bookstore.Infrastructure.Data.Model;

namespace Bookstore_WPF_EF_ENG.ViewModel
{
    internal class BookDetailsViewModel
    {
        public ObservableCollection<Inventory> Details { get; set; } //TODO: vi har samma observablecollection i mainwindowviewmodel, blir det ett problem?
        public BookDetailsViewModel(Inventory inventory)
        {
            LoadQuantity(inventory.Quantity);
        }

        private void LoadQuantity(int quantity)
        {
            using var db = new BookstoreContext();

            Details = new ObservableCollection<Inventory>(
                db.Inventories.Where(i => i.Quantity == quantity).ToList()
                );
        }
    }
}
