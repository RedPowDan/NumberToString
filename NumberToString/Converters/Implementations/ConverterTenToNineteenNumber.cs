using NumberToString.Enums;
using NumberToString.Infos;

namespace NumberToString.Converters.Implementations;

/// <inheritdoc />
internal sealed class ConverterTenToNineteenNumber : IConverter
{
    /// <inheritdoc />
    public bool CanInvoke(int num)
    {
        return num is >= 10 and <= 19;
    }

    /// <inheritdoc />
    public string NumberToWord(int num, Cases @case, Genus genus)
    {
        return TenToNineteenNumberInfo.CasesNumDictionary.TryGetValue(new KeyValuePair<int, Cases>(num, @case), out var numStr)
            ? numStr
            : string.Empty;
    }
}