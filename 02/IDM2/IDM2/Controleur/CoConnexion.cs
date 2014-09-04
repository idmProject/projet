//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using IDM2.BaseDonnee;

//namespace IDM2.Controleur
//{
//    public class CoConnexion: Co
//    {
//        public CoConnexion() : base() { }

//        public  void CreerConnexion()
//        {
//            Connexion co = new Connexion();
//            co.LastConnexion = _test.Date;

//            if (_bd.Connexion.Count(c => c.LastConnexion.Month == _test.Date.Month && c.DernierLoyerCreer) == 1)
//                co.DernierLoyerCreer = false;
//            else
//            {
//                Controller.Loyer.CreerLoyer();
//                co.DernierLoyerCreer = true;
//            }

//            _bd.Connexion.Add(co);

//            _bd.SaveChanges();

//        }

//    }
//}
