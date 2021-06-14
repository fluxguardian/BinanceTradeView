using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        public static long GetTimeStamp(DateTime _dateTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (long)(_dateTime - epoch).TotalMilliseconds;
        }
        public static long GetTimeStamp()
        {
            return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
        }

        public static DateTime GetDate(long timeStamp)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var date = start.AddMilliseconds(timeStamp).ToLocalTime();
            return date;
        }
        //public static long GetTimeStamp()
        //{
        //    var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //    return (long)(DateTime.Now.AddHours(-3) - epoch).TotalMilliseconds;
        //}

        public static string GetSignature(List<Parameter> parameters)
        {
            var signature = "";
            if (parameters.Count > 0)
            {
                foreach (var item in parameters)
                {
                    if (item.Type == ParameterType.QueryString)
                        signature += $"{item.Name}={item.Value}&";
                }
                signature = signature.Substring(0, signature.Length - 1);
            }
            byte[] keyBytes = Encoding.UTF8.GetBytes(cBinance.binanceApiSecretKey);
            byte[] valueBytes = Encoding.UTF8.GetBytes(signature);
            return HashEncode(HashHMAC(keyBytes, valueBytes));
        }

        private static byte[] HashHMAC(byte[] key, byte[] message)
        {
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(message);
        }

        private static string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public static void GetBalances()
        {
            Task.Run(() =>
            {
                cLists.Balances = cBinance.GetBalances();
            });
        }

        public static void GetExhangeInfos()
        {
            Task.Run(() =>
            {
                cLists.ExchangeInfos = cBinance.GetExchangeInfos();
            });
        }

        public static string[] GetSize(string size)
        {
            var mask = "";
            var digit = "";

            switch (size)
            {
                case "1.00000000":
                    mask = "#,##0";
                    digit = "0";
                    break;
                case "0.10000000":
                    mask = "#,##0.#";
                    digit = "1";
                    break;
                case "0.01000000":
                    mask = "#,##0.##";
                    digit = "2";
                    break;
                case "0.00100000":
                    mask = "#,##0.###";
                    digit = "3";
                    break;
                case "0.00010000":
                    mask = "#,##0.####";
                    digit = "4";
                    break;
                case "0.00001000":
                    mask = "#,##0.#####";
                    digit = "5";
                    break;
                case "0.00000100":
                    mask = "#,##0.######";
                    digit = "6";
                    break;
                case "0.00000010":
                    mask = "#,##0.#######";
                    digit = "7";
                    break;
                case "0.00000001":
                    mask = "#,##0.########";
                    digit = "8";
                    break;
            }

            string[] result = new string[2];
            result[0] = mask;
            result[1] = digit;
            return result;
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
            bool isNegative = false;

            if (value != null)
            {
                //var test = value.ToString();
                
                if (value.ToString().Contains("-"))
                {
                    value = value.ToString().Replace("-","");
                    isNegative = true;
                }

                if (!decimal.TryParse(value.ToString().Replace(",", "."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out deger))
                {
                    deger = 0;
                }
            }
            else
            {
                deger = 0;
            }

            if (isNegative)
                deger *= -1;

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
