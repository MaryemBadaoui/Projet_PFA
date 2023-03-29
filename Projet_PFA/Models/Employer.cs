namespace Projet_PFA.Models
{
    public class Employer : UserAuthentifier
    {
        public ICollection<Pointage> Pointages { get; set; }
        public ICollection<HeuresSupp> HeuresSupps { get; set; }
        public ICollection<Retard> Retards { get; set; }
        public ICollection<Absence> Absences { get; set; }

    }
}
