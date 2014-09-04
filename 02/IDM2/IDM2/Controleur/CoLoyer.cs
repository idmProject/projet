using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;

namespace IDM2.Controleur
{
    /// <summary>
    /// AUTEUR: J-R
    /// DESCRIPTION: Controller de Loyer, classe qui accèse à la base de donnée et où sont exécutées toutes les requêtes 
    ///              liées à un loyer
    /// </summary>
    public class CoLoyer : Co
    {
        /// <summary>
        /// Constructeur du controller, hérite du constructeur de controller par défaut
        /// </summary>
        public CoLoyer() : base() { }


        /// <summary>
        /// Permet de créer un loyer associé à un contrat à une date voulue
        /// </summary>
        /// <param name="contratId">Id du contrat</param>
        /// <param name="dateLoyer">Date du loyer</param>
        public void CreerLoyer(int contratId, DateTime dateLoyer)
        {
            Loyer loyer = new Loyer();
            Contrat contrat = _bd.Contrat.Find(contratId);

            // Premier loyer du contrat...peut ne pas être charger au complet
            if (contrat.DateEntree.Month == dateLoyer.Month && contrat.DateEntree.Year == dateLoyer.Year)
                CreerLoyerFalcultatif(contrat, dateLoyer);

                // Loyer plein prix
            else
            {
                loyer.Contrat = contrat;
                loyer.ContratId = contratId;
                loyer.DateLoyer = dateLoyer;
                loyer.EstPayer = false;
                loyer.MontantLoyer = contrat.Prix;
                loyer.MontantPayer = 0;

                _bd.Loyer.Add(loyer);
                _bd.SaveChanges();
            }
        }


        /// <summary>
        /// Permet de créer des loyers dans le passé, si une date d'entrée de contrat est inférieur à celle du mois courant,
        /// tous les loyers précédents le mois actuel sont créer
        /// </summary>
        /// <param name="contratId">Id du contrat</param>
        public void CreerLoyerPasser(int contratId)
        {
            Contrat contrat = _bd.Contrat.Find(contratId);
            DateTime dateLoyer = new DateTime(_test.Date.Year, _test.Date.Month, 1);
            DateTime moisEntree = new DateTime(contrat.DateEntree.Year, contrat.DateEntree.Month, 1);

            while (moisEntree.Year != dateLoyer.Year ||
                moisEntree.Month != dateLoyer.Month)
            {
                if (_bd.Loyer.Count(l => l.DateLoyer == moisEntree && l.ContratId == contrat.ContratId) == 0)
                    CreerLoyer(contrat.ContratId, moisEntree);
                moisEntree = moisEntree.AddMonths(1);
            }
        }


        /// <summary>
        /// Permet de créer un loyer falcultatif, si une date d'entrée n'est pas le premier du mois, un prix falcultatif est
        /// calculer en fonction du nombre de jour restant au mois
        /// </summary>
        /// <param name="contrat">contrat associé au loyer</param>
        /// <param name="dateLoyer">date du loyer</param>
        public void CreerLoyerFalcultatif(Contrat contrat, DateTime dateLoyer)
        {
            int nombreJourMois = DateTime.DaysInMonth(contrat.DateEntree.Year, contrat.DateEntree.Month);
            int joursPayants = nombreJourMois - contrat.DateEntree.Day;

            decimal prixFalcultatif = contrat.Prix / nombreJourMois * joursPayants;

            Loyer loyer = new Loyer();

            loyer.Contrat = contrat;
            loyer.ContratId = contrat.ContratId;
            loyer.DateLoyer = dateLoyer;
            loyer.EstPayer = false;
            loyer.MontantLoyer = prixFalcultatif;
            loyer.MontantPayer = 0;

            _bd.Loyer.Add(loyer);
            _bd.SaveChanges();
        }


        /// <summary>
        /// Methode qui effectue une mise à jour de tous les loyers et contrats, si les loyers ne sont pas créer pour le
        /// mois actuel et les précédents, ils seront créers automatiquement à l'appel de cette méthode
        /// </summary>
        public void MiseAJourLoyer()
        {
            List<int> lstContratId = new List<int>();
            DateTime dateLoyer;

            // Boucle tant que tous les loyers suivant la date du dernier loyer jusqu'au moment présent ne sont pas créer
            do
            {
                lstContratId.Clear();

                if (_bd.Loyer.Count() == 0)
                    dateLoyer = new DateTime(_test.Date.Year, _test.Date.Month, 1);
                else
                    dateLoyer = _bd.Loyer.OrderByDescending(l => l.DateLoyer).FirstOrDefault().DateLoyer.AddMonths(1);

                if (dateLoyer < _test.Date)
                {
                    // select tous les ID de contratActif qui ne possède pas de loyer à la date de loyer
                    lstContratId.AddRange(
                        _bd.Contrat
                        .Where(c => ((c.DateEntree.Month <= dateLoyer.Month && c.DateEntree.Year <= dateLoyer.Year) ||
                            c.DateEntree <= _test.Date) && (c.DateSortie >= dateLoyer || c.DateSortie == null))
                        .Select(c => c.ContratId)
                        .Distinct()

                        .Except(

                        _bd.Contrat
                        .Join(_bd.Loyer,
                        c => c.ContratId,
                        l => l.ContratId,
                        (co, lo) => new { Contrat = co, Loyer = lo })
                        .Where(c => c.Loyer.DateLoyer == dateLoyer)
                        .Select(c => c.Contrat.ContratId))
                        .ToArray());


                    for (int i = 0; i < lstContratId.Count; i++)
                        CreerLoyer(lstContratId[i], dateLoyer);
                }
            }
            while (lstContratId.Count != 0 && dateLoyer < _test.Date);

        }


