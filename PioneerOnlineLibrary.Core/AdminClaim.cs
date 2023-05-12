using Microsoft.AspNetCore.Authorization;
using PioneerOnlineLibrary.Core.Services;
using PioneerOnlineLibrary.Domain.Model;
using PioneerOnlineLibrary.Infrastructure.Interface;
using PioneerOnlineLibrary.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Helpers
{
    public class AdminClaim : AuthorizationHandler<BookRepository>
    {
      
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, BookRepository requirement)
        {
            if (!context.User.HasClaim(x => x.Type == ClaimTypes.Role))
                return Task.CompletedTask;

            var role = context.User.Claims.FirstOrDefault(
                    x => x.Type == ClaimTypes.Role)!.Value;

            context.Succeed(requirement);

            return Task.CompletedTask;
        }

    }
}
