using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using System;

namespace R6Sharp.Models
{
    public interface IQuery
    {
        string NameOnPlatform { get; set; }

        string IdOnPlatform { get; set; }
        IPlatform PlatformType { get; set; }

        string ProfileId { get; set; }

        string BoardId { get; set; }

        IRegion Region { get; set; }

        string SeasonId { get; set; }

        string Population { get; set; }

        string Statistics { get; set; }

    }
}