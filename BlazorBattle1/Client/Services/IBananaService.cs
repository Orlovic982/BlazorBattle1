using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattle1.Client.Services
{
    public interface IBananaService
    {
        event Action OnChange;

        int Bananas { get; set; }
        void EatBanans(int amount);

        void AddBanans(int amount);

    }

}
