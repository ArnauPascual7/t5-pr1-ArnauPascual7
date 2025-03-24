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
        public List<FileEnergyIndicator> EnergyIndicators { get; set; } = new List<FileEnergyIndicator>();
        public void OnGet()
        {
            const string MsgDataError = "Error de càrrega de dades";
            const string CsvFileName = "indicadors_energetics_cat.csv";
            const string JsonFileName = "indicadors_energetics_cat.json";
            const string CsvFilePath = @"ModelData\" + CsvFileName;
            const string JsonFilePath = @"ModelData\" + JsonFileName;

            if (SysIO.File.Exists(CsvFilePath) && SysIO.File.Exists(JsonFilePath))
            {
                EnergyIndicators = FilesHelper.ReadCsv<FileEnergyIndicator>(CsvFilePath);
                List<FileEnergyIndicator> jsonEnergyIndicators = FilesHelper.ReadJsonList<FileEnergyIndicator>(JsonFilePath);

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
