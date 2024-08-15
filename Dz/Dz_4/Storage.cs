using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dz_4
{
    internal class Storage<T>
    {
        private T item;
        public void SetItem(T item)
        {
            this.item = item;
        }
        public T GetItem() { return this.item; }
    }
}
