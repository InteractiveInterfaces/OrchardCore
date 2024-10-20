using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Identity;
using OrchardCore.Recipes.Models;
using OrchardCore.Recipes.Services;
using OrchardCore.Security;
using OrchardCore.Security.Permissions;
using OrchardCore.Security.Services;

namespace OrchardCore.Roles.Recipes;

/// <summary>
/// This recipe step creates a set of roles.
/// </summary>
public sealed class RolesStep : IRecipeStepHandler
{
    private readonly RoleManager<IRole> _roleManager;
    private readonly IRoleService _roleService;

    public RolesStep(
        RoleManager<IRole> roleManager,
        IRoleService roleService)
    {
        _roleManager = roleManager;
        _roleService = roleService;
    }

    public async Task ExecuteAsync(RecipeExecutionContext context)
    {
        if (!string.Equals(context.Name, "Roles", StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        var model = context.Step.ToObject<RolesStepModel>();

        foreach (var roleEntry in model.Roles)
        {
            var roleName = roleEntry.Name?.Trim();

            if (string.IsNullOrWhiteSpace(roleName))
            {
                continue;
            }

            var role = await _roleManager.FindByNameAsync(roleName);
            var isNewRole = role == null;

            if (isNewRole)
            {
                role = new Role
                {
                    RoleName = roleName,
                };
            }

            if (role is Role r)
            {
                r.RoleDescription = roleEntry.Description;
                r.RoleClaims.RemoveAll(c => c.ClaimType == Permission.ClaimType);

                if (!await _roleService.IsAdminRoleAsync(roleName))
                {
                    r.RoleClaims.AddRange(roleEntry.Permissions.Select(RoleClaim.Create));
                }
            }

            if (isNewRole)
            {
                await _roleManager.CreateAsync(role);
            }
            else
            {
                await _roleManager.UpdateAsync(role);
            }
        }
    }
}

public sealed class RolesStepModel
{
    public RolesStepRoleModel[] Roles { get; set; }
}

public sealed class RolesStepRoleModel
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string[] Permissions { get; set; }
}
