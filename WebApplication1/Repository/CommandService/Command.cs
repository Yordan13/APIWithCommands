using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.CommandService
{
    public class Command
    {
        public ICommandExecutor Executor { get;  set; }

        public virtual DataTable Execute { get; }
    }
}
