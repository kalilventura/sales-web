using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Handlers.Interfaces;
using SalesWeb.Domain.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Domain.Handlers
{
    public class DepartmentHandler : IDepartmentHandler
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IGenericResult> Add(Department entity)
        {
            try
            {
                await _departmentRepository.Add(entity);
                return new GenericResult(true, "Departamento inserido com sucesso.", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IGenericResult> Delete(Department entity)
        {
            try
            {
                await _departmentRepository.Delete(entity);
                return new GenericResult(true, "Departamento inserido com sucesso.", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IGenericResult> FindAll()
        {
            try
            {
                var result = await _departmentRepository.FindAll();

                if (result.Count() == 0)
                    return new GenericResult(true, "Não existem departamentos cadastrados no sistema");

                return new GenericResult(true, result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IGenericResult> FindById(Guid id)
        {
            try
            {
                var result = await _departmentRepository.FindById(id);

                if (result == null)
                    return new GenericResult(true, "Departamento não encontrado");

                return new GenericResult(true, result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IGenericResult> Update(Guid id)
        {
            try
            {
                var department = await _departmentRepository.FindById(id);

                if (department == null)
                    return new GenericResult(false, "Departamento não existe.");

                await _departmentRepository.Update(department);

                return new GenericResult(true, "Departamento deletado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<(Department, bool)> DepartmentExists(string name)
        {
            try
            {
                var department = await _departmentRepository.FindDepartmentByName(name);

                return (department, department != null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}