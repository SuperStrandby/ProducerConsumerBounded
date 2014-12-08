using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdConBounded
{
    class Program
    {
        static void Main(string[] args)
        {
            BoundedBuffer buffer = new BoundedBuffer(10);
            Consumer con = new Consumer(buffer, 20);
            Producer prod = new Producer(buffer, 20);

            Parallel.Invoke(prod.Run, con.Run);
        }
    }
}
