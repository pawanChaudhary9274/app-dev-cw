using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Application_Development_Coursework
{
    class CriteriaModel
    {
        public string filepath = "Criteria.txt";        
        public string CriteriaName { get; set; }

        public string Save(string r )
        {
            string str = JsonConvert.SerializeObject(r, Formatting.None);
            Utility.WriteToText(filepath, str);
            return "success";
        }
    }
}
