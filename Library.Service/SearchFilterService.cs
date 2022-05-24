using System.Collections.Generic;
using System.Linq;
using Library.DB;
using Library.DB.EntityModels;

namespace Library.Service
{
    public class SearchFilterService
    {

        public IEnumerable<Reader> SearchReader(string filter, string filterValue)
        {
            using var dataBaseContext = new DataBaseContext();
            var query = dataBaseContext.Readers as IQueryable<Reader>;

            if (filter == null)
                return dataBaseContext.Readers.ToList();

            switch (filter)
            {
                case "Имя":
                    if (!string.IsNullOrWhiteSpace(filterValue))
                    {
                        query = query?.Where(n => n.Name.Contains(filterValue));
                    }

                    break;
                case "Фамилия":
                    if (!string.IsNullOrWhiteSpace(filterValue))
                    {
                        query = query?.Where(s => s.Surname.Contains(filterValue));
                    }

                    break;
                case "Отчество":
                    if (!string.IsNullOrWhiteSpace(filterValue))
                    {
                        query = query?.Where(m => m.MiddleName.Contains(filterValue));
                    }

                    break;
                case "Телефон":
                    if (!string.IsNullOrWhiteSpace(filterValue))
                    {
                        query = query?.Where(p => p.Phone.Contains(filterValue));
                    }

                    break;
                case "Email":
                    if (!string.IsNullOrWhiteSpace(filterValue))
                    {
                        query = query?.Where(e => e.Email.Contains(filterValue));
                    }

                    break;
                case "Рейтинг":
                    if (!string.IsNullOrWhiteSpace(filterValue))
                    {
                        query = query?.Where(r => r.Rating.Contains(filterValue));
                    }

                    break;
            }


            return query.ToList();
        }
    }
}