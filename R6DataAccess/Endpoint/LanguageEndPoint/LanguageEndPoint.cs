using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace R6DataAccess.Models
{
    public class LanguageEndPoint:ILanguageEndPoint 
    {

        public static ILanguage AmericanEnglish =>
            new Language { ShortHand = "en-us", LocalHash = "6eb4f5cd" };
        public static ILanguage AustralianEnglish =>
            new Language { ShortHand = "en-us", LocalHash = "b505a609" };
        public static ILanguage BrazilianPortuguese =>
              new Language { ShortHand = "pt-br", LocalHash = "7ad95128" };
        public static ILanguage BritishEnglish =>
              new Language { ShortHand = "en-us", LocalHash = "b505a609" };
        public static ILanguage CanadianFrench =>
              new Language { ShortHand = "fr-fr", LocalHash = "657de10f" };
        public static ILanguage Czech =>
              new Language { ShortHand = "cs-cz", LocalHash = "dc66e300" };
        public static ILanguage Dutch =>
              new Language { ShortHand = "nl-nl", LocalHash = "80a0b37a" };
        public static ILanguage EuropeanFrench =>
              new Language { ShortHand = "fr-fr", LocalHash = "4f78c986" };
        public static ILanguage EuropeanSpanish =>
              new Language { ShortHand = "es-es", LocalHash = "5e27d9fa" };
        public static ILanguage German =>
              new Language { ShortHand = "de-de", LocalHash = "47a861dd" };
        public static ILanguage Italian =>
              new Language { ShortHand = "it-it", LocalHash = "4ac66a00" };
        public static ILanguage Japanese =>
              new Language { ShortHand = "ja-jp", LocalHash = "30330c03" };
        public static ILanguage Korean =>
              new Language { ShortHand = "ko-kr", LocalHash = "31170d10" };
        public static ILanguage LatinSpanish =>
              new Language { ShortHand = "es-mx", LocalHash = "979289ed" };
        public static ILanguage NordicEnglish =>
              new Language { ShortHand = "en-us", LocalHash = "b505a609" };
        public static ILanguage Polish =>
              new Language { ShortHand = "pl-pl", LocalHash = "845c3d39" };
        public static ILanguage Russian =>
              new Language { ShortHand = "ru-ru", LocalHash = "22e559b7" };
        public static ILanguage SimplifiedChinese =>
              new Language { ShortHand = "zh-cn", LocalHash = "23f064e8" };
        public static ILanguage TraditionalChinese =>
              new Language { ShortHand = "zh-tw", LocalHash = "52f0c5ec" };

    }
}
