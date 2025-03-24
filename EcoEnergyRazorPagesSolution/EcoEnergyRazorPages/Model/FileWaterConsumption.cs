using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergyRazorPages.Model
{
    [Table("WaterConsumptions")]
    public class FileWaterConsumption : IComparable<FileWaterConsumption>
    {
        public int Year { get; set; }
        public int RegionCode { get; set; }
        public string? RegionName { get; set; }
        public int Population { get; set; }
        public int DomesticNetwork { get; set; }
        public int EconomicActivitiesOwnSources { get; set; }
        public int Total { get; set; }
        public float HouseholdConsumptionPerCapita { get; set; }

        public void SetWaterConsumptionCalculation()
        {
            Total = DomesticNetwork + EconomicActivitiesOwnSources;
            HouseholdConsumptionPerCapita = float.Round((float)Total / Population, 2);
        }
        public int CompareTo(FileWaterConsumption other)
        {
            return Year.CompareTo(other.Year);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            FileWaterConsumption other = (FileWaterConsumption)obj;
            return this.RegionCode.Equals(other.RegionCode) && this.Year.Equals(other.Year);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(RegionCode, Year);
        }
    }
}
