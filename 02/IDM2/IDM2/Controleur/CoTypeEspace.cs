using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;


namespace IDM2.Controleur
{
   public class CoTypeEspace
    {
       private IDM_DATAEntities _bd;

       public CoTypeEspace()
       {
           _bd = Contexte.Bd;
       }

       public TypeEspace AjouterTypeEspace(TypeEspace typeEspace)
       {
           _bd.TypeEspace.Add(typeEspace);
           _bd.SaveChanges();

           return typeEspace;
       }

       public int ObtenirNombreTypeEspace()
       {
           return _bd.TypeEspace.Count();
       }

       public TypeEspace ObtenirTypeEspace(int id)
       {
           return _bd.TypeEspace.Find(id);
       }


    }
}
