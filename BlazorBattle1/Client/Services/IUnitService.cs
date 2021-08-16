using BlazorBattle1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattle1.Client.Services
{
    interface IUnitService
    {
        IList<Unit> Units { get;  }

        IList<UserUnit> MyUnits { get; set; }

        void AddUnit(int unitIt);

    }
}
