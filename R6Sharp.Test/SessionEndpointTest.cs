using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R6Sharp.Endpoint;
using R6Sharp.Response;
using System.Reflection;

namespace R6Sharp.Test
{
    [TestClass]
    public class SessionEndpointTest_NoRemember
    {
        private SessionEndpoint SessionEndpoint { get; }

        public SessionEndpointTest_NoRemember()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets(Assembly.GetExecutingAssembly(), false)
                .Build();
            string? email = config.GetRequiredSection("email").Value;
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email was not specified in secrets file.");
            }

            string? password = config.GetRequiredSection("password").Value;
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password was not specified in secrets file.");
            }

            SessionEndpoint = new SessionEndpoint(email, password, false);
        }

        [TestMethod]
        public void IsRememberMeStored()
        {
            Assert.IsFalse(SessionEndpoint.RememberMe);
        }

        [TestMethod]
        public void DoesRememberMeChange()
        {
            Assert.IsFalse(SessionEndpoint.RememberMe);
            SessionEndpoint.RememberMe = true;
            Assert.IsTrue(SessionEndpoint.RememberMe);
        }

        [TestMethod]
        public async Task IsValidSessionAsync()
        {
            Session session = await SessionEndpoint.GetCurrentSessionAsync();
            Assert.IsFalse(string.IsNullOrEmpty(session.PlatformType));
            Assert.IsFalse(string.IsNullOrEmpty(session.Ticket));
            Assert.IsFalse(session.ProfileId.Equals(default));
            Assert.IsFalse(session.UserId.Equals(default));
            Assert.IsFalse(string.IsNullOrEmpty(session.NameOnPlatform));
            Assert.IsFalse(string.IsNullOrEmpty(session.Environment));
            Assert.IsTrue(session.Expiration > DateTime.UtcNow);
            Assert.IsFalse(string.IsNullOrEmpty(session.ClientIp));
            Assert.IsFalse(string.IsNullOrEmpty(session.ClientIpCountry));
            Assert.IsFalse(session.ServerTime.Equals(default));
            Assert.IsFalse(session.SessionId.Equals(default));
            Assert.IsFalse(string.IsNullOrEmpty(session.SessionKey));
        }
    }
}
