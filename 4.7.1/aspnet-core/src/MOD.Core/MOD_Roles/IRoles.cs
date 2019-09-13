namespace MOD.MOD_Roles
{
    public interface IRoles
    {
        string Name { get; set; }
        string Permissions { get; set; }
        long FeaturesId { get; set; }
    }
}