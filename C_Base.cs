using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.ComponentModel;

namespace TP_Philippe_Maxence
{
    class C_Base
    {
        public BindingList<C_Mesure> Les_Mesures = new BindingList<C_Mesure>();

       

        public void Sauvegarde_Toi()
        {
            string Donnes_Serialiser = JsonSerializer.Serialize<BindingList<C_Mesure>>(Les_Mesures);
            File.WriteAllText("Mesure.json", Donnes_Serialiser);
        }
        public void Charge_Toi()
        {
            string Donnes_Serialiser;

            if (File.Exists("Mesure.json") == true)
            {
                Donnes_Serialiser = File.ReadAllText("Mesure.json");

                Les_Mesures = JsonSerializer.Deserialize<BindingList<C_Mesure>>(Donnes_Serialiser);
            }
        }

    }
}
