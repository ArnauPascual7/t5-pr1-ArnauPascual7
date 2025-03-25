using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EcoEnergyRazorPages.Model
{
    public class DbSimulation
    {
        const string MsgRequiredError = "El valor ha de ser major a 0";
        const string MsgMinValue0Error = "Aquest camp és obligatori";
        const string MsgValue03IntervalError = "Aquest valor ha de ser entre 0 i 3";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        public string? SystemType { get; set; }
        [MaybeNull]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double? SunHours { get; set; }
        [MaybeNull]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double? WindVelocity { get; set; }
        [MaybeNull]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double? WaterFlow { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 3, ErrorMessage = MsgValue03IntervalError)]
        public double Ratio { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double EnergyGen { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double KWHCost { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double KWHPrice { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
