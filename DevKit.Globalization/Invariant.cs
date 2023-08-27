using System;
using System.Globalization;

namespace DevKit.Globalization
{
    /// <summary>
    /// Provides methods for culture-independent parsing and formatting.
    /// </summary>
    public static class Invariant
    {
        /// <summary>
        /// Gets invariant culture.
        /// </summary>
        public static CultureInfo Culture => CultureInfo.InvariantCulture;

        /// <summary>
        /// Converts the string representation of a number to its byte equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A byte equivalent to the number specified in s.</returns>
        public static byte ParseByte(string s) => byte.Parse(s, NumberStyles.Integer, Culture);

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 16-bit signed integer equivalent to the number specified in s.</returns>
        public static short ParseInt16(string s) => short.Parse(s, NumberStyles.Integer, Culture);

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 32-bit signed integer equivalent to the number specified in s.</returns>
        public static int ParseInt32(string s) => int.Parse(s, NumberStyles.Integer, Culture);

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 64-bit signed integer equivalent to the number specified in s.</returns>
        public static long ParseInt64(string s) => long.Parse(s, NumberStyles.Integer, Culture);

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A double-precision floating-point equivalent to the number specified in s.</returns>
        public static double ParseDouble(string s) => double.Parse(s, NumberStyles.Number, Culture);

        /// <summary>
        /// Converts the string representation of a number to its decimal equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A decimal equivalent to the number specified in s.</returns>
        public static decimal ParseDecimal(string s) => decimal.Parse(s, NumberStyles.Number, Culture);

