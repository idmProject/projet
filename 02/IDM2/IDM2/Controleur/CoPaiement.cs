using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.Entity;

namespace IDM2.Controleur
{
    public class CoPaiement : Co
    {
        private CoTaxe _controllerTaxe;
        private Taxe _tps;
        private Taxe _tvq;

        public double TPS { get { return (double)_tps.Taux; } }
        public double TVQ { get { return (double)_tvq.Taux; } }

        public CoPaiement()
            : base()
        {
            _controllerTaxe = new CoTaxe();
            _tps = _controllerTaxe.ObtenirTpsPlusRecente();
            _tvq = _controllerTaxe.ObtenirTvqPlusRecente();
        }

        public void EffectuerPaiement(Paiement paiement)
        {
            Client client = _bd.Client.Find(paiement.ClientId);
            Loyer[] loyers = Controller.Loyer.LoyersImpayesParClient(client);

            decimal montantPaiement = paiement.MontantPaye;
            decimal sommeDues = 0;

            for (int i = 0; i < loyers.Length; i++)
                sommeDues += loyers[i].MontantLoyer - loyers[i].MontantPayer;

            // Remboursemnt complet
            if (sommeDues == montantPaiement)
            {
                for (int i = 0; i < loyers.Length; i++)
                {
                    loyers[i].EstPayer = true;
                    loyers[i].MontantPayer = loyers[i].MontantLoyer;
                    loyers[i].Paiement.Add(paiement);
                }
            }

                // Remboursement partiel
            else
            {
                for (int i = 0; i < loyers.Length; i++)
                {
                    if (montantPaiement > loyers[i].MontantLoyer - loyers[i].MontantPayer)
                    {
                        montantPaiement -= loyers[i].MontantLoyer - loyers[i].MontantPayer;
                        loyers[i].EstPayer = true;
                        loyers[i].MontantPayer = loyers[i].MontantLoyer;
                        loyers[i].Paiement.Add(paiement);
                    }
                    else
                    {
                        loyers[i].EstPayer = false;
                        loyers[i].MontantPayer = loyers[i].MontantPayer + montantPaiement;
                        loyers[i].Paiement.Add(paiement);
                        montantPaiement = 0;
                        break;
                    }
                }
            }

            _bd.Paiement.Add(paiement);

            _bd.SaveChanges();
        }

        public decimal ObtenirMontantAvantTaxe(decimal montant)
        {
            return montant / ((decimal)(_tps.Taux + _tvq.Taux + 1));
        }

        public decimal ObtenirMontantTps(decimal montant)
        {
            return ObtenirMontantAvantTaxe(montant) * (decimal)_tps.Taux;
        }

        public decimal ObtenirMontantTvq(decimal montant)
        {
            return ObtenirMontantAvantTaxe(montant) * (decimal)_tvq.Taux;
        }

        public Paiement[] ObtenirTousPaiementDeClient(Client client)
        {
            return _bd.Paiement.Where(p => p.ClientId == client.ClientId).ToArray();
        }
    }
}
