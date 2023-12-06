using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeIntegerUtility
{
    public static class DateTimeConverter
    {
        public static int DateTimeToInt(in DateTime? dateTime)
        {
            if (dateTime is null)
            {
                return 0;
            }

            var stringDatetime = dateTime?.ToString("yyyyMMdd");
            var isParseOk = int.TryParse(stringDatetime, out var result);
            switch (isParseOk)
            {
                case true: return result;
                case false:
                default:
                    throw new InvalidOperationException($"DateTimeからIntへの変換に失敗しました。 DateTime={dateTime}");
            }
        }

        public static DateTime? IntToDateTime(in int dateTimeInteger)
        {
            if (dateTimeInteger == 0)
                return null;

            var stringDateTime = dateTimeInteger.ToString();

            if (stringDateTime.Length != 8)
            {
                throw new ArgumentException($"引数の桁数が不正です。 8桁の整数を入力してください。int={dateTimeInteger}");
            }

            var year = stringDateTime.AsSpan(0, 4);
            var month = stringDateTime.AsSpan(4, 2);
            var day = stringDateTime.AsSpan(6, 2);

            var formatedDateTime = $"{year}-{month}-{day}";

            var isParseOk = DateTime.TryParse(formatedDateTime, out var result);
            switch (isParseOk)
            {
                case true: return result;
                case false:
                default:
                    throw new InvalidOperationException($"IntからDateTimeへの変換に失敗しました。int={dateTimeInteger}");
            }
        }
    }
}
