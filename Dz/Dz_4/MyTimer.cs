using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_4
{
    internal class MyTimer
    {
        public event Action OnTimeElapsed;
        public async void Start(int seconds) 
        {
            if (seconds < 0)
            {
                throw new ArgumentException("Seconds cannot be negative.");
            }
            await Task.Delay(seconds * 1000) ;
            OnTimeElapsed?.Invoke();
        }
        //async, await, Это все с помощью гпт, сам я незнал как сделать таймер, хотя теперь впринципе разобрался на будущее
    }
}
