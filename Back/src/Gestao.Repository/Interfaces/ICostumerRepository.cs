using System.Collections.Generic;
using System.Threading.Tasks;
using Gestao.Domain.Models;

namespace Gestao.Repository.Interfaces
{
    public interface ICostumerRepository : IGlobalRepository
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(int costumerId);
    }
}