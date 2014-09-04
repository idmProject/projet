using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Controleur
{

    public class Controller
    {
        private static CoClient _controllerClient = new CoClient();
        private static CoCodeElectronique _controllerCodeElectronique = new CoCodeElectronique();
        private static CoContrat _controllerContrat = new CoContrat();
        private static CoEspace _controllerEspace = new CoEspace();
        private static CoLocal _controllerLocal = new CoLocal();
        private static CoPaiement _controllerPaiement = new CoPaiement();
        private static CoSite _controllerSite = new CoSite();
        private static CoStationnement _controllerStationnement = new CoStationnement();
        private static CoTaxe _controllerTaxe = new CoTaxe();
        private static CoTelephone _controllerTelephone = new CoTelephone();
        private static CoTypeEspace _controllerTypeEspace = new CoTypeEspace();
        private static CoVille _controllerVille = new CoVille();
        private static CoVue _controllerVue = new CoVue();
        private static CoLoyer _controllerLoyer = new CoLoyer();
    //    private static CoConnexion _controllerConnexion = new CoConnexion();

        public static CoClient Client { get { return _controllerClient; } }
        public static CoCodeElectronique CodeElectronique { get { return _controllerCodeElectronique; } }
        public static CoContrat Contrat { get { return _controllerContrat; } }
        public static CoEspace Espace { get { return _controllerEspace; } }
        public static CoLocal Local { get { return _controllerLocal; } }
        public static CoLoyer Loyer { get { return _controllerLoyer; } }
        public static CoPaiement Paiement { get { return _controllerPaiement; } }
        public static CoSite Site { get { return _controllerSite; } }
        public static CoStationnement Stationnement { get { return _controllerStationnement; } }
        public static CoTaxe Taxe { get { return _controllerTaxe; } }
        public static CoTelephone Telephone { get { return _controllerTelephone; } }
        public static CoTypeEspace TypeEspace { get { return _controllerTypeEspace; } }
        public static CoVille Ville { get { return _controllerVille; } }
        public static CoVue Vue { get { return _controllerVue; } }
        //public static CoConnexion Connexion { get { return _controllerConnexion; } }


        public static void MiseAJour()
        {
            Loyer.MiseAJourLoyer();
            Espace.MiseAJourDisponibilite();
        }
    }

}
