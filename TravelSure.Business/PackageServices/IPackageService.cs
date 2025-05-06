using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSure.Business
{
    public interface IPackageService
    {
        Task CreatePackage(CreatePackageDto package);
        Task<IEnumerable<ReadPackageDto>> GetAllPackages();
        Task<ReadPackageDto?> GetPackage(int id);
        Task<bool> UpdatePackage( int id, UpdatePackageDto package);
        Task<bool> DeletePackage(int id);
        Task<IEnumerable<ReadPackageDto>> Search(
            string? distination,
            decimal? minPrice,
            decimal? maxPrice,
            DateTime? startDate,
            DateTime? endDate
        );
    }

}
