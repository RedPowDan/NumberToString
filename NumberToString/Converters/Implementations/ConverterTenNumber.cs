using NumberToString.Enums;
using NumberToString.Infos;

namespace NumberToString.Converters.Implementations;

/// <inheritdoc />
internal sealed class ConverterTenNumber : IConverter
{
    /// <inheritdoc />
    public bool CanInvoke(int num)
    {
        return num >= 20 && !(num > 90 & num % 10 != 0);
    }

    /// <inheritdoc />
    public string NumberToWord(int num, Cases @case, Genus genus)
    {
        return TenNumberInfo.CasesNumDictionary.TryGetValue(new KeyValuePair<int, Cases>(num, @case), out var numStr)
            ? numStr
            : string.Empty;
    }
}