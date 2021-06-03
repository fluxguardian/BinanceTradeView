using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceTradeView
{
    public class cHelper
    {
        public static void JsonSave<T>(string FileName, T dataList)
        {
            try
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory))
                    return;

                string path = AppDomain.CurrentDomain.BaseDirectory + "\\" + FileName + ".json";

                if (File.Exists(path))
                    File.Delete(path);
                FileStream fsError = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter swError = new StreamWriter(fsError);
                swError.WriteLine(JsonConvert.SerializeObject(dataList));
                swError.Close();
                fsError.Close();
            }
            catch { }
        }

        #region Convert İşlemleri

        //--------------------------------------------------
        public static string BosveNullIseNoktaYaz(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return ".";
            }
            else
            {
                return value;
            }
        }

        //--------------------------------------------------
        public static int StrToInt(string value)
        {
            if (!int.TryParse(value, out int deger))
            {
                deger = 0;
            }
            return deger;
        }

        //--------------------------------------------------
        public static DateTime StrToDateTime(string value)
        {
            if (!DateTime.TryParse(value, out DateTime deger))
            {
                deger = DateTime.MinValue;
            }
            return deger;
        }

        //--------------------------------------------------
        public static double StrToDouble(string value)
        {
            if (!double.TryParse(value, out double deger))
            {
                deger = 0;
            }
            return deger;
        }

        public static double ObjToDouble(object value)
        {
            double deger = 0;
            if (value != null)
            {
                //var test = value.ToString();
                if (!double.TryParse(value.ToString().Replace(",", "."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out deger))
                {
                    deger = 0;
                }
            }
            else
            {
                deger = 0;
            }
            return deger;
        }

        //--------------------------------------------------
        public static decimal ObjToDecimal(object value)
        {
            decimal deger = 0;
            if (value != null)
            {
                //var test = value.ToString();
                if (!decimal.TryParse(value.ToString().Replace(",", "."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out deger))
                {
                    deger = 0;
                }
            }
            else
            {
                deger = 0;
            }
            return deger;
        }

        //--------------------------------------------------
        /// <summary>
        /// Objenin int ise dönüştürülmesini sağlar
        /// </summary>
        /// <param name="value"> Herhangi bir object value</param>
        /// <returns></returns>
        public static int ObjToInt(object value)
        {
            int deger;
            if (value != null)
            {
                if (!int.TryParse(value.ToString(), out deger))
                {
                    deger = 0;
                }
            }
            else
            {
                deger = 0;
            }
            return deger;
        }

        //--------------------------------------------------
        public static DateTime ObjToDateTime(object value)
        {
            var Formats = new[] { "dd.MM.yyyy HH:mm:ss", "dd-MM-yyyy HH:mm:ss", "yyyy-MM-dd HH:mm:ss", "yyyy.MM.dd HH:mm:ss" };

            DateTime deger = new DateTime(1881, 5, 19);
            if (!DateTime.TryParseExact(value.ToString(), Formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out deger))
            {
                deger = new DateTime(1881, 5, 19);
            }
            return deger;
        }

        //--------------------------------------------------
        public static bool ObjToBoolean(object value)
        {
            bool deger;
            if (value != null)
            {
                if (value.ToString() == "0")
                    return false;
                if (value.ToString() == "1")
                    return true;
                if (!bool.TryParse(value.ToString(), out deger))
                {
                    deger = false;
                }
            }
            else
            {
                deger = false;
            }
            return deger;
        }

        //--------------------------------------------------

        public static string ObjToStr(object value)
        {
            if (value != null)
            {
                return value.ToString();
            }
            else
            {
                return "";
            }
        }


        #endregion Convert İşlemleri

    }
}
