using System;
using System.Collections.Generic;

namespace BATONNETS_DE_FORT_BOYARD.Models;

public partial class Compte
{
    public int IdCompte { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public string Pseudo { get; set; } = null!;

    public int? NombreDeVictoire { get; set; }

    public int? NombreDeDefaite { get; set; }

    public virtual ICollection<Partie> PartieIdCompte1Navigations { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieIdCompte2Navigations { get; set; } = new List<Partie>();
}
