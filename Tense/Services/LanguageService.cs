using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tense.Services
{
    /// <summary>
    /// Language service
    /// </summary>
    public static class LanguageService
    {
        /// <summary>
        /// Converts a language code to Locale Id
        /// </summary>
        /// <param name="language">The language code to convert</param>
        /// <returns>The locale id</returns>
        public static int ConvertToLocaleId(string language)
        {
            switch (language.ToLower().Trim())
            {
                case "af":
                    return 1078;

                case "sq":
                    return 1052;

                case "ar-ae":
                    return 14337;

                case "ar-bh":
                    return 15361;

                case "ar-dz":
                    return 5121;

                case "ar-eg":
                    return 3073;

                case "ar-iq":
                    return 2049;

                case "ar-jo":
                    return 11265;

                case "ar-kw":
                    return 13313;

                case "ar-lb":
                    return 12289;

                case "ar-ly":
                    return 4097;

                case "ar-ma":
                    return 6145;

                case "ar-om":
                    return 8193;

                case "ar-qa":
                    return 16385;

                case "ar":
                case "ar-sa":
                    return 1025;

                case "ar-sy":
                    return 10241;

                case "ar-tn":
                    return 7169;

                case "ar-ye":
                    return 9217;

                case "hy":
                    return 1067;

                case "az-az":
                    return 1068;

                case "eu":
                    return 1069;

                case "be":
                    return 1059;

                case "bg":
                    return 1026;

                case "ca":
                    return 1027;

                case "zh":
                case "zh-cn":
                    return 2052;

                case "zh-hk":
                    return 3076;

                case "zh-mo":
                    return 5124;

                case "zh-sg":
                    return 4100;

                case "zh-tw":
                    return 1028;

                case "hr":
                    return 1050;

                case "cs":
                    return 1029;

                case "da":
                    return 1030;

                case "hl":
                case "nl-nl":
                    return 1043;

                case "nl-be":
                    return 2067;

                case "en-au":
                    return 3081;

                case "en-bz":
                    return 10249;

                case "en-ca":
                    return 4105;

                case "en-cb":
                    return 9225;

                case "en-ie":
                    return 6153;

                case "en-jm":
                    return 8201;

                case "en-nz":
                    return 5129;

                case "en-ph":
                    return 13321;

                case "en-za":
                    return 7177;

                case "en-tt":
                    return 11273;

                case "en":
                case "en-gb":
                    return 2057;

                case "en-us":
                    return 1033;

                case "et":
                    return 1061;

                case "fa":
                    return 1065;

                case "fi":
                    return 1035;

                case "fo":
                    return 1080;

                case "fr":
                case "fr-fr":
                    return 1036;

                case "fr-be":
                    return 2060;

                case "fr-ca"
:
                    return 3084;

                case "fr-lu":
                    return 5132;

                case "fr-ch":
                    return 4108;

                case "gd-ie":
                    return 2108;

                case "gd":
                    return 1084;

                case "de":
                case "de-de":
                    return 1031;

                case "de-at":
                    return 3079;

                case "de-li":
                    return 5127;

                case "de-lu":
                    return 4103;

                case "de-ch":
                    return 2055;

                case "el":
                    return 1032;

                case "he":
                    return 1037;

                case "hi":
                    return 1081;

                case "hu":
                    return 1038;

                case "is":
                    return 1039;

                case "id":
                    return 1057;

                case "it":
                case "it-it":
                    return 1040;

                case "it-ch":
                    return 2064;

                case "ja":
                    return 1041;

                case "ko":
                    return 1042;

                case "lv":
                    return 1062;

                case "lt":
                    return 1063;

                case "mk":
                    return 1071;

                case "ms":
                case "ms-my":
                    return 1086;

                case "ms-bn":
                    return 2110;

                case "mt":
                    return 1082;

                case "mr":
                    return 1102;

                case "no":
                case "no-no":
                    return 1044;

                case "pl":
                    return 1045;

                case "pt":
                case "pt-pt":
                    return 2070;

                case "pt-br":
                    return 1046;

                case "rm":
                    return 1047;

                case "ro":
                    return 1048;

                case "ro-mo":
                    return 2072;

                case "ru":
                    return 1049;

                case "ru-mo":
                    return 2073;

                case "sa":
                    return 1103;

                case "sr-sp":
                    return 2074;

                case "tn":
                    return 1074;

                case "sl":
                    return 1060;

                case "sk":
                    return 1051;

                case "sb":
                    return 1070;

                case "es":
                case "es-es":
                    return 1034;

                case "es-ar":
                    return 11274;

                case "es-bo":
                    return 16394;

                case "es-cl":
                    return 13322;

                case "es-co":
                    return 9226;

                case "es-cr":
                    return 5130;

                case "es-do":
                    return 7178;

                case "es-ec":
                    return 12298;

                case "es-gt":
                    return 4106;

                case "es-hn":
                    return 18442;

                case "es-mx":
                    return 2058;

                case "es-ni":
                    return 19466;

                case "es-pa":
                    return 6154;

                case "es-pe":
                    return 10250;

                case "es-pr":
                    return 20490;

                case "es-py":
                    return 15370;

                case "es-sv":
                    return 17418;

                case "es-uy":
                    return 14346;

                case "es-ve":
                    return 8202;

                case "st":
                    return 1072;

                case "sw":
                    return 1089;

                case "sv":
                case "sv-se":
                    return 1053;

                case "sv-fi":
                    return 2077;

                case "ta":
                    return 1097;

                case "tt":
                    return 1092;

                case "th":
                    return 1054;

                case "tr":
                    return 1055;

                case "ts":
                    return 1073;

                case "uk":
                    return 1058;

                case "ur":
                    return 1056;

                case "uz-uz":
                    return 1091;

                case "vi":
                    return 1066;

                case "xh":
                    return 1076;

                case "yi":
                    return 1085;

                case "zu":
                    return 1077;

                default:
                    return 1033;
            }
        }
    }
}
