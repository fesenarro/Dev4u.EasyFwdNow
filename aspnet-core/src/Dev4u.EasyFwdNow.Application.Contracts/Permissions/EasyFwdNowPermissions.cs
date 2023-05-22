namespace Dev4u.EasyFwdNow.Permissions;

public static class EasyFwdNowPermissions
{
    public const string GroupName = "EasyFwdNow";

    //Add your own permission names. Example:
    public static class Servicios
    {
        public const string Default = GroupName + ".Servicios";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
