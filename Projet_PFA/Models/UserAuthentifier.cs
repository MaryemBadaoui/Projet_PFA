namespace Projet_PFA.Models
{
    public class UserAuthentifier
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nom { get; set; }
        public string CIN { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }
        public string RIB { get; set; }
        public float Salaire { get; set; }
    }
}
