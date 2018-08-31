using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.Commands
{
    [Procedure("updateCourse")]
    public class UpdateCourseProcedure : Command
    {
        [Parameter]
        public string CourseID { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Credits { get; set; }


    }
}
