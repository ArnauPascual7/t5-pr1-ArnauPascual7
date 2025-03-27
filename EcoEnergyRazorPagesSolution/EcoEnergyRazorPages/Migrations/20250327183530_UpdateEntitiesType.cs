using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergyRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitiesType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CDEEBC_ProdNeta",
                table: "EnergyIndicators",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "CDEEBC_ProdDisp",
                table: "EnergyIndicators",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "CDEEBC_DemandaElectr",
                table: "EnergyIndicators",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "CCAC_GasolinaAuto",
                table: "EnergyIndicators",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 118.80000305175781, 4002.39990234375, 2790.199951171875, 2853.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 117.40000152587891, 3734.60009765625, 2691.300048828125, 2745.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.800003051757812, 3331.300048828125, 2662.10009765625, 2691.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 107.5, 3486.800048828125, 2850.89990234375, 2872.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 92.699996948242188, 4423.7001953125, 3340.60009765625, 3412.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.699996948242188, 3916.0, 3082.699951171875, 3145.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.59999847412109, 4146.7001953125, 3116.0, 3143.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.40000152587891, 3551.300048828125, 1930.699951171875, 1967.5999755859375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 107.19999694824219, 3894.60009765625, 3124.10009765625, 3164.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 107.90000152587891, 3997.199951171875, 3239.800048828125, 3292.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 116.40000152587891, 4610.10009765625, 3452.800048828125, 3528.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 108.0, 3743.699951171875, 2871.0, 2932.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.40000152587891, 3965.199951171875, 2457.60009765625, 2498.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 101.90000152587891, 3945.199951171875, 2801.5, 2844.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.099998474121094, 3857.800048828125, 2818.5, 2857.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.800003051757812, 4134.10009765625, 2855.39990234375, 2905.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.699996948242188, 4415.2998046875, 3147.5, 3197.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.099998474121094, 3901.0, 2764.89990234375, 2807.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.80000305175781, 4185.2001953125, 2864.800048828125, 2906.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.599998474121094, 3772.199951171875, 2520.10009765625, 2557.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 101.09999847412109, 3988.89990234375, 2503.10009765625, 2548.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 104.59999847412109, 4064.800048828125, 2804.10009765625, 2852.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 111.09999847412109, 4369.10009765625, 2901.699951171875, 2944.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.5, 3783.89990234375, 2446.699951171875, 2476.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 94.5, 3986.199951171875, 2987.199951171875, 3014.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.5, 4075.89990234375, 3349.89990234375, 3390.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.300003051757812, 4197.0, 2912.5, 2955.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 92.400001525878906, 4306.2998046875, 3127.89990234375, 3189.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.300003051757812, 4477.2998046875, 3755.699951171875, 3805.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.800003051757812, 4163.60009765625, 3359.5, 3403.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.199996948242188, 4161.39990234375, 3473.89990234375, 3522.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.300003051757812, 3969.199951171875, 3292.300048828125, 3321.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.0, 3926.0, 3443.89990234375, 3466.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.599998474121094, 3883.300048828125, 2874.199951171875, 2912.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 104.59999847412109, 4457.2001953125, 2849.5, 2883.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96.0, 3888.89990234375, 3181.0, 3199.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.300003051757812, 3980.60009765625, 2564.39990234375, 2582.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.199996948242188, 3999.699951171875, 2587.39990234375, 2614.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.599998474121094, 4015.199951171875, 2507.39990234375, 2542.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.699996948242188, 4152.5, 2431.10009765625, 2487.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.199996948242188, 4261.7001953125, 2890.5, 2934.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.699996948242188, 3821.60009765625, 2639.89990234375, 2680.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.900001525878906, 3997.0, 2764.60009765625, 2791.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.099998474121094, 3615.89990234375, 2440.800048828125, 2468.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.599998474121094, 3696.5, 2537.699951171875, 2551.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.800003051757812, 3847.800048828125, 2016.4000244140625, 2027.0999755859375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.80000305175781, 4352.39990234375, 2309.60009765625, 2349.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 93.699996948242188, 3929.0, 3318.60009765625, 3340.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.800003051757812, 3841.39990234375, 3052.199951171875, 3071.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.199996948242188, 3872.0, 2328.300048828125, 2351.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.599998474121094, 3902.300048828125, 2519.199951171875, 2565.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.199996948242188, 4189.2001953125, 2516.60009765625, 2573.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.800003051757812, 4397.7998046875, 2705.199951171875, 2776.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.5, 4058.60009765625, 2891.800048828125, 2948.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 83.199996948242188, 4295.7001953125, 2708.5, 2772.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.0, 3726.89990234375, 3076.699951171875, 3119.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.099998474121094, 3838.699951171875, 2983.0, 3013.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.699996948242188, 3852.89990234375, 2793.800048828125, 2815.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96.599998474121094, 4530.89990234375, 3470.300048828125, 3485.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.400001525878906, 3909.199951171875, 3165.89990234375, 3191.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.800003051757812, 3962.699951171875, 3034.800048828125, 3065.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.199996948242188, 3918.5, 3294.10009765625, 3330.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.699996948242188, 4127.7998046875, 3135.5, 3177.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.300003051757812, 4324.10009765625, 3089.0, 3147.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.5, 4389.10009765625, 3023.0, 3076.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.199996948242188, 3945.89990234375, 2412.60009765625, 2437.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.400001525878906, 4248.7998046875, 2325.60009765625, 2352.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.699996948242188, 3589.699951171875, 2357.10009765625, 2380.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.099998474121094, 3891.10009765625, 2484.60009765625, 2498.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.5, 3865.10009765625, 3218.60009765625, 3232.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.599998474121094, 4127.89990234375, 3179.89990234375, 3188.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.199996948242188, 3921.199951171875, 3167.199951171875, 3183.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.5, 4095.699951171875, 3039.60009765625, 3054.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.400001525878906, 3820.60009765625, 2952.300048828125, 2970.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.599998474121094, 3786.0, 2532.5, 2559.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.099998474121094, 3936.39990234375, 2292.199951171875, 2330.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 65.199996948242188, 4260.0, 2859.39990234375, 2896.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 63.799999237060547, 4282.2001953125, 2865.39990234375, 2902.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 74.0, 4023.60009765625, 2927.199951171875, 2965.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.199996948242188, 3588.10009765625, 2764.5, 2815.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.400001525878906, 3783.89990234375, 2938.0, 2977.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.400001525878906, 3936.5, 2456.699951171875, 2483.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.900001525878906, 4032.39990234375, 3122.800048828125, 3148.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.099998474121094, 3765.199951171875, 2981.60009765625, 3009.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.400001525878906, 3833.5, 2837.39990234375, 2856.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 65.300003051757812, 3815.699951171875, 2150.89990234375, 2179.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.400001525878906, 3923.60009765625, 2685.800048828125, 2717.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 58.799999237060547, 4249.2998046875, 3144.60009765625, 3171.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 57.400001525878906, 3870.800048828125, 2870.60009765625, 2898.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.300003051757812, 3883.699951171875, 2991.0, 3034.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.800003051757812, 3643.300048828125, 2278.300048828125, 2321.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.5, 3655.89990234375, 2538.800048828125, 2566.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.0, 3576.199951171875, 3048.300048828125, 3068.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.699996948242188, 4201.7001953125, 3276.699951171875, 3296.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.699996948242188, 3768.39990234375, 3001.699951171875, 3021.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.5, 3711.699951171875, 2856.0, 2873.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.199996948242188, 3781.10009765625, 2849.699951171875, 2862.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 64.199996948242188, 3788.699951171875, 2096.89990234375, 2128.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.099998474121094, 3991.60009765625, 2617.10009765625, 2661.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.599998474121094, 4126.5, 2882.89990234375, 2930.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 59.0, 3774.800048828125, 2616.800048828125, 2662.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.5, 3926.10009765625, 2881.89990234375, 2914.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.0, 3493.699951171875, 2963.10009765625, 2999.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.0, 3653.60009765625, 2373.0, 2408.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.599998474121094, 3682.800048828125, 2361.300048828125, 2384.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.5, 4086.89990234375, 2872.800048828125, 2881.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 74.0, 3676.699951171875, 2550.699951171875, 2562.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.099998474121094, 3846.5, 2727.60009765625, 2731.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.5, 3791.300048828125, 2790.300048828125, 2813.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 61.799999237060547, 3668.199951171875, 2087.5, 2129.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.300003051757812, 3970.60009765625, 2606.300048828125, 2658.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 62.700000762939453, 4226.5, 3058.199951171875, 3109.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 58.299999237060547, 3936.89990234375, 2695.699951171875, 2744.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.0, 4010.10009765625, 3107.39990234375, 3154.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.300003051757812, 3581.10009765625, 2839.89990234375, 2887.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.800003051757812, 3706.39990234375, 2409.10009765625, 2458.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.400001525878906, 3890.699951171875, 2639.89990234375, 2671.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.699996948242188, 4562.2001953125, 3175.5, 3199.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 73.199996948242188, 3820.60009765625, 2974.10009765625, 3015.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 99.599998474121094, 3494.60009765625, 2164.89990234375, 2172.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.900001525878906, 3729.0, 2838.199951171875, 2841.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.300003051757812, 3780.0, 2817.10009765625, 2836.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 63.200000762939453, 3809.60009765625, 2226.5, 2255.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.099998474121094, 3958.10009765625, 2714.699951171875, 2747.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.400001525878906, 4045.800048828125, 2971.39990234375, 3019.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 64.0, 3886.699951171875, 2486.0, 2538.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.099998474121094, 4040.60009765625, 2947.300048828125, 2988.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.199996948242188, 3713.300048828125, 2940.0, 2981.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.699996948242188, 3730.699951171875, 2508.800048828125, 2544.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.0, 3805.10009765625, 2852.300048828125, 2860.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.5, 4294.5, 3002.89990234375, 3009.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.599998474121094, 3927.60009765625, 2908.699951171875, 2916.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.900001525878906, 4005.60009765625, 2832.60009765625, 2837.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.800003051757812, 3795.800048828125, 3082.0, 3094.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.300003051757812, 3892.60009765625, 2389.800048828125, 2414.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.199996948242188, 4042.300048828125, 2773.60009765625, 2787.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.799999237060547, 4427.7998046875, 3111.89990234375, 3133.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.900001525878906, 3766.199951171875, 2684.89990234375, 2709.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.099998474121094, 3985.300048828125, 3061.89990234375, 3081.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.099998474121094, 3581.0, 2860.800048828125, 2877.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.800003051757812, 3874.800048828125, 2658.39990234375, 2666.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.599998474121094, 4148.60009765625, 2642.5, 2648.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.099998474121094, 4365.7998046875, 3217.699951171875, 3218.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.400001525878906, 4062.199951171875, 3147.800048828125, 3153.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.099998474121094, 3820.10009765625, 2934.199951171875, 2941.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.699996948242188, 3842.89990234375, 3034.39990234375, 3041.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.400001525878906, 4040.89990234375, 2567.699951171875, 2578.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.699996948242188, 4153.2001953125, 2987.5, 3020.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 65.800003051757812, 4073.89990234375, 3059.300048828125, 3081.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 62.799999237060547, 3968.89990234375, 2811.39990234375, 2816.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.900001525878906, 4005.60009765625, 2283.0, 2302.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.199996948242188, 3597.10009765625, 2356.89990234375, 2364.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.900001525878906, 3697.60009765625, 2535.60009765625, 2541.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.0, 3785.800048828125, 2545.800048828125, 2548.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.699996948242188, 4301.2998046875, 2599.39990234375, 2600.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.699996948242188, 3959.60009765625, 3104.60009765625, 3105.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.400001525878906, 3767.60009765625, 2922.10009765625, 2923.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.400001525878906, 3737.699951171875, 3003.39990234375, 3009.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.0, 3822.0, 2310.5, 2315.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.099998474121094, 4314.7998046875, 3194.5, 3202.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.900001525878906, 3727.5, 2822.10009765625, 2832.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.199996948242188, 3817.10009765625, 2898.60009765625, 2914.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.0, 3572.0, 2339.60009765625, 2350.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.599998474121094, 3658.699951171875, 2750.10009765625, 2766.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.800003051757812, 3706.60009765625, 3176.39990234375, 3181.60009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 99.0, 4371.60009765625, 3550.0, 3561.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 94.199996948242188, 3901.800048828125, 3351.60009765625, 3358.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.699996948242188, 3729.800048828125, 3043.199951171875, 3052.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.300003051757812, 3476.699951171875, 2047.4000244140625, 2096.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 73.599998474121094, 3791.60009765625, 2772.199951171875, 2776.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.099998474121094, 3713.5, 3062.5, 3072.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.900001525878906, 3823.300048828125, 2352.5, 2378.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 83.400001525878906, 3786.0, 2467.89990234375, 2514.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.699996948242188, 4139.2001953125, 3182.5, 3217.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.199996948242188, 3678.89990234375, 2792.0, 2819.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 52.299999237060547, 3625.10009765625, 2791.5, 2830.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 17.399999618530273, 2931.60009765625, 2694.199951171875, 2747.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 32.299999237060547, 3118.0, 2294.199951171875, 2322.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 62.900001525878906, 3310.89990234375, 2745.5, 2765.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.0, 4058.0, 3157.699951171875, 3175.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.199996948242188, 3769.699951171875, 3013.10009765625, 3026.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.800003051757812, 3547.199951171875, 2763.800048828125, 2780.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.5, 3619.89990234375, 2340.699951171875, 2360.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 54.400001525878906, 3605.10009765625, 2480.0, 2500.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.900001525878906, 3923.699951171875, 2775.60009765625, 2811.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 49.799999237060547, 4139.7001953125, 2846.5, 2883.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 54.599998474121094, 3493.0, 2307.300048828125, 2354.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.699996948242188, 3794.60009765625, 2715.60009765625, 2746.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 88.5, 3582.5, 2190.800048828125, 2202.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.69999694824219, 4196.7998046875, 3376.10009765625, 3412.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 103.30000305175781, 3836.300048828125, 3281.0, 3324.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 93.0, 3645.5, 3226.39990234375, 3274.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.400001525878906, 3398.300048828125, 2731.89990234375, 2773.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.0, 3409.5, 2045.9000244140625, 2080.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.400001525878906, 3587.39990234375, 2835.300048828125, 2895.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.300003051757812, 4228.10009765625, 3558.800048828125, 3620.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.5, 3998.300048828125, 3328.699951171875, 3384.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 111.40000152587891, 4058.800048828125, 2939.800048828125, 3007.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 106.19999694824219, 3722.5, 2332.800048828125, 2387.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 112.59999847412109, 3722.60009765625, 2561.800048828125, 2616.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 114.59999847412109, 3920.300048828125, 2596.60009765625, 2660.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 124.90000152587891, 4252.2001953125, 2923.89990234375, 2990.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 116.69999694824219, 3535.800048828125, 2473.300048828125, 2474.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 106.30000305175781, 3836.5, 3026.699951171875, 3068.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.69999694824219, 3730.800048828125, 2400.800048828125, 2456.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.699996948242188, 3907.5, 3014.0, 3080.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.30000305175781, 4380.7001953125, 3286.39990234375, 3358.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.0, 4184.10009765625, 2866.699951171875, 2886.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.5, 3940.10009765625, 2616.699951171875, 2671.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.199996948242188, 3426.800048828125, 2540.800048828125, 2549.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.699996948242188, 3393.89990234375, 2428.5, 2455.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.900001525878906, 3983.89990234375, 2767.800048828125, 2780.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 92.699996948242188, 3554.0, 2748.300048828125, 2757.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.0, 3599.89990234375, 2864.800048828125, 2870.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.099998474121094, 3416.300048828125, 2419.300048828125, 2436.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.599998474121094, 3680.300048828125, 2169.699951171875, 2186.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.0, 3745.699951171875, 2867.199951171875, 2894.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.699996948242188, 3934.0, 2957.300048828125, 2974.0 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.599998474121094, 3537.5, 2567.0, 2579.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.099998474121094, 3818.0, 2792.10009765625, 2807.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.0, 3430.0, 2567.10009765625, 2591.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.900001525878906, 3536.89990234375, 2396.300048828125, 2417.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96.199996948242188, 3758.10009765625, 3191.89990234375, 3218.699951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.599998474121094, 3652.199951171875, 2453.199951171875, 2475.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 94.5, 3617.300048828125, 2598.89990234375, 2645.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.599998474121094, 3165.10009765625, 2494.39990234375, 2556.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.099998474121094, 3351.199951171875, 2218.89990234375, 2249.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 101.30000305175781, 3562.89990234375, 2525.699951171875, 2548.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 109.69999694824219, 4076.699951171875, 2870.199951171875, 2898.89990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 108.69999694824219, 3716.800048828125, 2864.10009765625, 2891.5 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.699996948242188, 3506.199951171875, 2363.699951171875, 2396.300048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.300003051757812, 3613.300048828125, 2584.60009765625, 2636.39990234375 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.300003051757812, 3931.199951171875, 2742.699951171875, 2786.199951171875 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 88.699996948242188, 3523.199951171875, 2356.5, 2408.800048828125 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96.5, 3509.300048828125, 2584.0, 2652.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.19999694824219, 3315.10009765625, 2532.39990234375, 2597.10009765625 });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.09999847412109, 3318.800048828125, 2068.0, 2139.39990234375 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CDEEBC_ProdNeta",
                table: "EnergyIndicators",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "CDEEBC_ProdDisp",
                table: "EnergyIndicators",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "CDEEBC_DemandaElectr",
                table: "EnergyIndicators",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "CCAC_GasolinaAuto",
                table: "EnergyIndicators",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 118.8f, 4002.4f, 2790.2f, 2853.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 117.4f, 3734.6f, 2691.3f, 2745.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.8f, 3331.3f, 2662.1f, 2691f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 107.5f, 3486.8f, 2850.9f, 2872.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 92.7f, 4423.7f, 3340.6f, 3412.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.7f, 3916f, 3082.7f, 3145.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.6f, 4146.7f, 3116f, 3143.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.4f, 3551.3f, 1930.7f, 1967.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 107.2f, 3894.6f, 3124.1f, 3164.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 107.9f, 3997.2f, 3239.8f, 3292f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 116.4f, 4610.1f, 3452.8f, 3528.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 108f, 3743.7f, 2871f, 2932.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.4f, 3965.2f, 2457.6f, 2498.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 101.9f, 3945.2f, 2801.5f, 2844.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.1f, 3857.8f, 2818.5f, 2857.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.8f, 4134.1f, 2855.4f, 2905.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.7f, 4415.3f, 3147.5f, 3197.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.1f, 3901f, 2764.9f, 2807.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.8f, 4185.2f, 2864.8f, 2906.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.6f, 3772.2f, 2520.1f, 2557.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 101.1f, 3988.9f, 2503.1f, 2548.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 104.6f, 4064.8f, 2804.1f, 2852.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 111.1f, 4369.1f, 2901.7f, 2944.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.5f, 3783.9f, 2446.7f, 2476.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 94.5f, 3986.2f, 2987.2f, 3014.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.5f, 4075.9f, 3349.9f, 3390.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.3f, 4197f, 2912.5f, 2955f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 92.4f, 4306.3f, 3127.9f, 3189.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.3f, 4477.3f, 3755.7f, 3805.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.8f, 4163.6f, 3359.5f, 3403.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.2f, 4161.4f, 3473.9f, 3522.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.3f, 3969.2f, 3292.3f, 3321.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91f, 3926f, 3443.9f, 3466.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.6f, 3883.3f, 2874.2f, 2912.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 104.6f, 4457.2f, 2849.5f, 2883.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96f, 3888.9f, 3181f, 3199.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.3f, 3980.6f, 2564.4f, 2582.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.2f, 3999.7f, 2587.4f, 2614.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.6f, 4015.2f, 2507.4f, 2542.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.7f, 4152.5f, 2431.1f, 2487.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.2f, 4261.7f, 2890.5f, 2934.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.7f, 3821.6f, 2639.9f, 2680.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.9f, 3997f, 2764.6f, 2791.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.1f, 3615.9f, 2440.8f, 2468.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.6f, 3696.5f, 2537.7f, 2551.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.8f, 3847.8f, 2016.4f, 2027.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.8f, 4352.4f, 2309.6f, 2349f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 93.7f, 3929f, 3318.6f, 3340.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.8f, 3841.4f, 3052.2f, 3071.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.2f, 3872f, 2328.3f, 2351.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.6f, 3902.3f, 2519.2f, 2565.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85.2f, 4189.2f, 2516.6f, 2573.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.8f, 4397.8f, 2705.2f, 2776.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.5f, 4058.6f, 2891.8f, 2948.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 83.2f, 4295.7f, 2708.5f, 2772.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81f, 3726.9f, 3076.7f, 3119.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.1f, 3838.7f, 2983f, 3013.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.7f, 3852.9f, 2793.8f, 2815.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96.6f, 4530.9f, 3470.3f, 3485.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.4f, 3909.2f, 3165.9f, 3191.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.8f, 3962.7f, 3034.8f, 3065.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.2f, 3918.5f, 3294.1f, 3330.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.7f, 4127.8f, 3135.5f, 3177.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.3f, 4324.1f, 3089f, 3147.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.5f, 4389.1f, 3023f, 3076.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.2f, 3945.9f, 2412.6f, 2437.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.4f, 4248.8f, 2325.6f, 2352.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.7f, 3589.7f, 2357.1f, 2380.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.1f, 3891.1f, 2484.6f, 2498.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.5f, 3865.1f, 3218.6f, 3232f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.6f, 4127.9f, 3179.9f, 3188.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86.2f, 3921.2f, 3167.2f, 3183.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.5f, 4095.7f, 3039.6f, 3054.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.4f, 3820.6f, 2952.3f, 2970.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.6f, 3786f, 2532.5f, 2559.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.1f, 3936.4f, 2292.2f, 2330.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 65.2f, 4260f, 2859.4f, 2896.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 63.8f, 4282.2f, 2865.4f, 2902.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 74f, 4023.6f, 2927.2f, 2965.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.2f, 3588.1f, 2764.5f, 2815.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.4f, 3783.9f, 2938f, 2977.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.4f, 3936.5f, 2456.7f, 2483.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.9f, 4032.4f, 3122.8f, 3148.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.1f, 3765.2f, 2981.6f, 3009.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.4f, 3833.5f, 2837.4f, 2856.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 65.3f, 3815.7f, 2150.9f, 2179.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.4f, 3923.6f, 2685.8f, 2717.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 58.8f, 4249.3f, 3144.6f, 3171.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 57.4f, 3870.8f, 2870.6f, 2898.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.3f, 3883.7f, 2991f, 3034.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.8f, 3643.3f, 2278.3f, 2321.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.5f, 3655.9f, 2538.8f, 2566.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69f, 3576.2f, 3048.3f, 3068.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.7f, 4201.7f, 3276.7f, 3296f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.7f, 3768.4f, 3001.7f, 3021.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.5f, 3711.7f, 2856f, 2873.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.2f, 3781.1f, 2849.7f, 2862.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 64.2f, 3788.7f, 2096.9f, 2128.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.1f, 3991.6f, 2617.1f, 2661.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.6f, 4126.5f, 2882.9f, 2930.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 59f, 3774.8f, 2616.8f, 2662.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.5f, 3926.1f, 2881.9f, 2914.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67f, 3493.7f, 2963.1f, 2999.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69f, 3653.6f, 2373f, 2408f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.6f, 3682.8f, 2361.3f, 2384.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.5f, 4086.9f, 2872.8f, 2881.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 74f, 3676.7f, 2550.7f, 2562.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.1f, 3846.5f, 2727.6f, 2731.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.5f, 3791.3f, 2790.3f, 2813.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 61.8f, 3668.2f, 2087.5f, 2129.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.3f, 3970.6f, 2606.3f, 2658.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 62.7f, 4226.5f, 3058.2f, 3109.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 58.3f, 3936.9f, 2695.7f, 2744.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67f, 4010.1f, 3107.4f, 3154.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.3f, 3581.1f, 2839.9f, 2887.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.8f, 3706.4f, 2409.1f, 2458.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.4f, 3890.7f, 2639.9f, 2671.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.7f, 4562.2f, 3175.5f, 3199.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 73.2f, 3820.6f, 2974.1f, 3015.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 99.6f, 3494.6f, 2164.9f, 2172.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.9f, 3729f, 2838.2f, 2841.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.3f, 3780f, 2817.1f, 2836.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 63.2f, 3809.6f, 2226.5f, 2255.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.1f, 3958.1f, 2714.7f, 2747.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.4f, 4045.8f, 2971.4f, 3019.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 64f, 3886.7f, 2486f, 2538.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.1f, 4040.6f, 2947.3f, 2988.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.2f, 3713.3f, 2940f, 2981.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.7f, 3730.7f, 2508.8f, 2544.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75f, 3805.1f, 2852.3f, 2860.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.5f, 4294.5f, 3002.9f, 3009.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.6f, 3927.6f, 2908.7f, 2916.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.9f, 4005.6f, 2832.6f, 2837.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.8f, 3795.8f, 3082f, 3094.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.3f, 3892.6f, 2389.8f, 2414.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.2f, 4042.3f, 2773.6f, 2787.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.8f, 4427.8f, 3111.9f, 3133f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 60.9f, 3766.2f, 2684.9f, 2709.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.1f, 3985.3f, 3061.9f, 3081.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 70.1f, 3581f, 2860.8f, 2877.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.8f, 3874.8f, 2658.4f, 2666.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.6f, 4148.6f, 2642.5f, 2648.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.1f, 4365.8f, 3217.7f, 3218.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.4f, 4062.2f, 3147.8f, 3153.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.1f, 3820.1f, 2934.2f, 2941f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.7f, 3842.9f, 3034.4f, 3041.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 66.4f, 4040.9f, 2567.7f, 2578.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.7f, 4153.2f, 2987.5f, 3020.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 65.8f, 4073.9f, 3059.3f, 3081.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 62.8f, 3968.9f, 2811.4f, 2816.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.9f, 4005.6f, 2283f, 2302.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.2f, 3597.1f, 2356.9f, 2364.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.9f, 3697.6f, 2535.6f, 2541.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81f, 3785.8f, 2545.8f, 2548.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.7f, 4301.3f, 2599.4f, 2600.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.7f, 3959.6f, 3104.6f, 3105.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.4f, 3767.6f, 2922.1f, 2923.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.4f, 3737.7f, 3003.4f, 3009f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77f, 3822f, 2310.5f, 2315.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 72.1f, 4314.8f, 3194.5f, 3202.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 68.9f, 3727.5f, 2822.1f, 2832.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.2f, 3817.1f, 2898.6f, 2914.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80f, 3572f, 2339.6f, 2350.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 82.6f, 3658.7f, 2750.1f, 2766f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.8f, 3706.6f, 3176.4f, 3181.6f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 99f, 4371.6f, 3550f, 3561.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 94.2f, 3901.8f, 3351.6f, 3358.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.7f, 3729.8f, 3043.2f, 3052.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.3f, 3476.7f, 2047.4f, 2096.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 73.6f, 3791.6f, 2772.2f, 2776.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.1f, 3713.5f, 3062.5f, 3072f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.9f, 3823.3f, 2352.5f, 2378f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 83.4f, 3786f, 2467.9f, 2514.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.7f, 4139.2f, 3182.5f, 3217.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 77.2f, 3678.9f, 2792f, 2819.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 52.3f, 3625.1f, 2791.5f, 2830f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 17.4f, 2931.6f, 2694.2f, 2747.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 32.3f, 3118f, 2294.2f, 2322.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 62.9f, 3310.9f, 2745.5f, 2765.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91f, 4058f, 3157.7f, 3175.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.2f, 3769.7f, 3013.1f, 3026.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.8f, 3547.2f, 2763.8f, 2780.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 76.5f, 3619.9f, 2340.7f, 2360.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 54.4f, 3605.1f, 2480f, 2500.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 67.9f, 3923.7f, 2775.6f, 2811.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 49.8f, 4139.7f, 2846.5f, 2883.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 54.6f, 3493f, 2307.3f, 2354.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.7f, 3794.6f, 2715.6f, 2746.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 88.5f, 3582.5f, 2190.8f, 2202.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 102.7f, 4196.8f, 3376.1f, 3412.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 103.3f, 3836.3f, 3281f, 3324.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 93f, 3645.5f, 3226.4f, 3274f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.4f, 3398.3f, 2731.9f, 2773f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86f, 3409.5f, 2045.9f, 2080.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.4f, 3587.4f, 2835.3f, 2895.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.3f, 4228.1f, 3558.8f, 3620.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.5f, 3998.3f, 3328.7f, 3384.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 111.4f, 4058.8f, 2939.8f, 3007.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 106.2f, 3722.5f, 2332.8f, 2387.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 112.6f, 3722.6f, 2561.8f, 2616.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 114.6f, 3920.3f, 2596.6f, 2660.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 124.9f, 4252.2f, 2923.9f, 2990.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 116.7f, 3535.8f, 2473.3f, 2474.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 106.3f, 3836.5f, 3026.7f, 3068.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.7f, 3730.8f, 2400.8f, 2456.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.7f, 3907.5f, 3014f, 3080.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.3f, 4380.7f, 3286.4f, 3358.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81f, 4184.1f, 2866.7f, 2886.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 75.5f, 3940.1f, 2616.7f, 2671f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 71.2f, 3426.8f, 2540.8f, 2549.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 79.7f, 3393.9f, 2428.5f, 2455.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.9f, 3983.9f, 2767.8f, 2780.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 92.7f, 3554f, 2748.3f, 2757.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87f, 3599.9f, 2864.8f, 2870.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 87.1f, 3416.3f, 2419.3f, 2436f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 81.6f, 3680.3f, 2169.7f, 2186.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 85f, 3745.7f, 2867.2f, 2894.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 69.7f, 3934f, 2957.3f, 2974f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 78.6f, 3537.5f, 2567f, 2579.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 84.1f, 3818f, 2792.1f, 2807.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 86f, 3430f, 2567.1f, 2591.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 91.9f, 3536.9f, 2396.3f, 2417.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96.2f, 3758.1f, 3191.9f, 3218.7f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 80.6f, 3652.2f, 2453.2f, 2475.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 94.5f, 3617.3f, 2598.9f, 2645.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 90.6f, 3165.1f, 2494.4f, 2556.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 98.1f, 3351.2f, 2218.9f, 2249.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 101.3f, 3562.9f, 2525.7f, 2548.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 109.7f, 4076.7f, 2870.2f, 2898.9f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 108.7f, 3716.8f, 2864.1f, 2891.5f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 97.7f, 3506.2f, 2363.7f, 2396.3f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 95.3f, 3613.3f, 2584.6f, 2636.4f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 89.3f, 3931.2f, 2742.7f, 2786.2f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 88.7f, 3523.2f, 2356.5f, 2408.8f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 96.5f, 3509.3f, 2584f, 2652.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 100.2f, 3315.1f, 2532.4f, 2597.1f });

            migrationBuilder.UpdateData(
                table: "EnergyIndicators",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CCAC_GasolinaAuto", "CDEEBC_DemandaElectr", "CDEEBC_ProdDisp", "CDEEBC_ProdNeta" },
                values: new object[] { 105.1f, 3318.8f, 2068f, 2139.4f });
        }
    }
}
