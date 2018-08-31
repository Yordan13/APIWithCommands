using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.Commands
{
    [Procedure("addCourse")]
    public class AddCourseProcedure : Command
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Credits { get; set; }
    }
}
