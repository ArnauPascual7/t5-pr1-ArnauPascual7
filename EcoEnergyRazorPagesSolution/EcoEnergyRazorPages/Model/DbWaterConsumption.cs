using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcoEnergyRazorPages.Model
{
    public class DbWaterConsumption
    {
        const string MsgRequiredError = "Aquest camp és obligatori";
        const string MsgMinValue0Error = "El valor ha de ser major a 0";

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = MsgRequiredError), Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public int RegionCode { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        public string? RegionName { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 2025, ErrorMessage = $"{MsgMinValue0Error} i igual o menor a l'any actual")]
        public int Year { get; set; }
        [Required(ErrorMessage = MsgRequiredError), Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float HouseholdConsumptionPerCapita { get; set; }
    }
}
