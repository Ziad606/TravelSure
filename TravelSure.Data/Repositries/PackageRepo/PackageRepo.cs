using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSure.Data
{
    public class PackageRepo : IPackageRepo
    {
        private static List<TravelPackage> _packages = Data.packages;
        private static int _nextId = 16;

        public async Task CreatePackage(TravelPackage package)
        {
            await Task.Run(() =>
            {
                package.PackageId = _nextId++;
                _packages.Add(package);
            });
        }

        public async Task<IEnumerable<TravelPackage>> GetAllPackages()
        {
            return await Task.FromResult(_packages);
        }

        public async Task<TravelPackage?> GetPackage(int id)
        {
            return await Task.FromResult(_packages.FirstOrDefault(p => p.PackageId == id));
        }

        public async Task<bool> UpdatePackage(TravelPackage package)
        {
            var existPackage = await GetPackage(package.PackageId);
            if (existPackage == null) return false;

            await Task.Run(() =>
            {
                existPackage.Destination = package.Destination;
                existPackage.StartDate = package.StartDate;
                existPackage.EndDate = package.EndDate;
                existPackage.Price = package.Price;
                existPackage.Description = package.Description;
            });

            return true;
        }

        public async Task<bool> DeletePackage(int id)
        {
            var existPackage = await GetPackage(id);
            if (existPackage == null) return false;

            return await Task.Run(() => _packages.Remove(existPackage));
        }

        public async Task<IEnumerable<TravelPackage>> Search(string? destination, decimal? minPrice, decimal? maxPrice, DateTime? startDate, DateTime? endDate)
        {
            var result = _packages.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(destination))
                result = result.Where(p => p.Destination.Contains(destination, StringComparison.OrdinalIgnoreCase));

            if (minPrice.HasValue)
                result = result.Where(p => p.Price >= minPrice.Value);

            if (maxPrice.HasValue)
                result = result.Where(p => p.Price <= maxPrice.Value);

            if (startDate.HasValue)
                result = result.Where(p => p.StartDate >= startDate.Value);

            if (endDate.HasValue)
                result = result.Where(p => p.EndDate <= endDate.Value);

            return await Task.FromResult(result);
        }
    }

}
