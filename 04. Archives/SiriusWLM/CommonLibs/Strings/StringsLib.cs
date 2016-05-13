using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System.Globalization;

namespace Sirius.CommonLibs
{
    public static class StringsLib
    {
        public static string GetRandomString(int size)
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[size];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length - 1)]);
            }
            return result.ToString();
        }

        public static string GetRandomStringDistinct(int size)
        {
            char[] chars = new char[32];
            chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[size];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length - 1)]);
            }
            return result.ToString();
        }

        public static string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            return (propertyExpression.Body as MemberExpression).Member.Name;
        }

        public static string GetRepeatString(this string input, int count)
        {
            StringBuilder builder = new StringBuilder(
                (input == null ? 0 : input.Length) * count);

            for (int i = 0; i < count; i++) builder.Append(input);
            return builder.ToString();
        }

        public static string GetNumberFromId(int id, int size)
        {
            string format = new string('0', size);
            return id.ToString(format);
        }

        public static string GetUniqueNumberFromDateTimeNow()
        {
            return DateTime.Now.ToString("yyMMddHHmmss");
        }

        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system (in the range [2, 36]).</param>
        /// <returns></returns>
        public static string ConvertBase10ToBase32(int base10Number, int size)
        {
            const string Digits = "23456789ABCDEFGHJKLMNPQRSTUVWXYZ";

            if (base10Number == 0)
                return new string(Digits[0], size);

            int index = 31;
            long currentNumber = Math.Abs(base10Number);
            char[] charArray = new char[32];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % 32);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / 32;
            }

            string result = new String(charArray, index + 1, 32 - index - 1);
            result = result.PadLeft(size, Digits[0]);
            if (base10Number < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        public static DateTime? ConvertFromShortStringToDate(string shortString)
        {
            shortString = shortString.Trim();
            //ShortString de forma 311213 = 31.12.2013
            DateTime? result = null;
            if (shortString.Length == 6)
            {
                int numericValue;
                if (int.TryParse(shortString, out numericValue))
                {
                    DateTime dateTemp;
                    if (DateTime.TryParseExact(shortString, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTemp))
                    {
                        result = dateTemp;
                    }
                }
            }
            return result;
        }

        public static string ConvertFromDateToShortString(DateTime date)
        {
            return date.ToString("ddMMyy");
        }

        public static string GetLetterByIndex(int index)
        {
            string letterArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "A";
            if ((index >= 0) && (index <= (letterArray.Length - 1)))
            {
                result = new string(new char[] { letterArray[index] });
            }
            return result;
        }

        public static bool ValidateEmailAddress(string emailAddress)
        {
            Regex emailregex = new Regex("(?<user>[^@]+)@(?<host>.+)");
            Match m = emailregex.Match(emailAddress);
            return m.Success;
        }

        public static string Right(this string text, int length)
        {
            if (string.IsNullOrEmpty(text) || length <= 0)
            {
                return string.Empty;
            }

            if (length < text.Length)
            {
                return text.Substring(text.Length - length);
            }

            return text;
        }

        public static string Left(this string text, int length)
        {
            if (string.IsNullOrEmpty(text) || length <= 0)
            {
                return string.Empty;
            }

            if (length < text.Length)
            {
                return text.Substring(0, length);
            }

            return text;
        }
    }
}
