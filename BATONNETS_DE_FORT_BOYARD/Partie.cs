using System;
using System.Collections.Generic;

namespace BATONNETS_DE_FORT_BOYARD.Models;

public partial class Partie
{
    public string NomDePartieEstPartiePrivee
    {
        get
        {
            string PartiePrivee;
            if (EstPartiePrivee = false)
            {
                PartiePrivee = "";
            }
            else
            {
                PartiePrivee = "(Privée)";
            }
            return IdPartie + " - " + NomDePartie + PartiePrivee ;
        }
    }
}
