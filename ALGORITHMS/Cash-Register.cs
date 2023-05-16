using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHMS
{
    internal class Cash_Register
    {
        public  int[] Register(int amount)
        {
            int _100 = 0;
            int _50 = 0;
            int _20 = 0;

            int[] result = new int[3];

            if ((amount % 100) % 20 != 0)
            {
                amount -= 50;
                _50++;
                _100 = amount / 100;
                amount %= 100;
                _20 = amount / 20;
            }
            else if (amount % 100 == 0)
            {
                _100 = amount / 100;
            }
            else if (amount > 100 && amount % 100 != 0)
            {
                if ((amount % 100) % 20 == 0)
                {
                    _100 = amount / 100;
                    amount %= 100;
                    _20 = amount / 20;
                }
            }
            else if (amount < 100 && amount % 20 != 0)
            {
                amount -= 50;
                _50++;
                _20 = amount / 20;
            }
            else if (amount < 100 && amount % 50 != 0)
            {
                _20 = amount / 20;
            }
            else if (amount < 100 && amount < 50)
            {
                _20 = amount / 20;
            }

            result = new int[3] { _100, _50, _20 };

            return result;
        }



    }
}
