﻿namespace _06BookLibraryModification
{
    using System;
    using System.Globalization;

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBN { get; set; }

        public double Price { get; set; }
    }
}