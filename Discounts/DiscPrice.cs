using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class DiscPrice
    {
        public static int Discount(int count, int AllSum)
        {
            float price = 0;
            if (count >= 3 && count < 5)
            {
                price /= AllSum * 0.95F;
            }
            else if (count >= 5 && count < 10)
            {
                price /= AllSum * 0.90F;
            }
            else if (count >= 10)
            {
                price /= AllSum * 0.85F;
            }
            int DisPrice = (int)Math.Floor(price);
            return DisPrice;
        }
    }
}
