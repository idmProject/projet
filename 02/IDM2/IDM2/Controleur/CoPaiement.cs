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
    public class CoPaiement
    {
        private IDM_DATAEntities _bd;
        private CoTaxe _controllerTaxe;
        private Taxe _tps;
        private Taxe _tvq;

        public double TPS { get { return (double)_tps.Taux; } }
        public double TVQ { get { return (double)_tvq.Taux; } }
       
        public CoPaiement()
        {
            _bd = Contexte.Bd;
            _controllerTaxe = new CoTaxe();
            _tps = _controllerTaxe.ObtenirTpsPlusRecente();
            _tvq = _controllerTaxe.ObtenirTvqPlusRecente();
        }

        public Paiement AjouterPaiement(Paiement paiement)
        {
            _bd.Paiement.Add(paiement);

            try{
            //{
            //    _bd.Configuration.ValidateOnSaveEnabled = false;
            //    _bd.SaveChangesAsync();
            //    DbTransaction t = new DbContextTransaction();
            //    t.Commit();
            //    _bd.

                _bd.SaveChanges();
            }
            catch (Exception ex)
            {
              //  _formPaiement.
                MessageBox.Show(ex.Message);
            }
            return paiement;
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
        
    }
}
