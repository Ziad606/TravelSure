using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TravelSure.Data
{
    public interface IPackageRepo
    {
        Task CreatePackage(TravelPackage package);
        Task<IEnumerable<TravelPackage>> GetAllPackages();
        Task<TravelPackage> GetPackage(int id);
        Task<bool> UpdatePackage(TravelPackage package);
        Task<bool> DeletePackage(int id);
        Task<IEnumerable<TravelPackage>> Search(
            string? distination,
            decimal? minPrice,
            decimal? maxPrice,
            DateTime? startDate,
            DateTime? endDate
        );
    }

}
