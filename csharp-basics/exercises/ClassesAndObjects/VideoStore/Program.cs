using System;

namespace VideoStore
{
    class Program
    {
        private static VideoStore _store;

        public static void Main(string[] args)
        {
            _store = new VideoStore();
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
                Console.WriteLine("Choose 5 to receive rating");
                

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        ReceiveRating();
                        break;
                    case 6:
                        RateVideo();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void RateVideo()
        {
            Console.Write("Enter the title of the video you want to rate: ");
            string title = Console.ReadLine();

            Console.Write("Enter your rating (1-10): ");
            double rating = Convert.ToDouble(Console.ReadLine());

            _store.ReceiveRating(title, rating);
            _store.DisplayLikedPercentage(title);
        }

        private static void ReceiveRating() 
        {
            _store.ReceiveRating("The Matrix", 8);
            _store.ReceiveRating("The Matrix", 9);
            _store.ReceiveRating("Godfather II", 10);
            _store.ReceiveRating("Godfather II", 9);
            _store.ReceiveRating("Star Wars Episode IV: A New Hope", 9);
            _store.ReceiveRating("Star Wars Episode IV: A New Hope", 8);
        }

        private static void ListInventory()
        {
            _store.ListInventory();
        }

        private static void FillVideoStore()
        {
            _store.AddVideo("The Matrix");
            _store.AddVideo("Godfather II");
            _store.AddVideo("Star Wars Episode IV: A New Hope");
        }

        private static void RentVideo()
        {
            string movieTitle = Console.ReadLine();
            _store.CheckOut(movieTitle);
            if (movieTitle == "Godfather II")
            {
                Console.WriteLine("Inventory after renting 'Godfather II':");
                _store.ListInventory();
            }
        }

        private static void ReturnVideo()
        {
            string movieTitle = Console.ReadLine();
            _store.ReturnVid(movieTitle);
        }
    }
}
