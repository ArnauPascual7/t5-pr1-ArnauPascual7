using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergyRazorPages.Model
{
    public enum SystemType
    {
        SolarSystem = 1, WindSystem = 2, HydroelectricSystem = 3
    }
    public class Simulation
    {
        const string MsgRequiredError = "El valor ha de ser major a 0";
        const string MsgMinValue0Error = "Aquest camp és obligatori";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SysTypeId
        {
            get
            {
                return (int)this.SysType;
            }
            set
            {
                this.SysType = (SystemType)value;
            }
        }
        public SystemType SysType { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double? SunHours { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double? WindVelocity { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public double? WaterFlow { get; set; }
        public double Ratio { get; set; }
        public double EnergyGen { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public decimal KWHCost { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public decimal KWHPrice { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;


        // Unused Properties
        /*public double ConfigPar { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalPrice { get; set; }*/
    }
}
