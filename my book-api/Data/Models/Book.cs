﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book_api.Data.Models
{
    public class Book
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Isread { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Coverurl { get; set; } 
        public DateTime? DateAdded { get; set; } 
        
    }
}
