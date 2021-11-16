using System.Collections.Generic;
using System.Threading.Tasks;
using Gestao.Domain.Models;

namespace Gestao.Application.Services
{
    public interface ICostumerAppService
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente> GetAsync(int costumerId);
        Task<bool> DeleteAsync(int costumerId);
        Task<Cliente> InsertOrUpdateAsync(Cliente model);
    }
}