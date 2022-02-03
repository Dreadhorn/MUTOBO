using Dreadhorn.Enums;
using Dreadhorn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreadhorn.Services
{
    public class DreadhornEasterEggService : IDreadhornEasterEggService
    {
        public ETimes GetTimePeriod()
        {
            DateTime Date = new DateTime();

            if (Date.Month == 9 && Date.Day == 12)
            {
                return ETimes.BDay;
            }
            if (Date.Month == 12)
            {
                return ETimes.Christmas;
            }

            return ETimes.Default;
        }
    }
}
