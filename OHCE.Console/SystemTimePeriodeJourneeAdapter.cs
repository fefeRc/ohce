using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console
{
    public class SystemTimePeriodeJourneeAdapter
    {
       public SystemTimePeriodeJourneeAdapter()
        {

        }

        public PériodeJournée PériodeJournée
        {
            get
            {
                 if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 12)
                {
                    return PériodeJournée.Matin;
                }
                else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 17)
                {
                    return PériodeJournée.AprèsMidi;
                }
                else if (DateTime.Now.Hour > 17 && DateTime.Now.Hour < 20)
                {
                    return PériodeJournée.Soir;
                }
                else
                {
                    return PériodeJournée.Nuit;
                }
            }
        }


    }
}
