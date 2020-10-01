using System;

namespace R6DataAccess.Models
{
    public interface IRequest
    {
        string URL { get; }
        public Uri GetEndPointUri();
    }
}