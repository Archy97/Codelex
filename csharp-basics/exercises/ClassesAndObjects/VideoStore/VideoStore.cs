using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public void CheckOut(string title)
        {
            _inventory.FirstOrDefault(book => book.Title == title)?.BeingCheckedOut();
        }

        public void ReturnVid(string title)
        {
            Video bookToCheckOut = _inventory.FirstOrDefault(book => book.Title == title);
            bookToCheckOut?.BeingCheckedOut();
        }

        public void ReceiveRating(string title, double rating)
        {
            Video videoToReturn = _inventory.FirstOrDefault(video => video.Title == title);
            videoToReturn?.BeingReturned();
        }

        public void DisplayLikedPercentage(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    double likedPercentage = (double)video.LikedCount / _inventory.Count * 100;
                    Console.WriteLine($"Percentage of users who liked '{title}': {likedPercentage}%");
                    return;
                }
            }

            Console.WriteLine($"Video '{title}' not found in inventory.");
        }

        public void ListInventory()
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                var video = _inventory[i];
                Console.WriteLine(video);
            }
        }
    }
}