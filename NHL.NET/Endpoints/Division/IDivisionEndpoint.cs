using NHL.NET.Models.Division;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHL.NET.Endpoints.Division
{
    public interface IDivisionEndpoint
    {
        Task<NHLDivisionList> GetAllAsync();

        Task<NHLDivision> GetByIdAsync(int divisionId);

        Task<NHLDivisionList> GetMultipleAsync(List<int> divisionIds);
        NHLDivisionList GetAll();

        NHLDivision GetById(int divisionId);

        NHLDivisionList GetMultiple(List<int> divisionIds);
    }
}