        /// <summary>
        /// Permet de créer manuellement un loyer en le passant en paramètre
        /// </summary>
        /// <param name="loyer">loyer à ajouter</param>
        public void CreerLoyerManuellement(Loyer loyer)
        {
            _bd.Loyer.Add(loyer);

            _bd.SaveChanges();
        }


        /// <summary>
        /// Permet d'obtenir tous les loyers du mois courant
        /// </summary>
        /// <returns>Tableau contenant les loyers du mois</returns>
        public Loyer[] LoyerDuMois()
        {
            return _bd.Loyer.Where(l => l.DateLoyer.Month == _test.Date.Month && l.DateLoyer.Year == _test.Date.Year).ToArray();
        }


        /// <summary>
        /// Permet d'obtenir tous les loyers impayés
        /// </summary>
        /// <returns>Tableau de loyers impayés</returns>
        public Loyer[] LoyersImpayes()
        {
            return _bd.Loyer.Where(l => l.EstPayer == false).ToArray();
        }


        /// <summary>
        /// Permet d'obtenir tous les loyers impayés un client en particulier
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Tableau de loyers impayés du client</returns>
        public Loyer[] LoyersImpayesParClient(Client client)
        {
            return
                _bd.Client
                .Where(c => c.ClientId == client.ClientId)
                .Join(
                    _bd.Contrat,
                    cl => cl.ClientId,
                    co => co.ClientId,
                    (cli, con) => new { Client = cli, Contrat = con })
                .Join(
                    _bd.Loyer,
                    co => co.Contrat.ContratId,
                    l => l.ContratId,
                    (con, loy) => new { Contrat = con, Loyer = loy })
                .Where(l => l.Loyer.EstPayer == false)
                .Select(l => l.Loyer)
                .ToArray();

        }


        /// <summary>
        /// Permet d'obtenir tous les loyers d'un client
        /// </summary>
        /// <param name="client">client en question</param>
        /// <returns></returns>
        public Loyer[] LoyersParClient(Client client)
        {
            return
                 _bd.Client
                 .Where(c => c.ClientId == client.ClientId)
                 .Join(
                     _bd.Contrat,
                     cl => cl.ClientId,
                     co => co.ClientId,
                     (cli, con) => new { Client = cli, Contrat = con })
                 .Join(
                     _bd.Loyer,
                     co => co.Contrat.ContratId,
                     l => l.ContratId,
                     (con, loy) => new { Contrat = con, Loyer = loy })
                 .Select(l => l.Loyer)
                 .ToArray();
        }


        /// <summary>
        /// Permet d'obtenir tous les loyers d'un client du plus récent au plus ancien
        /// </summary>
        /// <param name="client">client en question</param>
        /// <returns></returns>
        public Loyer[] LoyersParClientDescending(Client client)
        {
            return
                 _bd.Client
                 .Where(c => c.ClientId == client.ClientId)
                 .Join(
                     _bd.Contrat,
                     cl => cl.ClientId,
                     co => co.ClientId,
                     (cli, con) => new { Client = cli, Contrat = con })
                 .Join(
                     _bd.Loyer,
                     co => co.Contrat.ContratId,
                     l => l.ContratId,
                     (con, loy) => new { Contrat = con, Loyer = loy })
                 .Select(l => l.Loyer)
                 .OrderByDescending(l => l.DateLoyer)
                 .ToArray();
        }


        /// <summary>
        /// Permet d'obtenir le montant due total d'un client
        /// </summary>
        /// <param name="client">client en cause</param>
        /// <returns></returns>
        public decimal MontantTotalDue(Client client)
        {
            decimal montantDue = 0;

            Loyer[] loyersImpayes = LoyersImpayesParClient(client);

            for (int i = 0; i < loyersImpayes.Length; i++)
                montantDue += loyersImpayes[i].MontantLoyer - loyersImpayes[i].MontantPayer;

            return montantDue;
        }


        /// <summary>
        /// Permet d'obtenir tous les paiements associées à un loyer
        /// </summary>
        /// <param name="loyer">loyer en question</param>
        /// <returns></returns>
        public Paiement[] ObtenirPaiementsParLoyer(Loyer loyer)
        {
            return _bd.Paiement.Where(p => p.Loyer.Any(l => l.ContratId == loyer.ContratId && l.DateLoyer == loyer.DateLoyer)).ToArray();
            
        }
    }
}
