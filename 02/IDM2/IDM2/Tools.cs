using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDM2
{
    public class Tools
    {
        public static string GetMonth(int month)
        {

            switch (month)
            {
                case 1:
                    return "janvier";
                case 2:
                    return "fevrier";
                case 3:
                    return "mars";
                case 4:
                    return "avril";
                case 5:
                    return "mai";
                case 6:
                    return "juin";
                case 7:
                    return "juillet";
                case 8:
                    return "aout";
                case 9:
                    return "septembre";
                case 10:
                    return "octobre";
                case 11:
                    return "novembre";
                case 12:
                    return "decembre";
                default:
                    return "";
            }
        }

        public static string FormatTelephone(string noTel)
        {
            string newTel = "";
            short compteur = 0;
            short part = 0;

            for (int i = 0; i < noTel.Length; i++)
            {
                if (compteur == 0 && part == 0)
                    newTel += "( ";
                else if (compteur == 3 && part == 0)
                    newTel += " ) ";
                else if (compteur == 6 && part < 2)
                {
                    newTel += "-";
                    compteur = 0;
                    part++;
                }
                compteur++;
                newTel += noTel[i];
            }

            return newTel;
        }
    }
}
