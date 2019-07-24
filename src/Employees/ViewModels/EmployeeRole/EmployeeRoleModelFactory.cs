using System;
using Employees.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Employees.ViewModels.Employee
{
    internal class EmployeeRoleModelFactory
    {
        public EmployeeRoleModelFactory()
        {
        }

        internal EmployeeRoleIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var roleRepo = storage.GetRepository<IEmployeeRoleRepository>();

            return new EmployeeRoleIndexViewModel(roleRepo.All(page, size));
        }
    }
}