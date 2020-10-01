using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models
{
    public class Region:IRegion
    {
        /// <summary>
        /// Region the player is based in.
        /// </summary>

        public static IRegion APAC { get; } = new Region { Name = "apac" }; // Asia Pacific :(

        public static IRegion EMEA { get; } = new Region { Name = "emea" };// Europe, Middle East and Africa

        public static IRegion NCSA { get; } = new Region { Name = "ncsa" }; // North, Central and South America

        public string Name { get; private set; }
    }

  
}
