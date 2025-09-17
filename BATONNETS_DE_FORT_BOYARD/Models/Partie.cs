using System;
using System.Collections.Generic;

namespace BATONNETS_DE_FORT_BOYARD.Models;

public partial class Partie
{
    public int IdPartie { get; set; }

    public string NomDePartie { get; set; } = null!;

    public bool TourJoueur { get; set; }

    public int NombreBatonnet { get; set; }

    public int BattonetRetiréEncours { get; set; }

    public string? CodePartie { get; set; }

    public bool EstPartiePrivee { get; set; }

    public int IdCompte2 { get; set; }

    public int IdCompte1 { get; set; }

    public virtual Compte IdCompte1Navigation { get; set; } = null!;

    public virtual Compte IdCompte2Navigation { get; set; } = null!;
}
