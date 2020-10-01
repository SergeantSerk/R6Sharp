using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models
{
    public class Language : ILanguage
    {
        //public static ILanguage AmericanEnglish 
        //{ get { return new Language() { ShortHand = "en-us", LocalHash = "6eb4f5cd" }; } }

        //public static ILanguage AustralianEnglish
        //{ get { return new Language() { ShortHand = "en-au", LocalHash = null }; } }



        //public static ILanguage BrazilianPortuguese
        //{ get { return new Language() { ShortHand = "pt - br", LocalHash = "7ad95128" }; } }

        //public static ILanguage BritishEnglish
        //{ get { return new Language() { ShortHand = "en-gb", LocalHash = null }; } }

        //public static ILanguage CanadianFrench
        //{ get { return new Language() { ShortHand = "fr-ca", LocalHash = null }; } }

        //public static ILanguage Czech
        //{ get { return new Language() { ShortHand = "cs-cz", LocalHash = "dc66e300" }; } }

        //public static ILanguage Dutch
        //{ get { return new Language() { ShortHand = "nl-nl", LocalHash = "80a0b37a" }; } }
        //public static ILanguage EuropeanFrench
        //{ get { return new Language() { ShortHand = "fr-fr", LocalHash = "4f78c986" }; } }
        //public static ILanguage EuropeanSpanish
        //{ get { return new Language() { ShortHand = "es-es", LocalHash = "5e27d9fa" }; } }

        //public static ILanguage German
        //{ get { return new Language() { ShortHand = "de-de", LocalHash = "47a861dd" }; } }
        //public static ILanguage Italian
        //{ get { return new Language() { ShortHand = "it-it", LocalHash = "4ac66a00" }; } }

        //public static ILanguage Japanese
        //{ get { return new Language() { ShortHand = "ja-jp", LocalHash = "30330c03" }; } }
        //public static ILanguage Korean
        //{ get { return new Language() { ShortHand = "ko-kr", LocalHash = "31170d10" }; } }
        //public static ILanguage LatinSpanish
        //{ get { return new Language() { ShortHand = "es-mx", LocalHash = "979289ed" }; } }


        //public static ILanguage NordicEnglish
        //{ get { return new Language() { ShortHand = "en-nordic", LocalHash = null }; } }

        //public static ILanguage Polish
        //{ get { return new Language() { ShortHand = "pl-pl", LocalHash = "845c3d39" }; } }
        //public static ILanguage Russian
        //{ get { return new Language() { ShortHand = "ru-ru", LocalHash = "22e559b7" }; } }

        //public static ILanguage SimplifiedChinese
        //{ get { return new Language() { ShortHand = "zh-cn", LocalHash = "23f064e8" }; } }
        //public static ILanguage TraditionalChinese
        //{ get { return new Language() { ShortHand = "zh-tw", LocalHash = "52f0c5ec" }; } }

        public string LocalHash { get; set; }

        public string ShortHand { get; set; }
    }
}
