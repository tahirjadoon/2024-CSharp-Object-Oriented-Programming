using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P024.Excercise.Generics_1
{
    public class Movie<TRate, UDate>
    {
        private string _movieName;

        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }

        private string _director;

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        private UDate _releaseDate;

        public UDate ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        private TRate _rate;

        public TRate Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}
