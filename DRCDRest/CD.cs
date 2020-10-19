﻿using System;
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
        private List<CD> _cder;

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

        
    }
}
