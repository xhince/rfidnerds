using System;
using System.Collections.Generic;
using System.Text;

namespace XAML
{
    public class rfid
    {
        public string name { get; set; }
        public string uuid { get; set; }
        public string details { get; set; }
        public string ImageUrl { get; set; }
        static public string mert;

        public rfid(string name, string uuid, string details,string ImageUrl)
        {
            this.ImageUrl = ImageUrl;
            this.name = name;
            this.uuid = uuid;
            this.details = details;
            mert = "is awesome";
        
        
        } 
    }
}
