using MOD.MOD_Roles;
using MOD.MOD_UserCategories;

namespace MOD.MOD_Users
{
    public interface IUsers
    {
        string Name { get; set; }
        long RolesId { get; set; }
        long UserCategoryId { get; set; }

    }
}