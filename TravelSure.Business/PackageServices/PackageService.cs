using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSure.Data;

namespace TravelSure.Business
{
    public class PackageService : IPackageService
    {
        private readonly IPackageRepo _packageRepo;

        public PackageService(IPackageRepo packageRepo)
        {
            _packageRepo = packageRepo;
        }

        public async Task CreatePackage(CreatePackageDto packageDto)
        {
            var package = new TravelPackage
            {
                Destination = packageDto.Destination,
                Description = packageDto.Description,
                StartDate = packageDto.StartDate,
                EndDate = packageDto.EndDate,
                Price = packageDto.Price
            };

            await _packageRepo.CreatePackage(package);
        }

        public async Task<IEnumerable<ReadPackageDto>> GetAllPackages()
        {
            var packages = await _packageRepo.GetAllPackages();

            return packages.Select(p => new ReadPackageDto
            {
                PackageId = p.PackageId,
                Destination = p.Destination,
                Description = p.Description,
                Price = p.Price,
                StartDate = p.StartDate,
                EndDate = p.EndDate
            });
        }

        public async Task<ReadPackageDto?> GetPackage(int id)
        {
            var package = await _packageRepo.GetPackage(id);
            if (package == null) return null;

            return new ReadPackageDto
            {
                PackageId = package.PackageId,
                Destination = package.Destination,
                Description = package.Description,
                Price = package.Price,
                StartDate = package.StartDate,
                EndDate = package.EndDate
            };
        }

        public async Task<bool> UpdatePackage(int id, UpdatePackageDto packageDto)
        {
            var package = new TravelPackage
            {
                PackageId = id,
                Destination = packageDto.Destination,
                Description = packageDto.Description,
                Price = packageDto.Price,
                StartDate = packageDto.StartDate,
                EndDate = packageDto.EndDate
            };

            return await _packageRepo.UpdatePackage(package);
        }

        public async Task<bool> DeletePackage(int id)
        {
            return await _packageRepo.DeletePackage(id);
        }

        public async Task<IEnumerable<ReadPackageDto>> Search(
            string? distination,
            decimal? minPrice,
            decimal? maxPrice,
            DateTime? startDate,
            DateTime? endDate)
        {
            var packages = await _packageRepo.Search(distination, minPrice, maxPrice, startDate, endDate);

            return packages.Select(p => new ReadPackageDto
            {
                PackageId = p.PackageId,
                Destination = p.Destination,
                Description = p.Description,
                Price = p.Price,
                StartDate = p.StartDate,
                EndDate = p.EndDate
            });
        }
    }

}
