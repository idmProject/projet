using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using System.Net;
using System.IO;
using System.Net.Cache;
using System.Text.RegularExpressions;

namespace IDM2
{
    /// <summary>
    /// Utiliser seulement pour des tests
    /// </summary>
    public class Test
    {
        private const int YEAR = 2015;
        private const int MONTH = 08;


        private DateTime _date;
        private DateTime _realDate;

        private DateTime DeterminerSeconde()
        {
            DateTime last = Contexte.Bd.Connexion.OrderByDescending(c => c.LastConnexion).First().LastConnexion;
            int seconde = last.Second;
            int minute = last.Minute;
            int hour = last.Hour;
            int day = last.Day;

            if (seconde >= 59)
            {
                seconde = 1;
                minute += 1;
                if (minute >= 59)
                {
                    minute = 1;
                    hour += 1;
                    if (hour >= 23)
                        hour = 1;
                }
                else minute += 1;
            }
            else
                seconde += 1;
            return new DateTime(YEAR, MONTH, 28, hour, minute, seconde);
        }

        public Test()
        {
            _date = DeterminerSeconde();
        }



        public DateTime Date { get { return _date; } set { _date = value; } }
        public DateTime RealDate { get { return _realDate; } set { _date = value; } }
    }
}
