﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Storage.EntityModels
{
    [Table("Users")]
    public class Reader
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string Surname { get; set; }

        [Required] public string MiddleName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public string Rating { get; set; }

        public bool IsBanned { get; set; }
        
    }
}