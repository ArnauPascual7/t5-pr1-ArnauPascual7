using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using EcoEnergyRazorPages.Model;
using EcoEnergyRazorPages.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SysIO = System.IO;
using Stats = EcoEnergyRazorPages.Tools.WaterConsumptionStatsHelper;

namespace EcoEnergyRazorPages.Pages
{
    public class WaterConsumptionModel : PageModel
    {
        public string? MsgFileError { get; set; }
        public List<FileWaterConsumption> WaterConsumptions { get; set; } = new List<FileWaterConsumption>();
        public void OnGet()
        {
            const string MsgDataError = "Error de càrrega de dades";
            const string CsvFileName = "consum_aigua_cat_per_comarques.csv";
            const string XmlFileName = "consum_aigua_cat_per_comarques.xml";
            const string CsvFilePath = @"ModelData\" + CsvFileName;
            const string XmlFilePath = @"ModelData\" + XmlFileName;

            if (SysIO.File.Exists(CsvFilePath) && SysIO.File.Exists(XmlFilePath))
            {
                WaterConsumptions = FilesHelper.ReadCsv<FileWaterConsumption>(CsvFilePath);
                List<FileWaterConsumption> xmlWaterConsumptions = FilesHelper.ReadXMLWaterConsumption(XmlFilePath);

                if (xmlWaterConsumptions.Any())
                {
                    WaterConsumptions.AddRange(xmlWaterConsumptions);
                }
                WaterConsumptions.Sort(new WaterConsumptionComparer().YearRegionCompare);
            }
            else
            {
                MsgFileError = MsgDataError;
            }
        }
    }
}
