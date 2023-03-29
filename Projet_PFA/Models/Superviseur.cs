namespace Projet_PFA.Models
{
    public class Superviseur: UserAuthentifier
    {
        public Superviseur superviseur { get; set; }
        public int SuperviseurId { get; set; }
        public Directeur Directeur { get; set; }
        public int DirecteurId { get; set; }
        public ICollection<Pointage> Pointages { get; set; }
        public ICollection<HeuresSupp> HeuresSupps { get; set; }
        public ICollection<Retard> Retards { get; set; }
        public ICollection<Absence> Absences { get; set; }
    }
}
