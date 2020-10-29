using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRCDRest
{
    public class CD
    {
        private int _ID;
        private string _title;
        private string _artist;
        private double _duration;
        private int _NumberOfTracks;
        private int _yearOfPublication;

        public CD()
        {

        }

        public CD(int id, string title, string artist, double duration, int numberOfTracks, int yearOfPublication)
        {
            ID = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            NumberOfTracks = numberOfTracks;
            YearOfPublication = yearOfPublication;
        }
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public double Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int NumberOfTracks
        {
            get { return _NumberOfTracks; }
            set { _NumberOfTracks = value; }
        }

        public int YearOfPublication
        {
            get { return _yearOfPublication; }
            set { _yearOfPublication = value; }
        }
    }
}
