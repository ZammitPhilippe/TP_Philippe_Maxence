
namespace TP_Philippe_Maxence
{
    partial class C_Cadre
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ouvrir_Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.Espacement_fichier = new System.Windows.Forms.ToolStripSeparator();
            this.Fermer_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.TextBox_Y = new System.Windows.Forms.TextBox();
            this.TextBox_Largeur = new System.Windows.Forms.TextBox();
            this.TextBox_X = new System.Windows.Forms.TextBox();
            this.TextBox_Hauteur = new System.Windows.Forms.TextBox();
            this.GroupeBox_Lecture = new System.Windows.Forms.GroupBox();
            this.CheckBox_acces = new System.Windows.Forms.CheckBox();
            this.Bouton_Modif = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GroupeBox_Creation = new System.Windows.Forms.GroupBox();
            this.Bouton_Ajout = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.TextBox_ID_Crea = new System.Windows.Forms.TextBox();
            this.TextBox_Largeur_crea = new System.Windows.Forms.TextBox();
            this.TextBox_X_crea = new System.Windows.Forms.TextBox();
            this.TextBox_Y_crea = new System.Windows.Forms.TextBox();
            this.TextBox_Hauteur_crea = new System.Windows.Forms.TextBox();
            this.GroupeBox_Mesure = new System.Windows.Forms.GroupBox();
            this.Bouton_Sauve = new System.Windows.Forms.Button();
            this.Bouton_Suppr = new System.Windows.Forms.Button();
            this.ListBox_Mesure = new System.Windows.Forms.ListBox();
            this.GroupeBox_Bloc = new System.Windows.Forms.GroupBox();
            this.alert = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.GroupeBox_Lecture.SuspendLayout();
            this.GroupeBox_Creation.SuspendLayout();
            this.GroupeBox_Mesure.SuspendLayout();
            this.GroupeBox_Bloc.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ouvrir_Fichier,
            this.Espacement_fichier,
            this.Fermer_fichier});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // Ouvrir_Fichier
            // 
            this.Ouvrir_Fichier.Name = "Ouvrir_Fichier";
            this.Ouvrir_Fichier.Size = new System.Drawing.Size(224, 26);
            this.Ouvrir_Fichier.Text = "&Ouvrir";
            // 
            // Espacement_fichier
            // 
            this.Espacement_fichier.Name = "Espacement_fichier";
            this.Espacement_fichier.Size = new System.Drawing.Size(221, 6);
            // 
            // Fermer_fichier
            // 
            this.Fermer_fichier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Fermer_fichier.Name = "Fermer_fichier";
            this.Fermer_fichier.Size = new System.Drawing.Size(224, 26);
            this.Fermer_fichier.Text = "&Fermer";
            this.Fermer_fichier.Click += new System.EventHandler(this.Fermer_fichier_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(106, 40);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.ReadOnly = true;
            this.TextBox_ID.Size = new System.Drawing.Size(218, 22);
            this.TextBox_ID.TabIndex = 3;
            // 
            // TextBox_Y
            // 
            this.TextBox_Y.Location = new System.Drawing.Point(106, 136);
            this.TextBox_Y.Name = "TextBox_Y";
            this.TextBox_Y.ReadOnly = true;
            this.TextBox_Y.Size = new System.Drawing.Size(218, 22);
            this.TextBox_Y.TabIndex = 3;
            // 
            // TextBox_Largeur
            // 
            this.TextBox_Largeur.Location = new System.Drawing.Point(106, 249);
            this.TextBox_Largeur.Name = "TextBox_Largeur";
            this.TextBox_Largeur.ReadOnly = true;
            this.TextBox_Largeur.Size = new System.Drawing.Size(218, 22);
            this.TextBox_Largeur.TabIndex = 3;
            // 
            // TextBox_X
            // 
            this.TextBox_X.Location = new System.Drawing.Point(106, 87);
            this.TextBox_X.Name = "TextBox_X";
            this.TextBox_X.ReadOnly = true;
            this.TextBox_X.Size = new System.Drawing.Size(218, 22);
            this.TextBox_X.TabIndex = 3;
            // 
            // TextBox_Hauteur
            // 
            this.TextBox_Hauteur.Location = new System.Drawing.Point(106, 194);
            this.TextBox_Hauteur.Name = "TextBox_Hauteur";
            this.TextBox_Hauteur.ReadOnly = true;
            this.TextBox_Hauteur.Size = new System.Drawing.Size(218, 22);
            this.TextBox_Hauteur.TabIndex = 3;
            // 
            // GroupeBox_Lecture
            // 
            this.GroupeBox_Lecture.BackColor = System.Drawing.Color.OldLace;
            this.GroupeBox_Lecture.Controls.Add(this.CheckBox_acces);
            this.GroupeBox_Lecture.Controls.Add(this.Bouton_Modif);
            this.GroupeBox_Lecture.Controls.Add(this.textBox5);
            this.GroupeBox_Lecture.Controls.Add(this.textBox4);
            this.GroupeBox_Lecture.Controls.Add(this.textBox3);
            this.GroupeBox_Lecture.Controls.Add(this.textBox2);
            this.GroupeBox_Lecture.Controls.Add(this.textBox1);
            this.GroupeBox_Lecture.Controls.Add(this.TextBox_ID);
            this.GroupeBox_Lecture.Controls.Add(this.TextBox_Largeur);
            this.GroupeBox_Lecture.Controls.Add(this.TextBox_X);
            this.GroupeBox_Lecture.Controls.Add(this.TextBox_Hauteur);
            this.GroupeBox_Lecture.Controls.Add(this.TextBox_Y);
            this.GroupeBox_Lecture.Location = new System.Drawing.Point(479, 38);
            this.GroupeBox_Lecture.Name = "GroupeBox_Lecture";
            this.GroupeBox_Lecture.Size = new System.Drawing.Size(330, 324);
            this.GroupeBox_Lecture.TabIndex = 5;
            this.GroupeBox_Lecture.TabStop = false;
            this.GroupeBox_Lecture.Text = "Lecture :";
            // 
            // CheckBox_acces
            // 
            this.CheckBox_acces.AutoSize = true;
            this.CheckBox_acces.Location = new System.Drawing.Point(52, 291);
            this.CheckBox_acces.Name = "CheckBox_acces";
            this.CheckBox_acces.Size = new System.Drawing.Size(121, 21);
            this.CheckBox_acces.TabIndex = 8;
            this.CheckBox_acces.Text = "Accès Ecriture";
            this.CheckBox_acces.UseVisualStyleBackColor = true;
            this.CheckBox_acces.CheckedChanged += new System.EventHandler(this.CheckBox_acces_CheckedChanged);
            // 
            // Bouton_Modif
            // 
            this.Bouton_Modif.Location = new System.Drawing.Point(190, 283);
            this.Bouton_Modif.Name = "Bouton_Modif";
            this.Bouton_Modif.Size = new System.Drawing.Size(134, 35);
            this.Bouton_Modif.TabIndex = 7;
            this.Bouton_Modif.Text = "<< Modifier >>";
            this.Bouton_Modif.UseVisualStyleBackColor = true;
            this.Bouton_Modif.Click += new System.EventHandler(this.Bouton_Modif_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.OldLace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(28, 253);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 15);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "Largeur :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.OldLace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(29, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 15);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Hauteur :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(52, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 15);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Y  :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(52, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "X :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(52, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 15);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "ID :";
            // 
            // GroupeBox_Creation
            // 
            this.GroupeBox_Creation.BackColor = System.Drawing.Color.OldLace;
            this.GroupeBox_Creation.Controls.Add(this.Bouton_Ajout);
            this.GroupeBox_Creation.Controls.Add(this.textBox6);
            this.GroupeBox_Creation.Controls.Add(this.textBox7);
            this.GroupeBox_Creation.Controls.Add(this.textBox8);
            this.GroupeBox_Creation.Controls.Add(this.textBox9);
            this.GroupeBox_Creation.Controls.Add(this.textBox10);
            this.GroupeBox_Creation.Controls.Add(this.TextBox_ID_Crea);
            this.GroupeBox_Creation.Controls.Add(this.TextBox_Largeur_crea);
            this.GroupeBox_Creation.Controls.Add(this.TextBox_X_crea);
            this.GroupeBox_Creation.Controls.Add(this.TextBox_Y_crea);
            this.GroupeBox_Creation.Controls.Add(this.TextBox_Hauteur_crea);
            this.GroupeBox_Creation.Location = new System.Drawing.Point(876, 38);
            this.GroupeBox_Creation.Name = "GroupeBox_Creation";
            this.GroupeBox_Creation.Size = new System.Drawing.Size(351, 324);
            this.GroupeBox_Creation.TabIndex = 4;
            this.GroupeBox_Creation.TabStop = false;
            this.GroupeBox_Creation.Text = "Creation";
            // 
            // Bouton_Ajout
            // 
            this.Bouton_Ajout.Location = new System.Drawing.Point(211, 283);
            this.Bouton_Ajout.Name = "Bouton_Ajout";
            this.Bouton_Ajout.Size = new System.Drawing.Size(134, 35);
            this.Bouton_Ajout.TabIndex = 7;
            this.Bouton_Ajout.Text = "<< Ajouter >>";
            this.Bouton_Ajout.UseVisualStyleBackColor = true;
            this.Bouton_Ajout.Click += new System.EventHandler(this.Bouton_Ajout_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.OldLace;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(6, 256);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(63, 15);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "Largeur :";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.OldLace;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(6, 201);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 15);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "Hauteur :";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.OldLace;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(28, 140);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(41, 15);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "Y  :";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.OldLace;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(28, 94);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 15);
            this.textBox9.TabIndex = 3;
            this.textBox9.Text = "X :";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.OldLace;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(28, 40);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(39, 15);
            this.textBox10.TabIndex = 3;
            this.textBox10.Text = "ID :";
            // 
            // TextBox_ID_Crea
            // 
            this.TextBox_ID_Crea.Location = new System.Drawing.Point(75, 40);
            this.TextBox_ID_Crea.Name = "TextBox_ID_Crea";
            this.TextBox_ID_Crea.Size = new System.Drawing.Size(259, 22);
            this.TextBox_ID_Crea.TabIndex = 3;
            // 
            // TextBox_Largeur_crea
            // 
            this.TextBox_Largeur_crea.Location = new System.Drawing.Point(75, 249);
            this.TextBox_Largeur_crea.Name = "TextBox_Largeur_crea";
            this.TextBox_Largeur_crea.Size = new System.Drawing.Size(259, 22);
            this.TextBox_Largeur_crea.TabIndex = 3;
            // 
            // TextBox_X_crea
            // 
            this.TextBox_X_crea.Location = new System.Drawing.Point(75, 87);
            this.TextBox_X_crea.Name = "TextBox_X_crea";
            this.TextBox_X_crea.Size = new System.Drawing.Size(259, 22);
            this.TextBox_X_crea.TabIndex = 3;
            // 
            // TextBox_Y_crea
            // 
            this.TextBox_Y_crea.Location = new System.Drawing.Point(75, 140);
            this.TextBox_Y_crea.Name = "TextBox_Y_crea";
            this.TextBox_Y_crea.Size = new System.Drawing.Size(259, 22);
            this.TextBox_Y_crea.TabIndex = 3;
            // 
            // TextBox_Hauteur_crea
            // 
            this.TextBox_Hauteur_crea.Location = new System.Drawing.Point(75, 194);
            this.TextBox_Hauteur_crea.Name = "TextBox_Hauteur_crea";
            this.TextBox_Hauteur_crea.Size = new System.Drawing.Size(259, 22);
            this.TextBox_Hauteur_crea.TabIndex = 3;
            // 
            // GroupeBox_Mesure
            // 
            this.GroupeBox_Mesure.BackColor = System.Drawing.Color.OldLace;
            this.GroupeBox_Mesure.Controls.Add(this.Bouton_Sauve);
            this.GroupeBox_Mesure.Controls.Add(this.Bouton_Suppr);
            this.GroupeBox_Mesure.Controls.Add(this.ListBox_Mesure);
            this.GroupeBox_Mesure.Location = new System.Drawing.Point(17, 21);
            this.GroupeBox_Mesure.Name = "GroupeBox_Mesure";
            this.GroupeBox_Mesure.Size = new System.Drawing.Size(441, 364);
            this.GroupeBox_Mesure.TabIndex = 6;
            this.GroupeBox_Mesure.TabStop = false;
            this.GroupeBox_Mesure.Text = "Les Mesure";
            // 
            // Bouton_Sauve
            // 
            this.Bouton_Sauve.Location = new System.Drawing.Point(12, 306);
            this.Bouton_Sauve.Name = "Bouton_Sauve";
            this.Bouton_Sauve.Size = new System.Drawing.Size(134, 35);
            this.Bouton_Sauve.TabIndex = 7;
            this.Bouton_Sauve.Text = "<< Save Base >>";
            this.Bouton_Sauve.UseVisualStyleBackColor = true;
            this.Bouton_Sauve.Click += new System.EventHandler(this.Bouton_Sauve_Click);
            // 
            // Bouton_Suppr
            // 
            this.Bouton_Suppr.Location = new System.Drawing.Point(19, 153);
            this.Bouton_Suppr.Name = "Bouton_Suppr";
            this.Bouton_Suppr.Size = new System.Drawing.Size(115, 35);
            this.Bouton_Suppr.TabIndex = 7;
            this.Bouton_Suppr.Text = "<< Delete >>";
            this.Bouton_Suppr.UseVisualStyleBackColor = true;
            this.Bouton_Suppr.Click += new System.EventHandler(this.Bouton_Suppr_Click);
            // 
            // ListBox_Mesure
            // 
            this.ListBox_Mesure.FormattingEnabled = true;
            this.ListBox_Mesure.ItemHeight = 16;
            this.ListBox_Mesure.Location = new System.Drawing.Point(163, 19);
            this.ListBox_Mesure.Name = "ListBox_Mesure";
            this.ListBox_Mesure.Size = new System.Drawing.Size(255, 324);
            this.ListBox_Mesure.TabIndex = 0;
            this.ListBox_Mesure.SelectedIndexChanged += new System.EventHandler(this.ListBox_Mesure_SelectedIndexChanged);
            // 
            // GroupeBox_Bloc
            // 
            this.GroupeBox_Bloc.BackColor = System.Drawing.Color.OldLace;
            this.GroupeBox_Bloc.Controls.Add(this.GroupeBox_Mesure);
            this.GroupeBox_Bloc.Controls.Add(this.GroupeBox_Creation);
            this.GroupeBox_Bloc.Controls.Add(this.GroupeBox_Lecture);
            this.GroupeBox_Bloc.Location = new System.Drawing.Point(12, 39);
            this.GroupeBox_Bloc.Name = "GroupeBox_Bloc";
            this.GroupeBox_Bloc.Size = new System.Drawing.Size(1267, 391);
            this.GroupeBox_Bloc.TabIndex = 7;
            this.GroupeBox_Bloc.TabStop = false;
            // 
            // alert
            // 
            this.alert.BackColor = System.Drawing.Color.White;
            this.alert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alert.ForeColor = System.Drawing.Color.Maroon;
            this.alert.Location = new System.Drawing.Point(451, 445);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(409, 15);
            this.alert.TabIndex = 7;
            // 
            // C_Cadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1308, 521);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.GroupeBox_Bloc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "C_Cadre";
            this.Text = "Cadre";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupeBox_Lecture.ResumeLayout(false);
            this.GroupeBox_Lecture.PerformLayout();
            this.GroupeBox_Creation.ResumeLayout(false);
            this.GroupeBox_Creation.PerformLayout();
            this.GroupeBox_Mesure.ResumeLayout(false);
            this.GroupeBox_Bloc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ouvrir_Fichier;
        private System.Windows.Forms.ToolStripSeparator Espacement_fichier;
        private System.Windows.Forms.ToolStripMenuItem Fermer_fichier;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.TextBox TextBox_Y;
        private System.Windows.Forms.TextBox TextBox_Largeur;
        private System.Windows.Forms.TextBox TextBox_X;
        private System.Windows.Forms.TextBox TextBox_Hauteur;
        private System.Windows.Forms.GroupBox GroupeBox_Lecture;
        private System.Windows.Forms.GroupBox GroupeBox_Creation;
        private System.Windows.Forms.TextBox TextBox_ID_Crea;
        private System.Windows.Forms.TextBox TextBox_X_crea;
        private System.Windows.Forms.TextBox TextBox_Y_crea;
        private System.Windows.Forms.TextBox TextBox_Largeur_crea;
        private System.Windows.Forms.TextBox TextBox_Hauteur_crea;
        private System.Windows.Forms.GroupBox GroupeBox_Mesure;
        private System.Windows.Forms.ListBox ListBox_Mesure;
        private System.Windows.Forms.GroupBox GroupeBox_Bloc;
        private System.Windows.Forms.Button Bouton_Suppr;
        private System.Windows.Forms.Button Bouton_Sauve;
        private System.Windows.Forms.Button Bouton_Modif;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Bouton_Ajout;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.CheckBox CheckBox_acces;
        private System.Windows.Forms.TextBox alert;
    }
}

