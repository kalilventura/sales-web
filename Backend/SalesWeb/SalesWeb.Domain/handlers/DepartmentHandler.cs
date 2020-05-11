using SalesWeb.Domain.DTO;
using SalesWeb.Domain.Entities;
using SalesWeb.Domain.Entities.Pagination;
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

        public async Task<IGenericResult> Add(DepartmentDto entity)
        {
            var newDepartment = new Department
            {
                Name = entity.Name,
            };
            return new GenericResult(true, "Departamento inserido com sucesso.", await _departmentRepository.Add(newDepartment));
        }

        public async Task<IGenericResult> Delete(Guid id)
        {
            var department = await _departmentRepository.FindById(id);
            if (department == null)
                return new GenericResult(false, "Departamento não existe.");

            await _departmentRepository.Delete(department);
            return new GenericResult(true, "Departamento excluido com sucesso.", null);
        }

        public async Task<IGenericResult> FindAll()
        {
            var result = await _departmentRepository.FindAll();

            if (!result.Any())
                return new GenericResult(true, "Não existem departamentos cadastrados no sistema.");

            return new GenericResult(true, result);
        }

        public async Task<IGenericResult> FindAll(int currentPage, int pageSize)
        {
            var pagination = new PagedResult<Department>
            {
                CurrentPage = currentPage,
                PageSize = pageSize
            };
            var result = await _departmentRepository.FindAll(pagination);

            if (!result.Results.Any())
                return new GenericResult(true, "Não existem departamentos cadastrados no sistema.");

            return new GenericResult(true, result);
        }

        public async Task<IGenericResult> FindById(Guid id)
        {
            var result = await _departmentRepository.FindById(id);

            if (result == null)
                return new GenericResult(true, "Departamento não encontrado.");

            return new GenericResult(true, result);
        }

        public async Task<IGenericResult> Update(Guid id)
        {
            var department = await _departmentRepository.FindById(id);

            if (department == null)
                return new GenericResult(false, "Departamento não existe.");

            await _departmentRepository.Update(department);

            return new GenericResult(true, "Departamento excluido com sucesso.");
        }
    }
}