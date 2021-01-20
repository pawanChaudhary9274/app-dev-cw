using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CourseWorkTrial
{
    class Review
    {
        private string _filepath = "Review.csv";        

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string RestaurantName { get; set; }
        public string OrderID { get; set; }
        public int FoodQuality { get; set; }
        public int StaffFriendliness { get; set; }
        public int Cleanliness { get; set; }
        public int OrderAccuracy { get; set; }
        public int RestaurantAmbiance { get; set; }
        public int ValueForMoney { get; set; }
        public DateTime DateOfReview { get; set; }

        public string Save(Review r, string _filepath = "Review.csv")
        {
            string str = JsonConvert.SerializeObject(r, Formatting.None);
            Utility.WriteToTextFile(_filepath, str);
            return "success";
        }

        public List<Review> List(string _filepath = "Review.csv")
        {
            string d = Utility.ReadFromTextFile(_filepath);

            if (d != null)
            {
                List<Review> lst = JsonConvert.DeserializeObject<List<Review>>(d);
                return lst;

            }
            return null;

        }
    }
}
