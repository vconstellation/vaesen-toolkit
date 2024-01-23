using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaesenToolkit.Middleware
{
    public abstract class RandomizeHelper
    {
        public static int GetRandomRecord(int listCount)
        {
            var random = new Random();
            int index = random.Next(listCount);
            return index;
        }
    }
}
