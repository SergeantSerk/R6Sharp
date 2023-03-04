using R6Sharp.Endpoint;
using System;
using System.Collections.Generic;

namespace R6Sharp
{
    /// <summary>
    /// Region the player is based in.
    /// </summary>
    public enum Region
    {
        All,    // Unified regions
        APAC,   // Asia Pacific :(
        EMEA,   // Europe, Middle East and Africa
        NCSA    // North, Central and South America
    }

    /// <summary>
    /// Platform the player is based on.
    /// </summary>
    [Flags]
    public enum Platform
    {
        PC = 1,     // PC/Uplay
        PSN = 2,    // Playstation Network
        XBL = 4     // Xbox Live
    }

    /// <summary>
    /// Gamemode data to retrieve for player.
    /// </summary>
    [Flags]
    public enum Gamemode
    {
        Casual = 1,
        Unranked = 2,
        Ranked = 4,
        All = 8
    }

    /// <summary>
    /// The role the player has played in the matches.
    /// </summary>
    [Flags]
    public enum TeamRole
    {
        All = 1,
        Attacker = 2,
        Defender = 4
    }

    /// <summary>
    /// The type of trend to retrieve.
    /// </summary>
    public enum TrendType
    {
        Weeks
    }

    public class R6Api
    {
        private SessionEndpoint Session { get; }

        public ProfileEndpoint Profile { get; }
        public PlayerProgressionEndpoint PlayerProgression { get; }
        public PlayerEndpoint Player { get; }
        public PlayersSkillRecordsEndpoint PlayersSkillRecordsEndpoint { get; }
        public PlayerStatisticsEndpoint PlayerStatisticsEndpoint { get; }

        #region Constructors
        /// <summary>
        /// Create a R6S API instance with remember me defaulting to true
        /// </summary>
        /// <param name="email">
        /// Email address of a Ubisoft account.
        /// </param>
        /// <param name="password">
        /// Password of a Ubisoft account.
        /// </param>
        public R6Api(string email, string password) : this(email, password, true)
        {

        }

        /// <summary>
        /// Create a R6S API instance with optional remember me option.
        /// </summary>
        /// <param name="email">
        /// Email address of a Ubisoft account.
        /// </param>
        /// <param name="password">
        /// Password of a Ubisoft account.
        /// </param>
        /// <param name="rememberMe">
        /// Option for Ubisoft to remember this instance's session (can be changed over time by <see cref="RememberMe"/>.
        /// </param>
        public R6Api(string email, string password, bool rememberMe)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(this.GetType().FullName, "Email address cannot be null or empty.");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(this.GetType().FullName, "Password cannot be null or empty.");
            }

            Session = new SessionEndpoint(email, password, rememberMe);
            Profile = new ProfileEndpoint(Session);
            PlayerProgression = new PlayerProgressionEndpoint(Session);
            Player = new PlayerEndpoint(Session);
            PlayersSkillRecordsEndpoint = new PlayersSkillRecordsEndpoint(Session);
            PlayerStatisticsEndpoint = new PlayerStatisticsEndpoint(Session);
        }
        #endregion
    }
}