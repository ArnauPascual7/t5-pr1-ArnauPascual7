using System.Diagnostics;
using System.Text.Json;
using EcoEnergyRazorPages.Model;
using EcoEnergyRazorPages.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SysIO = System.IO;

namespace EcoEnergyRazorPages.Pages
{
    public class EnergyIndicatorsModel : PageModel
    {
        public string? MsgFileError { get; set; }
        public List<EnergyIndicator> EnergyIndicators { get; set; } = new List<EnergyIndicator>();
        public void OnGet()
        {
            const string MsgDataError = "Error de càrrega de dades";
            const string CsvFileName = "indicadors_energetics_cat.csv";
            const string JsonFileName = "indicadors_energetics_cat.json";
            const string CsvFilePath = @"ModelData\" + CsvFileName;
            const string JsonFilePath = @"ModelData\" + JsonFileName;

            if (SysIO.File.Exists(CsvFilePath) && SysIO.File.Exists(JsonFilePath))
            {
                EnergyIndicators = FilesHelper.ReadCsv<EnergyIndicator>(CsvFilePath);
                List<EnergyIndicator> jsonEnergyIndicators = FilesHelper.ReadJsonList<EnergyIndicator>(JsonFilePath);

                if (jsonEnergyIndicators.Any())
                {
                    EnergyIndicators.AddRange(jsonEnergyIndicators);
                }
                EnergyIndicators.Sort();
            }
            else
            {
                MsgFileError = MsgDataError;
            }
        }
    }
}