        /// <summary>
        /// Converts the string representation of a time interval to its TimeSpan equivalent.
        /// </summary>
        /// <param name="s">A string containing a time interval to convert.</param>
        /// <returns>A TimeSpan equivalent to the time interval specified in s.</returns>
        public static TimeSpan ParseTimeSpan(string s) => TimeSpan.Parse(s, Culture);

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <returns>A DateTime equivalent to the date and time specified in s.</returns>
        public static DateTime ParseDateTime(string s) => DateTime.Parse(s, Culture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// Converts the string representation of a number to its byte equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="result">A byte equivalent to the number specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseByte(string s, out byte result) => byte.TryParse(s, NumberStyles.Integer, Culture, out result);

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="result">A 16-bit signed integer equivalent to the number specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseInt16(string s, out short result) => short.TryParse(s, NumberStyles.Integer, Culture, out result);

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="result">A 32-bit signed integer equivalent to the number specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseInt32(string s, out int result) => int.TryParse(s, NumberStyles.Integer, Culture, out result);

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="result">A 64-bit signed integer equivalent to the number specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseInt64(string s, out long result) => long.TryParse(s, NumberStyles.Integer, Culture, out result);

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="result">A double-precision floating-point number equivalent to the number specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseDouble(string s, out double result) => double.TryParse(s, NumberStyles.Number, Culture, out result);

        /// <summary>
        /// Converts the string representation of a number to its decimal equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="result">A decimal equivalent to the number specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseDecimal(string s, out decimal result) => decimal.TryParse(s, NumberStyles.Number, Culture, out result);

        /// <summary>
        /// Converts the string representation of a time interval to its TimeSpan equivalent.
        /// </summary>
        /// <param name="s">A string containing a time interval to convert.</param>
        /// <param name="result">A TimeSpan equivalent to the time interval specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseTimeSpan(string s, out TimeSpan result) => TimeSpan.TryParse(s, Culture, out result);

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a time interval to convert.</param>
        /// <param name="result">A DateTime equivalent to the date and time specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseUtcDateTime(string s, out DateTime result) => DateTime.TryParse(s, Culture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal, out result);

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a time interval to convert.</param>
        /// <param name="result">A DateTime equivalent to the date and time specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseLocalDateTime(string s, out DateTime result) => DateTime.TryParse(s, Culture, DateTimeStyles.AssumeLocal, out result);

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a time interval to convert.</param>
        /// <param name="result">A DateTime equivalent to the date and time specified in s.</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseUnspecifiedDateTime(string s, out DateTime result) => DateTime.TryParse(s, Culture, DateTimeStyles.None, out result);

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <returns>A DateTime equivalent to the date and time specified in s.</returns>
        public static string? ConvertToString(object o) => Convert.ToString(o, Culture);

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <returns>A DateTime equivalent to the date and time specified in s.</returns>
        public static bool ConvertToBoolean(object o) => Convert.ToBoolean(o, Culture);

        /// <summary>
        /// Converts the string representation of a number to its byte equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A byte equivalent to the number specified in s.</returns>
        public static byte ConvertToByte(object o) => Convert.ToByte(o, Culture);

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 16-bit signed integer equivalent to the number specified in s.</returns>
        public static short ConvertToInt16(object o) => Convert.ToInt16(o, Culture);

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 32-bit signed integer equivalent to the number specified in s.</returns>
        public static int ConvertToInt32(object o) => Convert.ToInt32(o, Culture);

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 64-bit signed integer equivalent to the number specified in s.</returns>
        public static long ConvertToInt64(object o) => Convert.ToInt64(o, Culture);

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A double-precision floating-point equivalent to the number specified in s.</returns>
        public static double ConvertToDouble(object o) => Convert.ToDouble(o, Culture);

        /// <summary>
        /// Converts the string representation of a number to its decimal equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A decimal equivalent to the number specified in s.</returns>
        public static decimal ConvertToDecimal(object o) => Convert.ToDecimal(o, Culture);

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <returns>A DateTime equivalent to the date and time specified in s.</returns>
        public static DateTime ConvertToDateTime(object o) => Convert.ToDateTime(o, Culture);

        /// <summary>
        /// Replaces the format items in a string with the string representation of a specified object.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The object to format.</param>
        /// <returns>A copy of format in which any format items are replaced by the string representation
        /// of arg0.</returns>
        public static string Format(string format, object arg0) => string.Format(Culture, format, arg0);

        /// <summary>
        /// Replaces the format items in a string with the string representation of two specified objects.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to format.</param>
        /// <param name="arg1">The second object to format.</param>
        /// <returns>A copy of format in which any format items are replaced by the string representation
        /// of arg0 and arg1.</returns>
        public static string Format(string format, object arg0, object arg1) => string.Format(Culture, format, arg0, arg1);

        /// <summary>
        /// Replaces the format items in a string with the string representation of three specified objects.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to format.</param>
        /// <param name="arg1">The second object to format.</param>
        /// <param name="arg2">The third object to format.</param>
        /// <returns>A copy of format in which any format items are replaced by the string representation
        /// of arg0, arg1, and arg2.</returns>
        public static string Format(string format, object arg0, object arg1, object arg2) => string.Format(Culture, format, arg0, arg1, arg2);

        /// <summary>
        /// Replaces the format items in a string with the string representation of a corresponding object
        /// in a specified array.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">A copy of format in which the format items have been replaced by the string
        /// representation of the corresponding objects in args.</param>
        /// <returns>A copy of format in which any format items are replaced by the string representation
        /// of the corresponding objects in args.</returns>
        public static string Format(string format, params object[] args) => string.Format(Culture, format, args);

        /// <summary>
        /// Formats the value of the instance using the invariant culture.
        /// </summary>
        /// <typeparam name="T">Type of the instance.</typeparam>
        /// <param name="formattable">The instance to format.</param>
        /// <returns>The formatted value.</returns>
        public static string ToInvariant<T>(this T formattable) where T : IFormattable
        {
            if (formattable is null)
            {
                throw new ArgumentNullException(nameof(formattable));
            }
            return formattable.ToString(null, Culture);
        }

        /// <summary>
        /// Formats the value of the instance using the invariant culture.
        /// </summary>
        /// <typeparam name="T">Type of the instance.</typeparam>
        /// <param name="formattable">The instance to format.</param>
        /// <param name="format">The format to use.</param>
        /// <returns>The formatted value.</returns>
        public static string ToInvariant<T>(this T formattable, string format) where T : IFormattable
        {
            if (formattable is null)
            {
                throw new ArgumentNullException(nameof(formattable));
            }
            return formattable.ToString(format, Culture);
        }
    }
}
