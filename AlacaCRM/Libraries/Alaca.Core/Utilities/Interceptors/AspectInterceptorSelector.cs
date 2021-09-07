using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Castle.DynamicProxy;
using System.Reflection;

namespace Alaca.Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            try
            {
                var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                        (true).ToList();
                var methodAttributes = type.GetMethod(method.Name)
                    .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
                classAttributes.AddRange(methodAttributes);
                // classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));

                return classAttributes.OrderBy(x => x.Priority).ToArray();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
