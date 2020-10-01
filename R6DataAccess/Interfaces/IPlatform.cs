using System;

namespace R6DataAccess.Interfaces
{
    public interface IPlatform
    {
        
        public string Name { get; }

        public Guid Guid { get; }

        public string SandBox { get; }
    }
}
