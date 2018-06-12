using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static LuisBot.Models.YogaOrder;

namespace LuisBot.Models
{
    public class MerchandiseDB
    {
        public static List<YogaPantOption> GetAllYogaPants()
        {
            return new List<YogaPantOption>() {
                new YogaPantOption(){ ProductName = "Ripped Warrior", Description="Featuring flatlocked comfort seaming, a strategically placed between-legs lined panel for better fit & comfort.", ProductImage="https://cdn.shopify.com/s/files/1/2185/2813/products/W5555R_00_1_87dc7cfc-46c5-414a-98bd-967e3d653c44_512x512.jpg?v=1523388712"},
                new YogaPantOption(){ ProductName = "Goddess", Description="Fit for a goddess like you. Features ultimate performance fabric that slims & lifts your best assets.", ProductImage="https://cdn.shopify.com/s/files/1/2185/2813/products/W5525R_024852_1_b06bdc1e-2902-40b8-80cf-852cf1c63394_512x512.jpg?v=1523402895"},
                new YogaPantOption(){ ProductName = "Seamless Radiance", Description="Moisture-wicking & antimicrobial, they come complete with body-mapped cutouts & higher waist to sculpt & shape.", ProductImage="https://cdn.shopify.com/s/files/1/2185/2813/products/W5615R_02506_2_4083b5d7-5f2d-44a1-aaee-2c879d02eeb3_512x512.jpg?v=1523404289"},
                new YogaPantOption(){ ProductName = "MotionLeggings", Description="Features engineered performance jacquard, so the pant moves with you while the sculpting pattern stays put.", ProductImage="https://cdn.shopify.com/s/files/1/2185/2813/products/w5515r_01599_1_3_1_512x512.jpg?v=1510689330"},
            };
        }
    }
}