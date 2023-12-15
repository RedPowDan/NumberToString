using NumberToString.Enums;
using NumberToString.Infos;

namespace NumberToString.Converters.Implementations;

/// <inheritdoc />
internal sealed class ConverterHundredNumber : IConverter
{
    /// <inheritdoc />
    public bool CanInvoke(int num)
    {
        return num >= 100 && !(num > 900 & num % 100 != 0);
    }

    /// <inheritdoc />
    public string NumberToWord(int num, Cases @case, Genus genus)
    {
        return HundredNumberInfo.CasesNumDictionary.TryGetValue(new KeyValuePair<int, Cases>(num, @case), out var numStr)
            ? numStr
            : string.Empty;
    }
}