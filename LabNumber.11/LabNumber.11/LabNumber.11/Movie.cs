using System;
using System.Collections.Generic;
using System.Text;

namespace LabNumber._11
{
    public class Movie
    {
        private string _title;
        private string _catagory;

        public string Title { get { return _title; } }
        public string Catagory { get { return _catagory; } }

        public Movie(string title, string catagory)
        {
            _title = title;
            _catagory = catagory;
        }
    }
}
