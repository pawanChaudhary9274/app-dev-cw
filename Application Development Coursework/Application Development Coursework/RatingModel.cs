using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Development_Coursework
{
    public class RatingModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Dictionary<String, String> criterias { get; set; }
        public DateTime RatedTime { get; set; }
        
        

        string _path = "Review.txt";
        public string SaveReview(RatingModel data)
        {
            string str = JsonConvert.SerializeObject(data, Formatting.None);
            Utility.WriteToTextFile(_path, str);
            return "success";
            
        }
        public List<RatingModel>List()
        {
            string d = Utility.ReadFromTextFile(_path);
            List<RatingModel> ratings = JsonConvert.DeserializeObject<List<RatingModel>>(d);
            return ratings;
        }


    }
}
