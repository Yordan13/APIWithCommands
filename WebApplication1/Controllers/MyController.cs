using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.MySQL;
using ApplicationAPI.Repository.Connection;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Controllers
{
    public class MyController : ControllerBase
    {
        protected readonly ICommandSolution service;

        public MyController()
        {
            var connection = new MySQLDBConnection("sql10.freemysqlhosting.net", "sql10253817", "sql10253817", "IvTyCTEjMH");
            connection.Initialize();
            this.service = new MySQLCommandService(connection);
        }
    }
}
