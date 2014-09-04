using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;

namespace IDM2.Controleur
{
    public class CoCodeElectronique : Co
    {

        public CoCodeElectronique()
            : base()
        {
        }

        public void AjouterCodeElectronique(CodeElectronique code, Client client)
        {
            code.ClientId = client.ClientId;
            _bd.CodeElectronique.Add(code);

            _bd.SaveChanges();
        }

        public void AjouterCodesElectroniques(List<CodeElectronique> codes, Client client)
        {

            for (int i = 0; i < codes.Count; i++)
            {
                codes[i].ClientId = client.ClientId;
                _bd.CodeElectronique.Add(codes[i]);

                //------------------
                // à modifier!!!
                codes[i].SiteId = 1;
                //-------------------
            }

            _bd.SaveChanges();
        }


        public void ModifierCodesElectroniques(CodeElectronique[] newCodes, Client client)
        {
            client.CodeElectronique.Clear();
            for (int i = 0; i < newCodes.Length; i++)
            {
                newCodes[i].SiteId = 1;
                AjouterCodeElectronique(newCodes[i], client);
            }

            _bd.SaveChanges();
        }


        public List<CodeElectronique> ObtenirCodesElectroniques(Client client)
        {
            return _bd.CodeElectronique.Where(c => c.ClientId == client.ClientId).ToList();
        }

    }
}
