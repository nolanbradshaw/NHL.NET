using NHL.NET.Models.Franchise;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Franchise
{
    public interface IFranchiseEndpoint
    {
        Task<NHLFranchiseList> GetAllAsync();
        Task<NHLFranchise> GetByIdAsync(int franchiseId);
        Task<NHLFranchiseList> GetMultipleByIdAsync(IEnumerable<int> franchiseIds);
        NHLFranchiseList GetAll();
        NHLFranchise GetById(int franchiseId);
        NHLFranchiseList GetMultipleById(IEnumerable<int> franchiseIds);
    }
}
