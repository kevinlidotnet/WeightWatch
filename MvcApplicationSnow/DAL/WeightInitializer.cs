using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplicationSnow.Models;

namespace MvcApplicationSnow.DAL
{
    public class WeightInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SnowContext>
    {
         protected override void Seed(SnowContext context)
        {
            var weights = new List<Weight>
            {
                new Weight{WeightID=1,FieldA="1",FieldB = "200"} 
            };

            weights.ForEach(s => context.Weights.Add(s));
            context.SaveChanges(); 
    }
}
    }
