using SVCW.DTOs.Config;

namespace SVCW.Interfaces
{
    public interface IConfig
    {
        adminConfig GetAdminConfig();
        adminConfig updateAdminConfig(adminConfig update);
        userCreateActivityConfig getConfig(string? userId, string? email);
    }
}
