﻿using System.Collections.Generic;

namespace R6Sharp
{
    internal static class ApiHelper
    {
        internal static string DeriveGamemodeFlags(Gamemode gamemode)
        {
            var gamemodes = new List<string>();

            if (gamemode.HasFlag(Gamemode.Casual))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.Casual));
            }

            if (gamemode.HasFlag(Gamemode.Unranked))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.Unranked));
            }

            if (gamemode.HasFlag(Gamemode.Ranked))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.Ranked));
            }

            if (gamemode.HasFlag(Gamemode.All))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.All));
            }

            return string.Join(',', gamemodes);
        }

        internal static string DerivePlatformFlags(Platform platform)
        {
            var platforms = new List<string>();

            if (platform.HasFlag(Platform.PC))
            {
                platforms.Add(Constant.PlatformToName(Platform.PC));
            }
            if (platform.HasFlag(Platform.PSN))
            {
                platforms.Add(Constant.PlatformToName(Platform.PSN));
            }
            if (platform.HasFlag(Platform.XBL))
            {
                platforms.Add(Constant.PlatformToName(Platform.XBL));
            }

            return string.Join(',', platforms);
        }

        internal static string DeriveTeamRoleFlags(TeamRole teamrole)
        {
            var teamroles = new List<string>();

            if (teamrole.HasFlag(TeamRole.All))
            {
                teamroles.Add(Constant.TeamRoleToString(TeamRole.All));
            }
            if (teamrole.HasFlag(TeamRole.Attacker))
            {
                teamroles.Add(Constant.TeamRoleToString(TeamRole.Attacker));
            }
            if (teamrole.HasFlag(TeamRole.Defender))
            {
                teamroles.Add(Constant.TeamRoleToString(TeamRole.Defender));
            }

            return string.Join(',', teamroles);
        }
    }
}
