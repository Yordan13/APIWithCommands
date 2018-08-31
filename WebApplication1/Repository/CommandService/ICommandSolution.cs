using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.CommandService
{
    public interface ICommandSolution
    {
        T GetRemoteCommand<T>() where T : Command, new();
    }
}
