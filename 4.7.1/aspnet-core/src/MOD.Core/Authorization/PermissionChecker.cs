using Abp.Authorization;
using MOD.Authorization.Roles;
using MOD.Authorization.Users;

namespace MOD.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
