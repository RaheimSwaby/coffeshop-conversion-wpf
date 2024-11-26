using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeshop_conversion
{
    public static class Datasource
    {
        // Static list to store coffee beverages
        public static List<Coffee> Beverages { get; set; } = new List<Coffee>();

        // Method to populate the beverage list
        public static void CreateData()
            
            {
                Beverages.Add(new Coffee { BrewStrength = BrewStrength.Mild, Roast = Roast.Dark, Temp = Temp.Hot, InStock = true, Size = "Medium", name = "Espresso", BeveragePrice = 2.99 });
                Beverages.Add(new Coffee { BrewStrength = BrewStrength.Strong , Roast = Roast.Medium, Temp = Temp.Iced, InStock = false, Size = "Large", name = "Latte", BeveragePrice = 3.99 });
                Beverages.Add(new Coffee { BrewStrength = BrewStrength.Balanced, Roast = Roast.Light, Temp = Temp.Warm, InStock = true, Size = "Small", name = "Cappuccino", BeveragePrice = 3.49 });
            }
        }
        
}


