using System.Threading.Tasks;

namespace R6DataAccess.Models
{
    public interface ILanguageEndPoint
    {

        public static ILanguage AmericanEnglish { get; }
        public static ILanguage AustralianEnglish { get; }
        public static ILanguage BrazilianPortuguese { get; }
        public static ILanguage BritishEnglish { get; }

        public static ILanguage CanadianFrench { get; }
        public static ILanguage Czech { get; }
        public static ILanguage Dutch { get; }
        public static ILanguage EuropeanFrench { get; }
        public static ILanguage EuropeanSpanish { get; }
        public static ILanguage German { get; }
        public static ILanguage Italian { get; }
        public static ILanguage Japanese { get; }
        public static ILanguage Korean { get; }
        public static ILanguage LatinSpanish { get; }
        public static ILanguage NordicEnglish { get; }
        public static ILanguage Polish { get; }
        public static ILanguage Russian { get; }
        public static ILanguage SimplifiedChinese { get; }
        public static ILanguage TraditionalChinese { get; }

    }
}