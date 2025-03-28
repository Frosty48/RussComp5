using Hackerspace.Shared.Models;

namespace Hackerspace.Shared.Interfaces
{
    public interface IBadgesPageDataService
    {

        public Task<List<Badge>> GetAllAsync();

    }
}
