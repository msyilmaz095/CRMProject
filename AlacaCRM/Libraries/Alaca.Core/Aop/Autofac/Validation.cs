using Alaca.Core.Utilities.Interceptors;
using Castle.DynamicProxy;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Core.Aop.Autofac
{
    public class Validation : MethodInterception
    {
        Type _validatorType;
        public Validation(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("WrongValidationType");
            }

            _validatorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                var context = new ValidationContext<object>(entity);
                var result = validator.Validate(context);
                if (!result.IsValid)
                {
                    throw new ValidationException(result.ToString("<br>"));
                    //throw new ValidationException(result.Errors);
                }
            }
        }
    }
}
