namespace EcoEnergyRazorPages.Model
{
    public class WaterConsumptionComparer : IComparer<FileWaterConsumption>
    {
        public int Compare(FileWaterConsumption? x, FileWaterConsumption? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.RegionCode.CompareTo(y.RegionCode);
        }

        public int YearRegionCompare(FileWaterConsumption? x, FileWaterConsumption? y)
        {
            int yearComparison = x.Year.CompareTo(y.Year);
            if (yearComparison != 0) return yearComparison > 0 ? -1 : 1;
            return x.RegionCode.CompareTo(y.RegionCode);
        }

        public int HouseholdConsumptionPerCapitaCompare(FileWaterConsumption? x, FileWaterConsumption? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.HouseholdConsumptionPerCapita.CompareTo(y.HouseholdConsumptionPerCapita);
        }
    }
}
