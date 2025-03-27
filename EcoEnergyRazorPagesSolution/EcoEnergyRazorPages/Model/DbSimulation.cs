using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EcoEnergyRazorPages.Model
{
    public class DbSimulation
    {
        const string MsgRequiredError = "Aquest camp és obligatori";
        const string MsgMinValue0Error = "El valor ha de ser major a 0";
        const string MsgValue03IntervalError = "Aquest valor ha de ser entre 0 i 3";
        const string MsgSystemTypeError = "El sistema ha de ser Solar, Eolic o Hidroelectric";

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [RegularExpression("((?i)(^|, )(Solar|Eolic|Hidroelectric))+$", ErrorMessage = MsgSystemTypeError)]
        public string? SystemType { get; set; }
        [MaybeNull, Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float? SunHours { get; set; }
        [MaybeNull, Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float? WindVelocity { get; set; }
        [MaybeNull, Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float? WaterFlow { get; set; }
        [Required(ErrorMessage = MsgRequiredError), Range(0, 3, ErrorMessage = MsgValue03IntervalError)]
        public float Ratio { get; set; }
        [Required(ErrorMessage = MsgRequiredError), Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float EnergyGen { get; set; }
        [Required(ErrorMessage = MsgRequiredError), Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float KWHCost { get; set; }
        [Required(ErrorMessage = MsgRequiredError), Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float KWHPrice { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
