using System.Reflection;

namespace BigMission.DeviceApp.Shared
{
    /// <summary>
    /// Canned channel unit conversion options.
    /// </summary>
    public class ChannelConversion
    {
        public static string NONE = "none";
        public static string C_TO_F = "c_to_f";
        public static string F_TO_C = "f_to_c";
        public static string K_TO_F = "k_to_f";
        public static string K_TO_C = "k_to_c";
        public static string BAR_TO_PSI = "bar_to_psi";
        public static string PSI_TO_BAR = "psi_to_bar";
        public static string KPA_TO_PSI = "kpa_to_psi";
        public static string KPH_TO_MPH = "kph_to_mph";
        public static string MPH_TO_KPH = "mph_to_kph";
        public static string KM_TO_MI = "km_to_mi";
        public static string MI_TO_KM = "mi_to_km";
        public static string MM_TO_INCH = "mm_to_inch";
        public static string INCH_TO_MM = "inch_to_mm";
        public static string L_TO_GAL = "l_to_gal";
        public static string GAL_TO_L = "gal_to_l";
        public static string CC_TO_GAL = "cc_to_gal";
        public static string CC_TO_L = "cc_to_l";
        public static string KG_TO_LB = "kg_to_lb";
        public static string LB_TO_KG = "lb_to_kg";
        public static string NM_TO_LBFT = "nm_to_lbft";
        public static string LBFT_TO_NM = "lbft_to_nm";
        public static string W_TO_HP = "w_to_hp";
        public static string HP_TO_W = "hp_to_w";

        public static string[] Types = new string[]
        {
            NONE,
            C_TO_F,
            F_TO_C,
            K_TO_F,
            K_TO_C,
            BAR_TO_PSI,
            PSI_TO_BAR,
            KPA_TO_PSI,
            KPH_TO_MPH,
            MPH_TO_KPH,
            KM_TO_MI,
            MI_TO_KM,
            MM_TO_INCH,
            INCH_TO_MM,
            L_TO_GAL,
            GAL_TO_L,
            CC_TO_GAL, 
            CC_TO_L,
            KG_TO_LB,
            LB_TO_KG,
            NM_TO_LBFT,
            LBFT_TO_NM,
            W_TO_HP,
            HP_TO_W
        };

        public static double c_to_f(double value)
        {
            return value * 1.8f + 32;
        }

        public static double f_to_c(double value)
        {
            return (value - 32) * 0.555555556f;
        }

        public static double k_to_f(double value)
        {
            return (value * 1.8) - 459.67;
        }

        public static double k_to_c(double value)
        {
            return value - 273.15;
        }

        public static double bar_to_psi(double value)
        {
            return value * 14.5037738;
        }

        public static double psi_to_bar(double value)
        {
            return value * 0.0689475729;
        }

        public static double kpa_to_psi(double value)
        {
            return value * 0.1450377377;
        }

        public static double kph_to_mph(double value)
        {
            return value * 0.6213711922;
        }

        public static double mph_to_kph(double value)
        {
            return value * 1.609344;
        }

        public static double km_to_mi(double value)
        {
            return value * 0.6213711922;
        }

        public static double mi_to_km(double value)
        {
            return value * 1.609344;
        }

        public static double mm_to_inch(double value)
        {
            return value * 0.0393700787;
        }

        public static double inch_to_mm(double value)
        {
            return value * 25.4;
        }

        public static double l_to_gal(double value)
        {
            return value * 0.2641720524;
        }

        public static double gal_to_l(double value)
        {
            return value * 3.785411784;
        }

        public static double cc_to_gal(double value)
        {
            return value * 0.000264172;
        }

        public static double cc_to_l(double value)
        {
            return value * 0.001;
        }

        public static double kg_to_lb(double value)
        {
            return value * 2.2046226218;
        }

        public static double lb_to_kg(double value)
        {
            return value * 0.45359237;
        }

        public static double nm_to_lbft(double value)
        {
            return value * 0.7375621493;
        }

        public static double lbft_to_nm(double value)
        {
            return value * 1.3558179483;
        }

        public static double w_to_hp(double value)
        {
            return value * 0.0013410221;
        }

        public static double hp_to_w(double value)
        {
            return value * 745.69987158;
        }


        /// <summary>
        /// Applies a unit conversion.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="conversion"></param>
        /// <returns></returns>
        public static double Convert(double value, string conversion)
        {
            if (!string.IsNullOrWhiteSpace(conversion) && conversion != NONE)
            {
                var method = typeof(ChannelConversion).GetMethod(conversion, BindingFlags.Public | BindingFlags.Static);
                if (method != null)
                {
                    return (double)method.Invoke(null, new object[] { value });
                }
            }
            return value;
        }
    }
}
