﻿using System.Collections.Generic;
using Library.Service.Models;
using Library.DB;
using Library.DB.EntityModels;

namespace Library.Service
{
    public class ReaderService
    {
        
        public bool? CheckInputData(UserDto userDto)
        {
            using (DataBaseContext dataBaseContext = new DataBaseContext())
            {
                foreach (var reader in dataBaseContext.Readers)
                {
                    var status = Equals(userDto, reader);

                    if (!status) continue;
                    if (reader.IsBanned) return null;
                    return true;
                }
            }
           
            return false;
        }

        public void CreateReader(string name, string surname, string middleName, string email,
            string phone, string rating, string password)
        {
            var inputData = new Reader()
            {
                Name = name,
                Surname = surname,
                MiddleName = middleName,
                Email = email,
                Phone = phone,
                Rating = rating,
                Password = CryptographyService.EncodeDecrypt(password),
            };

            using (var dataBaseContext = new DataBaseContext())
            {
                dataBaseContext.Readers.Add(inputData);
                dataBaseContext.SaveChanges();
            }
            
        }

        public void CreateReaders(List<Reader> readersList)
        {
            if (readersList == null)
            {
                return;
            }

            using (var dataBaseContext = new DataBaseContext())
            {
                dataBaseContext.Readers.AddRange(readersList);
                dataBaseContext.SaveChanges();
            }
        }

        public void EditReader(string name, string surname, string middleName, string email,
            string phone, string rating, string password, bool isBanned, Reader reader)
        {
            reader.Name = name;
            reader.Surname = surname;
            reader.MiddleName = middleName;
            reader.Email = email;
            reader.Rating = rating;
            reader.Phone = phone;
            reader.Password = CryptographyService.EncodeDecrypt(password);
            reader.IsBanned = isBanned;

            using (var dataBaseContext = new DataBaseContext())
            {
                dataBaseContext.SaveChanges();
            }
            
        }

        private static bool Equals(UserDto inputData, Reader reader)
        {
            return inputData.Email == reader.Email &&
                   inputData.Phone == reader.Phone &&
                   inputData.Password == CryptographyService.EncodeDecrypt(reader.Password);
        }
    }
}