﻿using System;
using System.Collections.Generic;

namespace Books.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? NumberofPages { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}
