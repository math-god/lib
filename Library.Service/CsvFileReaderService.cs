﻿using System;
using System.Collections.Generic;
using System.IO;
using Library.Service;
using Library.DB.EntityModels;

namespace Library.Service
{
    public class CsvFileReaderService : FileReader
    {
        public override List<T> ReadFile<T>(string filename)
        {
            if (filename == null)
            {
                return new List<T>();
            }
            using (StreamReader streamReader = new StreamReader(filename))
            {
                try
                {
                    if (IsFileEmpty(streamReader))
                    {
                        throw new Exception();
                    }

                    var records = GetRecords(streamReader);
                    return (List<T>) records;
                }
                catch (Exception)
                {
                    /*MessageBox.Show("Файл пуст или содержит модель," +
                                    " которая не соответствует объекту \"Читатель\"");*/
                    return null;
                }
            }
        }

        private static IEnumerable<Reader> GetRecords(StreamReader streamReader)
        {
            var rawData = new List<string[]>();
            var outputData = new List<Reader>();

            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine()?.Split(',');
                rawData.Add(line);
            }

            foreach (var rawString in rawData)
            {
                var entity = new Reader()
                {
                    Name = rawString[0],
                    Surname = rawString[1],
                    MiddleName = rawString[2],
                    Email = rawString[3],
                    Phone = rawString[4],
                    Rating = rawString[5],
                    Password =  CryptographyService.EncodeDecrypt(rawString[6]),
                };
                outputData.Add(entity);
            }

            return outputData;
        }
    }
}