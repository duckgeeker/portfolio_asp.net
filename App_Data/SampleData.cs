using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.App_Data
{
    public class SampleData
    {
        public static void Initialize(PortfolioContext context)
        {
            if (!context.Works.Any())
            {
                context.Works.AddRange
                (
                    new Work
                    {
                        desc_short = "TEST: Banner for up2date",
                        desc_long = "",
                        tools = "Adobe Photoshop"
                    },                    
                    new Work
                    {
                        desc_short = "TEST: Banner for RomanD",
                        desc_long = "",
                        tools = "Adobe XD"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
