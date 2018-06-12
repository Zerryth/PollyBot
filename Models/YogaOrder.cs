using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.FormFlow.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace LuisBot.Models
{
    [Serializable]
    public class YogaOrder
    {
        public YogaPantOption YogaPants { get; set; }

        public DeliveryOptions DeliveryMode { get; set; }

        [Prompt("What's your name?")]
        public string UserName { get; set; }

        [Prompt("Best number?")]
        public string Phone { get; set; }

        [Prompt("Where can these goodies find a new home? (Type or Say address)")]
        public string Address { get; set; }


        public static IForm<YogaOrder> BuildForm()
        {

            var allYogaPants = MerchandiseDB.GetAllYogaPants();

            var builder = new FormBuilder<YogaOrder>();

            builder
            .Message("Welcome to the yoga goodies shop!")
            .Field(new FieldReflector<YogaOrder>(nameof(YogaPants))
                .SetType(null)
                .SetFieldDescription("Yoga pant options")
                .SetDefine((state, field) =>
                {
                    foreach (var pants in allYogaPants)
                    {
                        field
                        .AddDescription(pants, new DescribeAttribute(title: pants.ProductName, description: pants.ProductName, subTitle: pants.Description, image: pants.ProductImage))
                        .AddTerms(pants, pants.ProductName);
                    }

                    return Task.FromResult(true);
                })
                .SetPrompt(new PromptAttribute("Select from the {&} \n {||} \n")
                {
                    ChoiceStyle = ChoiceStyleOptions.Carousel

                })
                .SetAllowsMultiple(false)
            )
            .AddRemainingFields()
            .OnCompletion(async (context, order) =>
            {
                await context.PostAsync("Excellent! Your order will make its way to you soon. Happy stretching!");
            });

            return builder.Build();
        }

        public enum DeliveryOptions
        {
            Express = 1,
            Standard
        }

        [Serializable]
        public class YogaPantOption
        {
            public string ProductName { get; set; }
            public string Description { get; set; }
            public string ProductImage { get; set; }
        }
    }
}