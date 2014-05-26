using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDM2.BaseDonnee
{
    static class Contexte
    {

        static private IDM_DATAEntities _bd;

        public static  IDM_DATAEntities Bd { get { return _bd; } }

        static Contexte()
        {
            _bd = new IDM_DATAEntities();
        }
    }
}
