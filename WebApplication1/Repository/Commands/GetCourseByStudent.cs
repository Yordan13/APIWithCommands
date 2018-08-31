using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.Commands
{
    [Procedure("getCoursesByStudent")]
    public class GetCourseByStudent : Command
    {
        [Parameter]
        public string ID { get; set; }
    }
}
