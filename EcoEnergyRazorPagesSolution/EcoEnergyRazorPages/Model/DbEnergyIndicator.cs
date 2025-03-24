using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcoEnergyRazorPages.Model
{
    public class DbEnergyIndicator
    {
        const string MsgRequiredError = "El valor ha de ser major a 0";
        const string MsgMinValue0Error = "Aquest camp és obligatori";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public int Year { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float CDEEBC_ProdNeta { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float CCAC_GasolinaAuto { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float CDEEBC_DemandaElectr { get; set; }
        [Required(ErrorMessage = MsgRequiredError)]
        [Range(0, 9999999999, ErrorMessage = MsgMinValue0Error)]
        public float CDEEBC_ProdDisp { get; set; }

    }
}
