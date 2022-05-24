using Library.Service.Models;
using Library.DB;
using Library.DB.EntityModels;

namespace Library.Service
{
    public class BookService
    {
        private ImageService _imageService = new ImageService();
        private IsbnService _isbnService = new IsbnService();

        public void CreateBook(BookDto bookDto)
        {
            var inputData = new Book()
            {
                Title = bookDto.Title,
                Genre = bookDto.Genre,
                Author = bookDto.Author,
                PublicationDate = bookDto.PublicationDate,
                Description = bookDto.Description,
                Isbn = bookDto.Isbn
            };

            using (var dataBaseContext = new DataBaseContext())
            {
                dataBaseContext.Books.Add(inputData);
                dataBaseContext.SaveChanges();
            }
        }

        public void EditBook(string name, string genre, string author, string publicationYear,
            string description, string coverPreviewFilename, string isbn, bool isBanned, Book book)

        {
            book.Title = name;
            book.Genre = genre;
            book.Author = author;
            book.PublicationDate = publicationYear;
            book.Description = description;
            book.CoverPreview = _imageService.EncodeImage(coverPreviewFilename);
            book.Isbn = isbn;
            book.IsBanned = isBanned;

            using (var dataBaseContext = new DataBaseContext())
            {
                dataBaseContext.SaveChanges();
            }
        }
        
        public void CreateBookByIsbn(string Isbn)
        {
            var bookDto = _isbnService.GetBook(Isbn);

            var inputData = new Book()
            {
                Title = bookDto.Title,
                Genre = bookDto.Genre,
                Author = bookDto.Author,
                PublicationDate = bookDto.PublicationDate,
                Description = bookDto.Description,
                Isbn = bookDto.Isbn
            };

            using (var dataBaseContext = new DataBaseContext())
            {
                dataBaseContext.Books.Add(inputData);
                dataBaseContext.SaveChanges();
            }
        }
    }
}