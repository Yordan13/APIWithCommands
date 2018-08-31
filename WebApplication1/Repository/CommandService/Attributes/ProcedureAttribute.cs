using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.CommandService.Attributes
{
    public class ProcedureAttribute : Attribute
    {

        public ProcedureAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
