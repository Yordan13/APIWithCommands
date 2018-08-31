using ApplicationAPI.Repository.CommandService.Attributes;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.CommandService.Aspects
{
    public class ProcedureAspect : IInterceptor
    {
        public ProcedureAspect() {
        }

        internal ICommandExecutor Executor { get; }

        public void Intercept(IInvocation invocation)
        {
            var targetType = invocation.TargetType;
            var isProcedure = targetType.GetCustomAttributes(false).Any(a => a.GetType().Equals(typeof(ProcedureAttribute)));
            var isExecute = invocation.Method.Name == "get_Execute";
            if (isProcedure && isExecute)
            {
                var command = invocation.Proxy;
                var exec = (ICommandExecutor)(command.GetType().GetProperty("Executor").GetValue(command));
                var name = command.GetType().GetCustomAttribute<ProcedureAttribute>().Name;
                invocation.ReturnValue = exec.Execute(name,(Command)command);
            }
        }
    }
}
