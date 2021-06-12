using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Inventory
{
   public class DataRead
    {
      
        public void GetData()
        {
            var json = File.ReadAllText(@"E:\BridgeLabz\Data_Inventory_Management\DataInventoryManagement\Data_Inventory\Data_Inventory\Details.json");
            var jObject = JObject.Parse(json);
            var inventoryArray = (JArray)jObject["Inventory"];
            if (jObject != null)
            { 
                 Console.WriteLine("Inventories");
                    foreach (var item in inventoryArray)
                    {
                    Console.WriteLine($"Name:" + (item["Name"]));
                    Console.WriteLine($"Weight:" + (item["Weight"]));
                    Console.WriteLine($"price:" +(item["Price_per_kg"]));
                    TotalValue(item["Weight"], item["Price_per_kg"]);
                    Console.WriteLine();
                    }
            }
 
        }
        public void TotalValue(JToken Weight,JToken Price_per_kg)
        {
            int weight = Weight.ToObject<int>();
            int price = Price_per_kg.ToObject<int>();
            int total = weight * price;
            Console.WriteLine("Total value of the iteam is"+total);
        }


    }
}
