using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class Coin
    {
        Random rand = new Random(); 
        private string sideUp;

        public Coin()
        {
            sideUp = "Heads"; // 預設為正面朝上
        }

       
        public void Toss()
        {
            int side = rand.Next(2); 
            if (rand.Next(2) == 0)
            { 
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }


        // 取得目前硬幣面的方法
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
