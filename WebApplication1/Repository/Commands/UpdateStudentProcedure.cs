using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.Commands
{
    [Procedure("updateStudent")]
    public class UpdateStudentProcedure : Command
    {
        [Parameter]
        public string ID { get; set; }

        [Parameter]
        public string LastName { get; set; }

        [Parameter]
        public string FirstMidName { get; set; }

        [Parameter]
        public string EnrollmentDate { get; set; }
    }
}
