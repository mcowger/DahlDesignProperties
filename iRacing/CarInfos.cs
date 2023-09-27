using System.Collections.Generic;

namespace DahlDesign.Plugin.iRacing
{

    public class CarInfo
    {
        public List<Cars> carInfo;

        public CarInfo() {
            carInfo = new List<Cars>{};
            
            carInfo.Add(new Cars("Dallara F312 F3", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "BiasOnly", 7200, 7100, 7050, 7000, 6950, 0, 0, 7340, 1932, 25.9, 25.5, 20.0, 32.0, 1, 90, 1, 90, false, 0, 1, 1, 1, 1, 7.0, false, 0, 0, 6, 1.5, CrewType.All, true, false, AnimationType.FormulaRenault, 0.35));
            carInfo.Add(new Cars("Dallara P217 LMP2", true, false, false, true, -1, false, true, false, -1, -1, -1, false, false, "Dallara LMP2", "Dallara LMP2", 8400, 8500, 8600, 8640, 8640, 0, 0, 8690, 2400, 41.3, 41.1, 41.3, 65, 1, 100, 1, 100, false, 0, 1.2, 1.05, 1.1, 1.1, 2.38, false, 0, 0, 10.9, 1.2, CrewType.FrontRear, false, true, AnimationType.LMP2, 0.3));
            carInfo.Add(new Cars("Porsche 919 2016", true, false, false, true, -1, false, true, false, -1, 1, 12, true, false, "Porsche 919", "Porsche 919", 8500, 8500, 8600, 8700, 8700, 8700, 0, 9003, 3000, 42.8, 42.7, 42.8, 53.2, 1, 100, 1, 100, false, 0, 1.2, 1.1, 1.1, 1.4, 3, false, 0, 0, 7.4, 1.4, CrewType.FrontRear, false, true, AnimationType.Porsche, 0.5));
            carInfo.Add(new Cars("Mclaren MP4-30", true, true, false, false, -1, false, false, false, -1, -1, -1, false, false, "Mclaren F1", "Mclaren F1", 12400, 12400, 12160, 11850, 11450, 11200, 11300, 12850, 3050, 60.0, 0, 0, 0, 1, 40, 1, 80, true, 70, 1.25, 1.1, 1.2, 1.3, 0, false, 0, 0, 3.2, 0, CrewType.All, true, false, AnimationType.MclarenF1, 1.1));
            carInfo.Add(new Cars("Mercedes W12", true, true, false, false, -1, false, false, false, -1, -1, -1, false, false, "Mercedes W12", "Mercedes W12", 11800, 11600, 11700, 11800, 11800, 11800, 11900, 12960, 4000, 54.5, 54.1, 0, 0, 1, 5, 1, 40, true, 50, 1.25, 1.1, 1.2, 1.3, 0, false, 0, 0, 3.2, 0, CrewType.All, true, false, AnimationType.MclarenF1, 1.05));
            carInfo.Add(new Cars("Mercedes AMG GT3", false, false, true, false, -1, true, true, true, 12, 3, 1, false, false, "Mercedes AMG GT3", "GT3", 7350, 7130, 6780, 6570, 6530, 0, 0, 7470, 1284, 37.5, 36.7, 36.8, 48.0, 1, 20, 1, 70, false, 50, 1, 0.9, 1.1, 0.7, 2.7, false, 0, 0, 6.5, 1.5, CrewType.SingleTyre, false, true, AnimationType.AMGGT3, 0.25));
            carInfo.Add(new Cars("Ferrari 488 GT3 Evo 2020", false, false, false, true, 1, true, true, false, 1, 1, 12, false, false, "Ferrari 488 GT3", "GT3", 7300, 7450, 7200, 7200, 7150, 0, 0, 7650, 1962, 33.2, 32.9, 32.9, 36.5, 1, 50, 1, 100, false, 0, 1, 0.9, 1.1, 0.7, 2.7, false, 0, 0, 6.5, 1.5, CrewType.SingleTyre, false, true, AnimationType.Ferrari488, 0.25));
            carInfo.Add(new Cars("Volkswagen Beetle GRC Lite", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Default", "Rally", 7500, 7500, 7500, 7500, 7500, 0, 0, 8190, 1918, 50, 50, 50, 50, 50, 50, 50, 50, false, 0, 0, 0, 0, 0, 0, false, 0, 0, 0, 0, CrewType.SingleTyre, true, true, AnimationType.Analog, 1)); //not finished 
            carInfo.Add(new Cars("Porsche 911 GT3 Cup (992)", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "BiasOnly", 8560, 8560, 8560, 8560, 8560, 0, 0, 8740, 1570, 40.5, 40.0, 40.5, 47.0, 1, 10, 1, 15, false, 0, 0.9, 0.8, 1.2, 0.9, 3, false, 0, 0, 6.5, 1.5, CrewType.SingleTyre, false, true, AnimationType.Porsche, 0.3));
            carInfo.Add(new Cars("Dallara IR18", true, false, false, false, -1, false, false, false, -1, 1, 8, false, true, "Indycar", "Indycar", 11900, 11900, 11930, 11960, 11960, 0, 0, 11995, 2999, 51.5, 0, 0, 0, 1, 70, 1, 80, true, 80, 0, 0, 0, 0, 9.2, true, 7.1, 0, 6.2, 0, CrewType.All, true, false, AnimationType.Indycar, 0.7));
            carInfo.Add(new Cars("Formula Renault 3.5", false, true, false, false, -1, false, false, false, -1, -1, -1, false, false, "FR3.5", "FR3.5", 8940, 8940, 8940, 8940, 8940, 0, 0, 8950, 2499, 44.5, 0, 0, 0, 1, 30, 1, 90, true, 63, 1.1, 1.1, 1, 1.1, 8.1, false, 0, 0, 6.2, 0, CrewType.All, true, false, AnimationType.FormulaRenault, 0.4));
            carInfo.Add(new Cars("Mazda MX-5 Cup", false, false, false, false, -1, true, false, false, -1, -1, -1, false, false, "Single", "Default", 7200, 7380, 7420, 7420, 0, 0, 0, 7350, 885, 45.5, 0, 40, 48, 1, 40, 1, 40, false, 0, 0.8, 0.8, 1, 0.5, 0.6, false, 0, 0, 10.3, 0, CrewType.LeftRight, true, true, AnimationType.MX5, 0.15));
            carInfo.Add(new Cars("Formula Vee", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "BiasOnly", 6500, 6500, 6500, 0, 0, 0, 0, 7330, 1171, 58.0, 57.5, 20, 65, 1, 90, 1, 90, false, 0, 0.65, 0.8, 1, 0.5, 0.56, false, 0, 0, 15, 0, CrewType.FrontRear, true, true, AnimationType.Vee, 0.1));
            carInfo.Add(new Cars("Skip Barber Formula 2000", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "Default", 6190, 6140, 6240, 6270, 0, 0, 0, 6350, 800, 28.5, 0, 27.0, 31.0, 1, 80, 1, 80, false, 0, 0.85, 0.85, 1, 0.7, 0.58, false, 0, 0, 9.0, 1.4, CrewType.FrontRear, true, false, AnimationType.Analog, 0.1));
            carInfo.Add(new Cars("Audi R8 LMS", false, false, false, true, 12, true, true, false, 12, -1, -1, false, false, "Audi R8 GT3", "GT3", 7950, 8080, 8120, 8050, 8000, 0, 0, 8480, 1090, 39.8, 39.5, 39.8, 45.0, 1, 100, 1, 100, false, 0, 1, 0.9, 1.1, 0.7, 2.7, false, 0, 0, 6.5, 1.5, CrewType.SingleTyre, false, true, AnimationType.AudiR8, 0.25));
            carInfo.Add(new Cars("Lamborghini Huracan GT3 EVO", false, false, false, true, 12, true, true, false, 12, 1, 12, false, false, "Lamborghini Huracan GT3", "GT3", 8250, 8200, 8220, 8220, 8240, 0, 0, 8480, 1090, 41.8, 41.5, 41.6, 45, 1, 60, 1, 70, false, 0, 1, 0.9, 1.1, 0.7, 2.7, false, 0, 0, 6.5, 1.5, CrewType.SingleTyre, false, true, AnimationType.LamboGT3, 0.25));
            carInfo.Add(new Cars("Porsche 911 GT3.R", true, false, false, true, 0, true, true, false, 0, 4, 0, false, false, "Porsche GT3R", "Porsche GT3R", 9250, 9250, 9250, 9250, 9250, 0, 0, 9435, 1846, 65.0, 64.5, 64.5, 65.5, 1, 90, 1, 90, false, 0, 1, 0.9, 1.1, 0.7, 2.7, false, 0, 0, 6.5, 1.5, CrewType.SingleTyre, false, true, AnimationType.PorscheGT3R, 0.25));
            carInfo.Add(new Cars("Audi 90 Quattro GTO", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "Default", 7650, 7650, 7650, 7650, 0, 0, 0, 7670, 1300, 0, 0, 0, 0, 0, 0, 0, 0, false, 0, 0, 0, 0, 0, 0, false, 0, 0, 10, 1, CrewType.SingleTyre, true, true, AnimationType.Porsche, 0.15));
            carInfo.Add(new Cars("Supercars Ford Mustang GT", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "Supercar", 7470, 7470, 7470, 7480, 7480, 0, 0, 7490, 1205, 29.5, 29.0, 29.6, 33.0, 1, 50, 1, 100, true, 0, 1.15, 0.7, 0.7, 0.9, 2.36, false, 0, 0, 6.7, 0.9, CrewType.All, true, true, AnimationType.Supercar, 0.35));
            carInfo.Add(new Cars("Supercars Holden ZB Commodore", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "Supercar", 7470, 7470, 7470, 7480, 7480, 0, 0, 7490, 1205, 29.5, 29.0, 29.6, 33.0, 1, 50, 1, 100, true, 0, 1.15, 0.7, 0.7, 0.9, 2.36, false, 0, 0, 6.7, 0.9, CrewType.All, true, true, AnimationType.Supercar, 0.35));
            carInfo.Add(new Cars("FIA F4", false, false, false, false, -1, false, false, false, -1, -1, -1, false, false, "Single", "BiasOnly", 7150, 7100, 7090, 7090, 7090, 0, 0, 7270, 1200, 33.8, 24.5, 25, 37, 1, 100, 1, 100, false, 0, 0.9, 1, 1, 0.9, 6.25, false, 0, 0, 6.11, 0, CrewType.All, true, false, AnimationType.F4, 0.35));
            carInfo.Add(new Cars("Toyota GR86", false, false, false, false, 0, true, true, false, 0, -1, -1, false, false, "Single", "TC/ABS", 7400, 7370, 7350, 7330, 7330, 0, 0, 7465, 1000, 56.0, 48.0, 48.0, 62.0, 1, 100, 1, 100, false, 0, 0.8, 0.83, 0.95, 0.5, 1.65, false, 0, 0, 14.5, -6.5, CrewType.SingleTyre, true, true, AnimationType.ToyotaGR86, 0.15));
            carInfo.Add(new Cars("Super Formula SF23 - Toyota", false, false, false, false, -1, false, false, false, -1, -1, -1, false, true, "Single", "SF23", 7830, 7870, 7910, 8150, 8150, 8150, 0, 9325, 2687, 49.0, 0, 0, 0, 1, 70, 2, 80, true, 50, 1.2, 1.1, 1.2, 1.2, 8.5, false, 0, 0, 6, 1.5, CrewType.All, true, false, AnimationType.FormulaRenault, 0.6));
        }        
    }
}