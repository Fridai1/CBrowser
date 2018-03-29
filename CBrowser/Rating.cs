using System.Collections.Generic;
using System.Linq;
using Android.Util;
using Org.Json;

namespace CBrowser
{
    public class Rating
    {
        private double _NewRating;
        private double _CurrentRating;
        private List<double> _RatingCollection;
        public Rating()
        {
            _RatingCollection = new List<double>();
        }

        public void NewRating(double rating)
        {
            if (rating != 0)
            {
                _NewRating = rating;
                _RatingCollection.Add(_NewRating);
            }


        }

        private void CalculateRating()
        {
            _CurrentRating = _RatingCollection.Average();
        }

        public double GetRating
        {
            get
            {
                CalculateRating();
                return _CurrentRating;
            }
        }
    }
}