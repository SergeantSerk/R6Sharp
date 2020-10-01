using System;

namespace R6Sharp.Response
{
    public interface IProfile
    {
        Guid IdOnPlatform { get; set; }
        string NameOnPlatform { get; set; }
        string PlatformType { get; set; }
        Guid ProfileId { get; set; }
        Guid UserId { get; set; }

        Uri ProfileIcon { get; }
    }
}