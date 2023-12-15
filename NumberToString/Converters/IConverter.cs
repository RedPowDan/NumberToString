using NumberToString.Enums;

namespace NumberToString.Converters;

public interface IConverter
{
    public bool CanInvoke(int num);
    
    public string NumberToWord(int num, Cases @case, Genus genus);
}