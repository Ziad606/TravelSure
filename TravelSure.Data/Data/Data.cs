using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSure.Data
{
    public static class Data
    {
        public static List<TravelPackage> packages = new()
        {
            new TravelPackage { PackageId = 1, Destination = "Paris", StartDate = new DateTime(2025, 7, 1), EndDate = new DateTime(2025, 7, 8), Price = 1500, Description = "Romantic trip to Paris" },
            new TravelPackage { PackageId = 2, Destination = "Tokyo", StartDate = new DateTime(2025, 9, 15), EndDate = new DateTime(2025, 9, 25), Price = 2000, Description = "Explore Japanese culture" },
            new TravelPackage { PackageId = 3, Destination = "Cairo", StartDate = new DateTime(2025, 6, 10), EndDate = new DateTime(2025, 6, 20), Price = 500, Description = "Historical tour in Egypt" },
            new TravelPackage { PackageId = 4, Destination = "New York", StartDate = new DateTime(2025, 11, 5), EndDate = new DateTime(2025, 11, 15), Price = 2500, Description = "City adventure in NYC" },
            new TravelPackage { PackageId = 5, Destination = "Barcelona", StartDate = new DateTime(2025, 8, 12), EndDate = new DateTime(2025, 8, 19), Price = 1300, Description = "Beach & history in Spain" },
            new TravelPackage { PackageId = 6, Destination = "Dubai", StartDate = new DateTime(2025, 12, 1), EndDate = new DateTime(2025, 12, 10), Price = 1700, Description = "Luxury desert experience" },
            new TravelPackage { PackageId = 7, Destination = "Istanbul", StartDate = new DateTime(2025, 10, 4), EndDate = new DateTime(2025, 10, 11), Price = 900, Description = "Bridge between continents" },
            new TravelPackage { PackageId = 8, Destination = "Bangkok", StartDate = new DateTime(2025, 11, 20), EndDate = new DateTime(2025, 11, 30), Price = 1400, Description = "Thai food & temples" },
            new TravelPackage { PackageId = 9, Destination = "London", StartDate = new DateTime(2025, 9, 1), EndDate = new DateTime(2025, 9, 10), Price = 1600, Description = "Classic UK trip" },
            new TravelPackage { PackageId = 10, Destination = "Rome", StartDate = new DateTime(2025, 7, 15), EndDate = new DateTime(2025, 7, 22), Price = 1100, Description = "Ancient wonders of Italy" },
            new TravelPackage { PackageId = 11, Destination = "Amsterdam", StartDate = new DateTime(2025, 6, 18), EndDate = new DateTime(2025, 6, 25), Price = 1200, Description = "Canals and culture" },
            new TravelPackage { PackageId = 12, Destination = "Cape Town", StartDate = new DateTime(2025, 12, 5), EndDate = new DateTime(2025, 12, 15), Price = 1800, Description = "South African beauty" },
            new TravelPackage { PackageId = 13, Destination = "Moscow", StartDate = new DateTime(2025, 11, 1), EndDate = new DateTime(2025, 11, 10), Price = 1500, Description = "Russian heritage tour" },
            new TravelPackage { PackageId = 14, Destination = "Bali", StartDate = new DateTime(2025, 8, 5), EndDate = new DateTime(2025, 8, 14), Price = 1300, Description = "Island relaxation trip" },
            new TravelPackage { PackageId = 15, Destination = "Toronto", StartDate = new DateTime(2025, 10, 1), EndDate = new DateTime(2025, 10, 9), Price = 1600, Description = "Canada city adventure" }
        };
    }
}
