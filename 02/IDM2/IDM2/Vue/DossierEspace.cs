using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.BaseDonnee;
using IDM2.Controleur;
using System.Drawing;

namespace IDM2.Vue
{
    public class DossierEspace
    {
        private class InfoEspace
        {
            public string Info { get; set; }
            public string NomInfo { get; set; }

            public InfoEspace(string nomInfo, string info)
            {
                Info = info;
                NomInfo = nomInfo;
            }
        }
        private CoVue _controllerVue;

        public DossierEspace()
        {
            _controllerVue = new CoVue();
        }

        public GroupBox ObtenirDossier(Local local)
        {
            List<InfoEspace> infoLocal = new List<InfoEspace>();
            DossierLocalView dossierLocal = _controllerVue.ObtenirDossierLocalView(local.EspaceId);

            infoLocal.Add(new InfoEspace("NoLocal", dossierLocal.NoLocal));
            infoLocal.Add(new InfoEspace("Disponible", dossierLocal.Disponible.ToString()));
            infoLocal.Add(new InfoEspace("Largeur", dossierLocal.Largeur.ToString()));
            infoLocal.Add(new InfoEspace("Longueur", dossierLocal.Longueur.ToString()));
            infoLocal.Add(new InfoEspace("Prix", dossierLocal.Prix.ToString()));
            infoLocal.Add(new InfoEspace("Alias", dossierLocal.Alias));
            infoLocal.Add(new InfoEspace("Ville", dossierLocal.Ville));

            return GenererDossier(infoLocal);
        }

        public GroupBox ObtenirDossier(Stationnement stationnement)
        {
            //return GenererDossier(infoStationnement);
            List<InfoEspace> infoStationnement = new List<InfoEspace>();
            DossierStationnementView dossierStationnement = _controllerVue.ObtenirDossierStationnementView(stationnement.EspaceId);

            infoStationnement.Add(new InfoEspace("NoLocal", dossierStationnement.NoStationnement));
            infoStationnement.Add(new InfoEspace("Disponible", dossierStationnement.Disponible.ToString()));
            infoStationnement.Add(new InfoEspace("Prix", dossierStationnement.Prix.ToString()));
            infoStationnement.Add(new InfoEspace("Alias", dossierStationnement.Alias));
            infoStationnement.Add(new InfoEspace("Ville", dossierStationnement.Ville));

            return GenererDossier(infoStationnement);
        }

        

        private GroupBox GenererDossier(List<InfoEspace> info)
        {
            GroupBox gb = new GroupBox();

            gb.Size = new Size(299, 274);
            gb.Name = "DossierClient";


            int x = 17;
            int y = 2;

            for (int i = 0; i < info.Count; i++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(x, y += 30);
                label.Parent = gb;
                label.Name = "lbl" + info[i].NomInfo;
                label.Text = info[i].NomInfo + ": " + info[i].Info;
                label.Size = new System.Drawing.Size(info[i].Info.Length * 12 + info[i].NomInfo.Length * 12, 13);
                gb.Controls.Add(label);
            }

            return gb;
        }
    }
}
