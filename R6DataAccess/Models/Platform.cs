using R6DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models
{
    public class Platform : IPlatform
    {

        public static IPlatform UPLAY => new Platform 
        { 
            Name = "uplay",
            Guid = Guid.Parse("5172a557-50b5-4665-b7db-e3f2e8c5041d"),
            SandBox = "OSBOR_PC_LNCH_A"


        };

        public static IPlatform PSN => new Platform 
        { 
            Name = "psn",
            Guid = Guid.Parse("05bfb3f7-6c21-4c42-be1f-97a33fb5cf66"),
            SandBox = "OSBOR_PS4_LNCH_A"

        };

        public static IPlatform XBL => new Platform 
        { 
            Name = "xbl",
            Guid= Guid.Parse("98a601e5-ca91-4440-b1c5-753f601a2c90"),
            SandBox = "OSBOR_XBOXONE_LNCH_A"
        };


        public string Name { get; set; }

        public Guid Guid { get; set; }

        public string SandBox { get; set; }
    }
}
