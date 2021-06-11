using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Inventory
{
    class DataRead
    {
      
        public void GetData()
        {
            var json = File.ReadAllText(@"E:\BridgeLabz\Data_Inventory_Management\DataInventoryManagement\Data_Inventory\Data_Inventory\Details.json");
            var jObject = JObject.Parse(json);
            if (jObject != null)
            {              
                var rice = jObject["Rice"];
                Console.WriteLine("name of rice is:" + rice["Name"]);
                Console.WriteLine("weight of rice is:" + rice["Weight"]);
                Console.WriteLine("Price per kg of rice:" + rice["Price_per_kg"]);               
                var wheat = jObject["Wheat"];
                Console.WriteLine("name of wheat is:" + wheat["Name"]);
                Console.WriteLine("weight of wheat is:" + wheat["Weight"]);
                Console.WriteLine("Price per kg of wheat" + wheat["Price_per_kg"]);
                var pulses = jObject["Pulses"];
                Console.WriteLine("name of pulses is:" + pulses["Name"]);
                Console.WriteLine("weight of pulses is:" + pulses["Weight"]);
                Console.WriteLine("Price per kg of pulses" + pulses["Price_per_kg"]);
            }

        }
        
    }
}
