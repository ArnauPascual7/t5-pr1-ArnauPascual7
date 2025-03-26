using EcoEnergyRazorPages.Model;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergyRazorPages.Tools
{
    public static class ModelBuilderHelper
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            const string csvWaterConsFile = "consum_aigua_cat_per_comarques.csv";
            const string csvWaterConsPath = @"ModelData\" + csvWaterConsFile;
            const string csvEnerIndFile = "indicadors_energetics_cat.csv";
            const string csvEnerIndPath = @"ModelData\" + csvEnerIndFile;

            List<FileWaterConsumption> fileWaterCons = FilesHelper.ReadCsv<FileWaterConsumption>(csvWaterConsPath);
            List<FileEnergyIndicator> fileEnerInd = FilesHelper.ReadCsv<FileEnergyIndicator>(csvEnerIndPath);
            List<DbWaterConsumption> dbWaterCons = new List<DbWaterConsumption>();
            List<DbEnergyIndicator> dbEnerind = new List<DbEnergyIndicator>();

            for (int i = 1; i < fileWaterCons.Count; i++)
            {
                DbWaterConsumption newWaterCons = new DbWaterConsumption()
                {
                    Id = i,
                    RegionCode = fileWaterCons[i].RegionCode,
                    RegionName = fileWaterCons[i].RegionName,
                    Year = fileWaterCons[i].Year,
                    HouseholdConsumptionPerCapita = fileWaterCons[i].HouseholdConsumptionPerCapita
                };
                dbWaterCons.Add(newWaterCons);
            }
            for (int i = 1; i < fileEnerInd.Count; i++)
            {
                DbEnergyIndicator newEnerInd = new DbEnergyIndicator()
                {
                    Id = i,
                    Year = fileEnerInd[i].Data.Year,
                    CDEEBC_ProdNeta = fileEnerInd[i].CDEEBC_ProdNeta,
                    CCAC_GasolinaAuto = fileEnerInd[i].CCAC_GasolinaAuto,
                    CDEEBC_DemandaElectr = fileEnerInd[i].CDEEBC_DemandaElectr,
                    CDEEBC_ProdDisp = fileEnerInd[i].CDEEBC_ProdDisp
                };
                dbEnerind.Add(newEnerInd);
            }

            modelBuilder.Entity<DbWaterConsumption>().HasData(dbWaterCons);
            modelBuilder.Entity<DbEnergyIndicator>().HasData(dbEnerind);
        }
    }
}
