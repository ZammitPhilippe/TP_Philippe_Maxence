using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Philippe_Maxence
{
    public partial class C_Cadre : Form
    {
        private C_Base La_Base;
        public int Compteur = 0;
        public int CompteurV1 = 0;
        public C_Cadre()
        {
            InitializeComponent();

            La_Base = new C_Base();
            La_Base.Charge_Toi();

            ListBox_Mesure.DataSource = La_Base.Les_Mesures;
            ListBox_Mesure.DisplayMember = ToString();
        }
        //-----------------------Menu-------------------------------------------------------//

        private void Fermer_fichier_Click(object sender, EventArgs e)
        {
            if (Compteur>0)
            {
                alert.Text = ("Veuillez Sauvegarder");
               
            }
            if(CompteurV1>0) { Close(); }
       

        }


        //---------------------Bouton---------------------------------------------------------//


        private void Bouton_Sauve_Click(object sender, EventArgs e)
        {
            CompteurV1++;
            La_Base.Sauvegarde_Toi();
            Bouton_Sauve.Enabled = false;
            Bouton_Modif.Enabled = false;
        }
        private void Bouton_Suppr_Click(object sender, EventArgs e)
        {
            C_Mesure Delete_mesure = ListBox_Mesure.SelectedItem as C_Mesure;

            if (Delete_mesure != null)
            {
                La_Base.Les_Mesures.Remove(Delete_mesure);
            }

            Bouton_Sauve.Enabled = true;
            Bouton_Modif.Enabled = false;
        }
        private void Bouton_Ajout_Click(object sender, EventArgs e)
        {
            C_Mesure Nouvelle_Mesure = new C_Mesure();
            Nouvelle_Mesure.ID = Convert.ToInt32(TextBox_ID_Crea.Text);
            Nouvelle_Mesure.X = Convert.ToInt32(TextBox_X_crea.Text);
            Nouvelle_Mesure.Y = Convert.ToInt32(TextBox_Y_crea.Text);
            Nouvelle_Mesure.Hauteur = Convert.ToInt32(TextBox_Hauteur_crea.Text);
            Nouvelle_Mesure.Largeur = Convert.ToInt32(TextBox_Largeur_crea.Text);

            La_Base.Les_Mesures.Add(Nouvelle_Mesure);

            Bouton_Sauve.Enabled = true;
            Bouton_Modif.Enabled = false;

         

        }

        private void Bouton_Modif_Click(object sender, EventArgs e)
        {
            Compteur++;
            C_Mesure Mesure_Select= ListBox_Mesure.SelectedItem as C_Mesure;

            Mesure_Select.ID = Convert.ToInt32(TextBox_ID.Text);
            Mesure_Select.X = Convert.ToInt32(TextBox_X.Text);
            Mesure_Select.Y = Convert.ToInt32(TextBox_Y.Text);
            Mesure_Select.Hauteur = Convert.ToInt32(TextBox_Hauteur.Text);
            Mesure_Select.Largeur = Convert.ToInt32(TextBox_Largeur.Text);

            

            Bouton_Sauve.Enabled = true;



            CheckBox_acces.Checked = false;
            TextBox_X.ReadOnly = true;
            TextBox_Y.ReadOnly = true;
            TextBox_Hauteur.ReadOnly = true;
            TextBox_Largeur.ReadOnly = true;

            ListBox_Mesure.DataSource = null;
            ListBox_Mesure.Refresh();
            ListBox_Mesure.DataSource = La_Base.Les_Mesures;
            ListBox_Mesure.DisplayMember = ToString();
           

        }

        //-------------------------------------ListBox----------------------------------------------------//

        private void ListBox_Mesure_SelectedIndexChanged(object sender, EventArgs e)
        {

            C_Mesure Mesure_Select = (C_Mesure)ListBox_Mesure.SelectedItem;
            if (Mesure_Select != null)
            {
                TextBox_ID.Text = Mesure_Select.ID.ToString();
                TextBox_X.Text = Mesure_Select.X.ToString();
                TextBox_Y.Text = Mesure_Select.Y.ToString();
                TextBox_Hauteur.Text = Mesure_Select.Hauteur.ToString();
                TextBox_Largeur.Text = Mesure_Select.Largeur.ToString();

                Bouton_Modif.Enabled = false;
            }
        }

        //------------------------------------------------Partie 2---------------------------------------//

        private void CheckBox_acces_CheckedChanged(object sender, EventArgs e)
        {

                if (CheckBox_acces.Checked == true)
                {
                    Bouton_Modif.Enabled = true;
                    TextBox_X.ReadOnly = false;
                TextBox_Y.ReadOnly = false;
                TextBox_Hauteur.ReadOnly = false;
                TextBox_Largeur.ReadOnly = false;
              
            }
                 else
                {
                     Bouton_Modif.Enabled = false;
                TextBox_X.ReadOnly = true;
                TextBox_Y.ReadOnly = true;
                TextBox_Hauteur.ReadOnly = true;
                TextBox_Largeur.ReadOnly = true;
            }
           
        }
    }
}
