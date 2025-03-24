using EcoEnergyRazorPages.Model;

namespace EcoEnergyRazorPages.Tools
{
    public static class WaterConsumptionStatsHelper
    {
        public static List<FileWaterConsumption> CheckWaterConsumptionMostRecentYearList(List<FileWaterConsumption> waterConsumptions)
        {
            List<FileWaterConsumption> mostRecentYearWaterConsumptions = new List<FileWaterConsumption>();
            int year = CheckWaterConsumptionMostRecentYear(waterConsumptions);
            foreach (FileWaterConsumption waterCons in waterConsumptions)
            {
                if (waterCons.Year == year)
                {
                    mostRecentYearWaterConsumptions.Add(waterCons);
                }
            }
            return mostRecentYearWaterConsumptions;
        }
        public static int CheckWaterConsumptionMostRecentYear(List<FileWaterConsumption> waterConsumptions)
        {
            return waterConsumptions.Select(waterCons => waterCons.Year).Max();
        }
        public static List<FileWaterConsumption> CheckSusWaterConsumptionList(List<FileWaterConsumption> waterConsumptions, int digits)
        {
            List<FileWaterConsumption> susWaterConsumption = new List<FileWaterConsumption>();
            foreach (FileWaterConsumption waterCons in waterConsumptions)
            {
                if (waterCons.Total.ToString().Length > digits)
                {
                    susWaterConsumption.Add(waterCons);
                }
            }
            return susWaterConsumption;
        }
        public static List<FileWaterConsumption> CheckWaterConsumptionLast5YearsList(List<FileWaterConsumption> waterConsumptions)
        {
            List<FileWaterConsumption> waterConsumptionLast5Years = new List<FileWaterConsumption>();
            int lastYear = CheckWaterConsumptionMostRecentYear(waterConsumptions);
            foreach (FileWaterConsumption waterCons in waterConsumptions)
            {
                if (waterCons.Year > lastYear - 5)
                {
                    waterConsumptionLast5Years.Add(waterCons);
                }
            }
            return waterConsumptionLast5Years;
        }
        public static List<FileWaterConsumption> CheckWaterConsumptionIncreasingTrendList(List<FileWaterConsumption> waterConsumptionsLast5Years)
        {
            List<FileWaterConsumption> waterConsumptions = new List<FileWaterConsumption>();
            for (int i = 1; i <= CheckHigherRegionCode(waterConsumptionsLast5Years); i++)
            {
                int count = 0;
                List<FileWaterConsumption> regionWaterConsumptions = waterConsumptionsLast5Years
                    .FindAll(waterCons => waterCons.RegionCode == i);
                regionWaterConsumptions.Sort();
                for (int j = 0; j < regionWaterConsumptions.Count - 1; j++)
                {
                    if (regionWaterConsumptions[j].Total < regionWaterConsumptions[j + 1].Total)
                    {
                        count++;
                    }
                }
                if (count >= 4)
                {
                    waterConsumptions.Add(new FileWaterConsumption
                    {
                        RegionCode = regionWaterConsumptions[0].RegionCode,
                        RegionName = regionWaterConsumptions[0].RegionName
                    });
                }
            }
            return waterConsumptions;
        }
        public static int CheckHigherRegionCode(List<FileWaterConsumption> waterConsumptions)
        {
            int regionCode = 0;
            for (int i = 0; i < waterConsumptions.Count; i++)
            {
                FileWaterConsumption waterCons = waterConsumptions[i];
                regionCode = waterCons.RegionCode > regionCode ? waterCons.RegionCode : regionCode;
            }
            return regionCode;
        }
    }
}
