using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Noested.Models
{
    public class Checklist
    {
        [Key] // Primærnøkkel
        public int SjekklisteID { get; set; }

        [ForeignKey("ServiceOrder")] // Fremmednøkkel som refererer til serviceordre-tabellen
        public int OrdreNr { get; set; }
        public string GodkjentAv { get; set; }
        public string UtarbeidetAv { get; set; }
        public Tilstand MekBremser { get; set; }
        public Tilstand MekTrommellager { get; set; }
        public Tilstand MekOpplagringPTO { get; set; }
        public Tilstand MekWire { get; set; }
        public Tilstand MekKjedestrammer { get; set; }
        public Tilstand MekPinionlager { get; set; }
        public Tilstand MekClutch { get; set; }
        public Tilstand MekKjedehjulkiler { get; set; }
        public Tilstand HydSylinder { get; set; }
        public Tilstand HydSlanger { get; set; }
        public Tilstand HydHydraulikkblokk { get; set; }
        public Tilstand HydTankolje { get; set; }
        public Tilstand HydGirboksolje { get; set; }
        public Tilstand HydBremsesylinder { get; set; }
        public Tilstand ElLedningsnett { get; set; }
        public Tilstand ElRadio { get; set; }
        public Tilstand ElKnappekasse { get; set; }
        public Tilstand TrykkSjekkBar { get; set; }
        public Tilstand TestVinsj { get; set; }
        public Tilstand TestTrekkraft { get; set; }
        public Tilstand TestBremsekraft { get; set; }
        public Tilstand Kommentar { get; set; }
        public Tilstand Signatur { get; set; }
        public DateTime DatoFullfort { get; set; }

    }

    public enum Tilstand
    {
        OK,
        BorSkiftes,
        Defekt
    }
}
