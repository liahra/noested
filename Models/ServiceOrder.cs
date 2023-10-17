using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Noested.Models
{
    public class ServiceOrder
    {
        // Primærnøkkel
        [Key]
        public int OrdreNr { get; set; }
        // Fremmednøkkel som refererer til kunde-tabellen
        [ForeignKey("Customer")]
        public int KundeNr { get; set; }
        public DateTime OrdreMottatt { get; set; }
        public DateTime OrdreFullfort { get; set; }
        public string Serienummer { get; set; }
        public string ProduktType { get; set; }
        public string Aarsmodell { get; set; }
        public GarantiType Garanti { get; set; }
        public string Kundeavtale { get; set; }
        public string Beskrivelse { get; set; }
        public string AvlagteDeler { get; set; }
        public string UtskiftetDelerRetur { get; set; }
        public string Frakt { get; set; }
        // public byte[] Foto { get; set; } <- Legges til senere
        public bool ErAktiv { get; set; }

    }

    public enum GarantiType
    {
        Ingen,
        Delvis,
        Full
    }


}
