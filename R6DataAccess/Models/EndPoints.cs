using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models
{
    sealed class EndPoints : IEndPoints
    {

        // API access
        public static IEndPoints Base => new EndPoints() { Url = "https://game-rainbow6.ubi.com", Name = "Base" };
        public static IEndPoints Sessions => new EndPoints() { Url = "https://public-ubiservices.ubi.com/v3/profiles/sessions", Name= "Session" };
        public static IEndPoints Search => new EndPoints() { Url = "https://public-ubiservices.ubi.com/v2/profiles" , Name="Search"};

        // These endpoints need to be formatted to correct space uuids (uplay, psn, xbl)
        public static IEndPoints Progressions => new EndPoints() 
        { Url = "https://public-ubiservices.ubi.com/v1/spaces/{0}/sandboxes/{1}/r6playerprofile/playerprofile/progressions", Name= "Progression" };
        public static IEndPoints Players => new EndPoints() { Url = "https://public-ubiservices.ubi.com/v1/spaces/{0}/sandboxes/{1}/r6karma/players" , Name="Players"};
        public static IEndPoints Statistics => new EndPoints() { Url = "https://public-ubiservices.ubi.com/v1/spaces/{0}/sandboxes/{1}/playerstats2/statistics", Name = "Statistics" };

        // These are metadata endpoints, places where static data is stored
        public static IEndPoints Avatar => new EndPoints() { Url = "https://ubisoft-avatars.akamaized.net/{0}/default_146_146.png?appId={1}", Name = "Avatar" };
        public static IEndPoints Seasons => new EndPoints() { Url = "https://game-rainbow6.ubi.com/assets/data/seasons.152c15ea.json", Name="Seasons" };
        public static IEndPoints Locales => new EndPoints() { Url = "https://game-rainbow6.ubi.com/assets/locales/locale.{0}.{1}.json", Name="Locales" };
        public static IEndPoints Ranks => new EndPoints() { Url = "https://game-rainbow6.ubi.com/assets/data/ranks.754ab452.json" , Name="Ranks"};
        public static IEndPoints Operators => new EndPoints() { Url = "https://game-rainbow6.ubi.com/assets/data/operators.f660ac39.json" , Name = "Operators"};
        public static IEndPoints Weapons => new EndPoints() { Url = "https://game-rainbow6.ubi.com/assets/data/weapons.8a9b3d9e.json" , Name = "Weapons" };
        public string Url { get; set; }

        public string Name { get; set; }
    }
}
