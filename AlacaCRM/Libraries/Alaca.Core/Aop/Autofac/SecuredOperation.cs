﻿using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Alaca.Core.Utilities.Extension;
using Alaca.Core.Utilities.Interceptors;
using Alaca.Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Alaca.Core.Utilities.Security.Jwt;

namespace Alaca.Core.Aop.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            var name = _httpContextAccessor.HttpContext.User.ClaimName();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception("AuthorizationDenied");
        }
    }
}
