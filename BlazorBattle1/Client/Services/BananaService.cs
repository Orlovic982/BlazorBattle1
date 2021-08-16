using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattle1.Client.Services
{
    public class BananaService : IBananaService
    {
        public event Action OnChange;
        public int Bananas { get; set; } = 1000;

        public void EatBanans(int amount)
        {
            Bananas -= amount;
            BanansChange();
        }

        void BanansChange() => OnChange.Invoke();

       public void AddBanans(int amount)
        {

            Bananas += amount;
            BanansChange();

        }

    }



}
