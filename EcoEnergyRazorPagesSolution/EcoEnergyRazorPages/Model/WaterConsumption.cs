using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergyRazorPages.Model
{
    [Table("WaterConsumptions")]
    public class WaterConsumption : IComparable<WaterConsumption>
    {
        const string MsgRequiredError = "El valor ha de ser major a 0";
        const string MsgMinValue0Error = "Aquest camp és obligatori";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public int RegionCode { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        public string? RegionName { get; set; }
        public int Year { get; set; } = 2024; //DateTime.Now.Year
        public float HouseholdConsumptionPerCapita { get; set; }


        // Unused Properties
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public int Population { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public int DomesticNetwork { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public int EconomicActivitiesOwnSources { get; set; }
        public int Total { get; set; }


        public void SetWaterConsumptionCalculation()
        {
            Total = DomesticNetwork + EconomicActivitiesOwnSources;
            HouseholdConsumptionPerCapita = float.Round((float)Total / Population, 2);
        }
        public int CompareTo(WaterConsumption other)
        {
            return Year.CompareTo(other.Year);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            WaterConsumption other = (WaterConsumption)obj;
            return this.RegionCode.Equals(other.RegionCode) && this.Year.Equals(other.Year);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(RegionCode, Year);
        }
    }
}
