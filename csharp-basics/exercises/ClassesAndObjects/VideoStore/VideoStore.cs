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
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (_inventory[i].Title == title)
                {
                    _inventory[i].BeingCheckedOut();
                    break;
                }
            }
        }

        public void ReturnVid(string title)
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (_inventory[i].Title == title)
                {
                    _inventory[i].BeingReturned();
                    break;
                }
            }
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