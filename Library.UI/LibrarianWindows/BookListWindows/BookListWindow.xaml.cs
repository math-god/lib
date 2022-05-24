using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Library.Service;
using Library.DB;
using Library.DB.EntityModels;

namespace Library.UI.LibrarianWindows.BookListWindows
{
    public partial class BookListWindow : Window
    {
        public BookListWindow()
        {
            InitializeComponent();

            using (var dataBaseContext = new DataBaseContext())
            {
                BookGrid.ItemsSource = dataBaseContext.Books.ToList();
            }
        }

        private void GoToBookDescriptionWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var bookDescriptionWindow = new BookDescriptionWindow((sender as Button)?.DataContext as Book);
            bookDescriptionWindow.ShowDialog();
            if (bookDescriptionWindow.DialogResult == true)
            {
                using var dataBaseContext = new DataBaseContext();
                BookGrid.ItemsSource = dataBaseContext.Books.ToList();
            }
        }

        private void GoToAddingBookWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var addingBookWindow = new AddingBookWindow();
            addingBookWindow.ShowDialog();
            if (addingBookWindow.DialogResult == true)
            {
                using var dataBaseContext = new DataBaseContext();
                BookGrid.ItemsSource = dataBaseContext.Books.ToList();
            }
        }

        private void GoToEditingBookWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var editingBookWindow = new EditingBookWindow((sender as Button)?.DataContext as Book);
            editingBookWindow.ShowDialog();
            if (editingBookWindow.DialogResult == true)
            {
                using var dataBaseContext = new DataBaseContext();
                BookGrid.ItemsSource = dataBaseContext.Books.ToList();
            }
        }

        private void GoToAddingBookByIsbn_OnClick(object sender, RoutedEventArgs e)
        {
            var addingBookByIsbnWindow = new AddingBookByIsbnWindow();
            addingBookByIsbnWindow.ShowDialog();
            if (addingBookByIsbnWindow.DialogResult == true)
            {
                using var dataBaseContext = new DataBaseContext();
                BookGrid.ItemsSource = dataBaseContext.Books.ToList();
            }
        }
    }
}