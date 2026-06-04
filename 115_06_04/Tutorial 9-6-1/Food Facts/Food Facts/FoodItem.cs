using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
   public class FoodItem
    {
        private string name;
        private double calories;
        private double fat;
        private double carb;

        // 建構子：初始化食物的各項數值
        public FoodItem(string name, double calories, double fat, double carb)
        {
            this.name = name;
            this.calories = calories;
            this.fat = fat;
            this.carb = carb;
        }

        // 唯讀屬性供其他類別存取（不允許外部直接修改）
        public string Name { get { return name; } }
        public double Calories { get { return calories; } }
        public double Fat { get { return fat; } }
        public double Carb { get { return carb; } }
    }
}
