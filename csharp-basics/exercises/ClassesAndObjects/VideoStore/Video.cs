using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private List<double> _ratings;

        public string Title { get; set; }
        public bool IsAvailable { get; set; }
        public int LikedCount { get; private set; }

        public Video(string title)
        {
            Title = title;
            IsAvailable = true;
            _ratings = new List<double>();
             LikedCount = 0;
        }

        public double AverageRating => _ratings.Any() ? _ratings.Average() : 0;

        public void BeingCheckedOut()
        {
            IsAvailable = false;
        }

        public void BeingReturned()
        {
            IsAvailable = true;
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
            return $"{Title}, rating: {AverageRating}, IsAvailable {IsAvailable}";
        }
    }
}