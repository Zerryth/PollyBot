using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LuisBot.Models
{
    [Serializable]
    public class Drink : IEquatable<Drink>
    {
        public string DrinkName { get; set; } 
        public string Size { get; set; } = "Grande";
       // public string Milk { get; set; } = "2% Milk";
        // public string Syrup { get; set; } = "No Syrup";
        // public int Price { get; set; } = 5;
        // public string DrinkOwner { get; set; }

        public override string ToString()
        {
            //return $"[{Size} {DrinkName} with {Milk}, {Syrup}]";
            return $"[{Size} {DrinkName}]";
        }

        public bool Equals(Drink other)
        {
            return other != null
                && this.DrinkName == other.DrinkName
                && this.Size == other.Size;
                //&& this.Milk == other.Milk;
        }

        public override bool Equals(object other)
        {
            return Equals(other as Drink);
        }

        public override int GetHashCode()
        {
            return this.DrinkName.GetHashCode();
        }

    }
}