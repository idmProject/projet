using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;

namespace IDM2.Controleur
{
   public class CoLocal
    {
       private IDM_DATAEntities _bd;

       public CoLocal()
       {
           _bd = Contexte.Bd;
       }

       public Local AjouterLocal(Local local)
       {
           _bd.Local.Add(local);
           _bd.SaveChanges();
           return local;
       }

       public Local ObtenirLocal(int espaceId)
       {
           return _bd.Local.Find(espaceId);
       }
    }
}
