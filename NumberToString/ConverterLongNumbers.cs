using System.Text;
using NumberToString.Converters;
using NumberToString.Enums;
using NumberToString.Infos;

namespace NumberToString;

public class ConverterLongNumbers
{
    private const long MaxValue = 999999999999;

    private const int MinValue = 0;

    private const int ChunkSize = 3;

    private static readonly IConverter Converter = new AggregateConverter();

    /// <summary>
    /// Конвертация числа в строку прописью
    /// </summary>
    /// <param name="value">Число</param>
    /// <param name="case">Падеж</param>
    /// <param name="genus">Род</param>
    /// <returns>Число прописью</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> вне диапазона 0 - 999 999 999 999</exception>
    public static string ConvertNumToWord(long value, Cases @case, Genus genus)
    {
        if (value > 999999999999 && value < 0)
        {
            throw new ArgumentOutOfRangeException($"Значение '{nameof(value)}' должно быть от 0 до 999 999 999 999");
        }

        var listOfWords = new List<string>();
        var grouped = SplitNumberToGroups(value);
        var countOfGroups = grouped.Length;
        var iteration = 0;
        foreach (var group in grouped)
        {
            iteration++;

            var digit1 = group[0] - '0';
            var digit2 = group[1] - '0';
            var digit3 = group[2] - '0';

            if (digit1 is 0 && digit2 is 0 && digit3 is 0)
            {
                if (countOfGroups is 1)
                {
                    var word = Converter.NumberToWord(digit3, @case, genus);
                    listOfWords.Add(word);
                    break;
                }

                // пропускаем группу
                continue;
            }

            if (digit1 > 0)
            {
                var word1 = Converter.NumberToWord(digit1 * 100, @case, genus);
                listOfWords.Add(word1);
            }

            var digit23 = digit2 * 10 + digit3;

            if (digit23 is > 9 and < 20)
            {
                var word23 = Converter.NumberToWord(digit23, @case, genus);
                listOfWords.Add(word23);
            }
            else
            {
                if (digit2 > 1)
                {
                    var word2 = Converter.NumberToWord(digit2 * 10, @case, genus);
                    listOfWords.Add(word2);
                }

                if (digit3 > 0)
                {
                    var word3 = Converter.NumberToWord(digit3, @case, genus);
                    listOfWords.Add(word3);
                }
            }

            var scaleForm = 2;
            if (digit3 is > 0 and < 5)
            {
                scaleForm = digit3 == 1 ? 0 : 1;
            }

            var currentNumberScale = countOfGroups - iteration;

            var scaleName = UnitNameInfo.GetNumberScaleName(currentNumberScale, scaleForm, @case);

            if (scaleName.Equals(string.Empty))
            {
                continue;
            }

            listOfWords.Add(scaleName);
        }

        return string.Join(' ', listOfWords);
    }


    /// <summary>
    /// Преобразование числа в строковые группы, по 3 цифры каждая
    /// </summary>
    /// <param name="value">Число на преобразование</param>
    /// <returns>Группы цифр</returns>
    private static string[] SplitNumberToGroups(long value)
    {
        var strValue = value.ToString();

        var length = strValue.Length;
        var countOfZeroToAdd = (ChunkSize - length % ChunkSize) % ChunkSize;

        var str = new StringBuilder();
        str.Append('0', countOfZeroToAdd);
        str.Append(strValue);

        return Enumerable.Range(0, str.Length / ChunkSize)
            .Select(e => str.ToString(e * ChunkSize, ChunkSize))
            .ToArray();
    }
}