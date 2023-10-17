using System.ComponentModel.DataAnnotations;

namespace Noested.Models
{
    public class Customer
    {
        [Key] // Primærnøkkel
        public int KundeNr { get; set; }
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }
        public string Adresse { get; set; }
        public string Postnr { get; set; }
        public string Poststed { get; set; }
        public string Telefon { get; set; }
        public string Epost { get; set; }
    }

}
