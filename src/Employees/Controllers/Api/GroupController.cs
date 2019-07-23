using Barebone.Controllers;
using Data.Entities;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.Employee;
using Employees.ViewModels.Group;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Controllers.Api
{
    //[Authorize]
    [Route("api/groups")]
    public class GroupController : ControllerBaseApi
    {
        public GroupController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<Group> data = new GroupModelFactory().LoadAll(this.Storage, page, size)?.Groups;
            int count = data.Count();

            return Ok(new
            {
                success = true,
                data,
                count,
                totalPage = ((int)count / size) + 1
            });
        }

        [HttpPost]
        public IActionResult Post(GroupCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Group group = model.ToGroupEntity();
                var repo = this.Storage.GetRepository<IGroupRepository>();

                repo.Create(group, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IGroupRepository>();

            Group group = repo.WithKey(id);
            if (group == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = group });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, GroupUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IGroupRepository>();

            Group group = repo.WithKey(id);
            if (group == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToGroupEntity(group);
                repo.Edit(group, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IGroupRepository>();

            Group group = repo.WithKey(id);
            if (group == null)
                return this.NotFound(new { success = false });

            repo.Delete(group, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = true });
        }
    }
}
