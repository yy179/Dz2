using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Que
    {
        private Queue<string> buyers = new Queue<string>();
        public void AddBuyer(string buyer) { buyers.Enqueue(buyer); }
        public void Maintenance() { Console.WriteLine(buyers.Dequeue()); }
        public void BuyersCount() { Console.WriteLine($"Buyers count in queue: {buyers.Count}"); }
    }
}
