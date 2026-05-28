using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
   class NutritionFact
    {
         private string foodName;
         private int calories;
         private double fat;
         private int carb;

        public NutritionFact()
        { 
            FoodName = string.Empty;
            calories = 0;
            fat = 0;
            carb = 0;
        }


        public string FoodName {
            get { return foodName; }
            set { foodName = value; }
        }

        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }
    }
}
