﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomUserManagement.Security
{
    public class SuperAdminHandler /*: AuthorizationHandler<ManageAdminRolesAndClaimsRequirement>*/
    {
        //private readonly IHttpContextAccessor httpContextAccessor;
        //public SuperAdminHandler(IHttpContextAccessor httpContextAccessor)
        //{
        //    this.httpContextAccessor = httpContextAccessor;
        //}

        //protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ManageAdminRolesAndClaimsRequirement requirement)
        //{
        //    if (context.User.IsInRole("SuperAdmin"))
        //    {
        //        context.Succeed(requirement);
        //    }

        //    return Task.CompletedTask;
        //}
    }
}
