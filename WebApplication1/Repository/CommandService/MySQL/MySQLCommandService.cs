using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.Aspects;
using ApplicationAPI.Repository.Connection;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.CommandService.MySQL
{
    public class MySQLCommandService : ICommandSolution
    {
        public MySQLCommandService(MySQLDBConnection con) {
            this.Interceptor = new[] { new ProcedureAspect() };
            this.Executor = new MySQLCommandExecutor(con.Connection);
            this.generator = new ProxyGenerator();
        }

        private IInterceptor[] Interceptor { get; }

        private MySQLCommandExecutor Executor;

        private ProxyGenerator generator { get; }

        public T GetRemoteCommand<T>() where T : Command, new()
        {
            var obj = new T();
            obj.Executor = this.Executor;
            var res = generator.CreateClassProxyWithTarget<T>(obj, Interceptor);
            res.Executor = this.Executor;
            return res;
        }
    }
}
