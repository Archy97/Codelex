using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private List<double> _ratings;

        public string Title { get; private set; }
        private bool _isAvailable;
        public int LikedCount { get; private set; }

        public Video(string title)
        {
            Title = title;
            _isAvailable = true;
            _ratings = new List<double>();
             LikedCount = 0;
        }

        public double AverageRating => _ratings.Any() ? _ratings.Average() : 0;

        public void BeingCheckedOut()
        {
            _isAvailable = false;
        }

        public void BeingReturned()
        {
            _isAvailable = true;
        }

        public void ReceiveRating(double rating)
        {
            _ratings.Add(rating);
            if (rating >= 7.0)
            {
                LikedCount++;
            }
        }

        public override string ToString()
        {
            return $"{Title}, rating: {AverageRating}, IsAvailable {_isAvailable}";
        }
    }
}