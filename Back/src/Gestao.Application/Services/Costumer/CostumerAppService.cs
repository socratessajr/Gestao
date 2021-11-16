using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gestao.Domain.Models;
using Gestao.Repository.Interfaces;

namespace Gestao.Application.Services
{
    public class CostumerAppService : ICostumerAppService
    {
        private readonly ICostumerRepository _costumerRep;
        public CostumerAppService(ICostumerRepository costumerRep)
        {
            this._costumerRep = costumerRep;

        }
        public async Task<bool> DeleteAsync(int costumerId)
        {
            try
            {
                var cliente = await _costumerRep.GetByIdAsync(costumerId);
                if (cliente == null) throw new Exception("Cliente id " + costumerId + " não foi encontrado!");

                _costumerRep.Delete<Cliente>(cliente);
                return await _costumerRep.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> GetAsync(int costumerId)
        {
            try
            {
                return await _costumerRep.GetByIdAsync(costumerId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            try
            {
                return await _costumerRep.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> InsertOrUpdateAsync(Cliente model)
        {
            if (model.Id > 0)
                return await Update(model);
            else
                return await Insert(model);
        }

        #region Private Functions
        private async Task<Cliente> Insert(Cliente model)
        {
            try
            {
                _costumerRep.Add<Cliente>(model);
                if (await _costumerRep.SaveChangesAsync()){
                    return await _costumerRep.GetByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task<Cliente> Update(Cliente model)
        {
            try
            {
                var cliente = await _costumerRep.GetByIdAsync(model.Id);
                if (cliente == null) return null;

                model.Id = cliente.Id;
                
                _costumerRep.Update<Cliente>(model);
                if (await _costumerRep.SaveChangesAsync()){
                    return await _costumerRep.GetByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}