using TowerStripEmulator.Lib.Enums;

namespace TowerStripEmulator.Lib.Models
{
    public class Strip
    {
        public StripType Type { get; set; }
        public string Callsign { get; set; } = string.Empty;
        public int NumberOfAircraft { get; set; }
        public string TypeOfAircraft { get; set; } = string.Empty;
        public WakeTurbulenceCategory WTC { get; set; }
        public string ADEP { get; set; } = string.Empty;
        public string ADES { get; set; } = string.Empty;
        public DateTime ETD { get; set; }
        public DateTime ATD { get; set; }
        public DateTime ETA { get; set; }
        public DateTime ATA { get; set; }
        public string SSR { get; set; } = string.Empty;
        public string RWY { get; set; } = string.Empty;
        public string DepartureType { get; set; } = string.Empty;
        public int DepartureLevel { get; set; }
        public string DepartureFrequency { get; set; } = string.Empty;
        public DepartureClearanceStep ClearanceStep { get; set; }
        public string ArrivalType { get; set; } = string.Empty;
        public LandingType? LandingType { get; set; } = null;
        public string Info { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string StripBay { get; set; } = string.Empty;
    }
}
