using System.Linq;
using System.Windows;
using Library.DB;

namespace Library.UI.ReaderWindows
{
    public partial class BookListWindow : Window
    {
        public BookListWindow()
        {
            InitializeComponent();

            using var dataBaseContext = new DataBaseContext();
            BookGrid.ItemsSource = dataBaseContext.Books.Where(b => b.IsBanned == false).ToList();
        }
    }
}