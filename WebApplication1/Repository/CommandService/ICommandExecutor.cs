using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.CommandService
{
    public interface ICommandExecutor
    {
        DataTable Execute<T>(string name, T command) where T : Command, new();
    }
}
