using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models
{
    public class Auth : IAuth
    {

        private string _email;
        private string _password;
        private bool? _rememberMe;

        public Auth(string email, string password, bool? rememberMe)
        {
            _email = email;
            _password = password;
            _rememberMe = rememberMe;

            validateAuth();
        }

        private void validateAuth()
        {
            if (string.IsNullOrWhiteSpace(_email))
            {
                throw new ArgumentNullException(this.GetType().FullName, "Email address cannot be null or empty.");
            }
            else if (string.IsNullOrWhiteSpace(_password))
            {
                throw new ArgumentNullException(this.GetType().FullName, "Password cannot be null or empty.");
            }

        }

        public string GetCredentialBase64()
        {

            // Generate an auth for acquiring a token
            var auth = $"{_email}:{_password}";
            var bytes = Encoding.UTF8.GetBytes(auth);

            return Convert.ToBase64String(bytes);
        }
    }
}
