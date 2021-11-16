using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao.Domain.Models;
using Gestao.Repository.Contexts;
using Gestao.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Repository
{
    public class CostumerRepository : GlobalRepository, ICostumerRepository
    {
        private readonly DataContext _context;
        public CostumerRepository(DataContext context) : base(context)
        {
            this._context = context;
        }

        #region Locale General Functions
        public void Add(Cliente model)
        {
            Add<Cliente>(model);
        }

        public void Update(Cliente model)
        {
            Update<Cliente>(model);
        }

        public void Delete(Cliente model)
        {
            Delete<Cliente>(model);
        }

        public void DeleteRange(Cliente[] clientes)
        {
             DeleteRange<Cliente>(clientes);
        }
        #endregion

        public async Task<IEnumerable<Cliente>> GetAllAsync(){
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetByIdAsync(int costumerId){
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == costumerId);
        }
    }
}