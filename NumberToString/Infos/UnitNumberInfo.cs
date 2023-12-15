using NumberToString.Enums;

namespace NumberToString.Infos;

public static class UnitNumberInfo
{
    public static readonly Dictionary<KeyValuePair<int, Cases>, string> CasesNumDictionary = new()
    {
        // 0
        { new KeyValuePair<int, Cases>(0, Cases.Nominative), "ноль" },
        { new KeyValuePair<int, Cases>(0, Cases.Genitive), "ноля" },
        { new KeyValuePair<int, Cases>(0, Cases.Dative), "нолю" },
        { new KeyValuePair<int, Cases>(0, Cases.Accusative), "ноль" },
        { new KeyValuePair<int, Cases>(0, Cases.Instrumental), "нолём" },
        { new KeyValuePair<int, Cases>(0, Cases.Prepositional), "ноле" },

        // 2 
        { new KeyValuePair<int, Cases>(2, Cases.Genitive), "двух" },
        { new KeyValuePair<int, Cases>(2, Cases.Dative), "двум" },
        { new KeyValuePair<int, Cases>(2, Cases.Instrumental), "двумя" },
        { new KeyValuePair<int, Cases>(2, Cases.Prepositional), "двух" },

        // 3
        { new KeyValuePair<int, Cases>(3, Cases.Nominative), "три" },
        { new KeyValuePair<int, Cases>(3, Cases.Genitive), "трёх" },
        { new KeyValuePair<int, Cases>(3, Cases.Dative), "трём" },
        { new KeyValuePair<int, Cases>(3, Cases.Accusative), "три" },
        { new KeyValuePair<int, Cases>(3, Cases.Instrumental), "тремя" },
        { new KeyValuePair<int, Cases>(3, Cases.Prepositional), "трёх" },

        // 4
        { new KeyValuePair<int, Cases>(4, Cases.Nominative), "четыре" },
        { new KeyValuePair<int, Cases>(4, Cases.Genitive), "четырёх" },
        { new KeyValuePair<int, Cases>(4, Cases.Dative), "четырём" },
        { new KeyValuePair<int, Cases>(4, Cases.Accusative), "четыре" },
        { new KeyValuePair<int, Cases>(4, Cases.Instrumental), "четырьмя" },
        { new KeyValuePair<int, Cases>(4, Cases.Prepositional), "четырёх" },

        // 5
        { new KeyValuePair<int, Cases>(5, Cases.Nominative), "пять" },
        { new KeyValuePair<int, Cases>(5, Cases.Genitive), "пяти" },
        { new KeyValuePair<int, Cases>(5, Cases.Dative), "пяти" },
        { new KeyValuePair<int, Cases>(5, Cases.Accusative), "пять" },
        { new KeyValuePair<int, Cases>(5, Cases.Instrumental), "пятью" },
        { new KeyValuePair<int, Cases>(5, Cases.Prepositional), "пяти" },

        // 6
        { new KeyValuePair<int, Cases>(6, Cases.Nominative), "шесть" },
        { new KeyValuePair<int, Cases>(6, Cases.Genitive), "шести" },
        { new KeyValuePair<int, Cases>(6, Cases.Dative), "шести" },
        { new KeyValuePair<int, Cases>(6, Cases.Accusative), "шесть" },
        { new KeyValuePair<int, Cases>(6, Cases.Instrumental), "шестью" },
        { new KeyValuePair<int, Cases>(6, Cases.Prepositional), "шести" },

        // 7
        { new KeyValuePair<int, Cases>(7, Cases.Nominative), "семь" },
        { new KeyValuePair<int, Cases>(7, Cases.Genitive), "семи" },
        { new KeyValuePair<int, Cases>(7, Cases.Dative), "семи" },
        { new KeyValuePair<int, Cases>(7, Cases.Accusative), "семь" },
        { new KeyValuePair<int, Cases>(7, Cases.Instrumental), "семью" },
        { new KeyValuePair<int, Cases>(7, Cases.Prepositional), "семи" },

        // 8
        { new KeyValuePair<int, Cases>(8, Cases.Nominative), "восемь" },
        { new KeyValuePair<int, Cases>(8, Cases.Genitive), "восьми" },
        { new KeyValuePair<int, Cases>(8, Cases.Dative), "восьми" },
        { new KeyValuePair<int, Cases>(8, Cases.Accusative), "восемь" },
        { new KeyValuePair<int, Cases>(8, Cases.Instrumental), "восемью" },
        { new KeyValuePair<int, Cases>(8, Cases.Prepositional), "восьми" },

        // 9
        { new KeyValuePair<int, Cases>(9, Cases.Nominative), "девять" },
        { new KeyValuePair<int, Cases>(9, Cases.Genitive), "девяти" },
        { new KeyValuePair<int, Cases>(9, Cases.Dative), "девяти" },
        { new KeyValuePair<int, Cases>(9, Cases.Accusative), "девять" },
        { new KeyValuePair<int, Cases>(9, Cases.Instrumental), "девятью" },
        { new KeyValuePair<int, Cases>(9, Cases.Prepositional), "девяти" },
    };

    public static readonly Dictionary<KeyValuePair<int, KeyValuePair<Cases, Genus>>, string> GenresNumDictionary = new()
    {
        // 1 именительный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Nominative, Genus.Male)), "один" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Nominative, Genus.Female)), "одна" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Nominative, Genus.Neuter)), "одно" },

        // 1 родительный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Genitive, Genus.Male)), "одного" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Genitive, Genus.Female)), "одной" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Genitive, Genus.Neuter)), "одного" },

        // 1 дательный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Dative, Genus.Male)), "одному" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Dative, Genus.Female)), "одной" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Dative, Genus.Neuter)), "одному" },

        // 1 винительный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Accusative, Genus.Male)), "один" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Accusative, Genus.Female)), "одну" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Accusative, Genus.Neuter)), "одно" },

        // 1 творительный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Instrumental, Genus.Male)), "одним" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Instrumental, Genus.Female)), "одной" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Instrumental, Genus.Neuter)), "одним" },

        // 1 предложный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Prepositional, Genus.Male)), "одном" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Prepositional, Genus.Female)), "одной" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(1, new KeyValuePair<Cases, Genus>(Cases.Prepositional, Genus.Neuter)), "одном" },

        // 2 именительный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(2, new KeyValuePair<Cases, Genus>(Cases.Nominative, Genus.Male)), "два" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(2, new KeyValuePair<Cases, Genus>(Cases.Nominative, Genus.Female)), "две" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(2, new KeyValuePair<Cases, Genus>(Cases.Nominative, Genus.Neuter)), "два" },

        // 2 винительный
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(2, new KeyValuePair<Cases, Genus>(Cases.Accusative, Genus.Male)), "два" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(2, new KeyValuePair<Cases, Genus>(Cases.Accusative, Genus.Female)), "две" },
        { new KeyValuePair<int, KeyValuePair<Cases, Genus>>(2, new KeyValuePair<Cases, Genus>(Cases.Accusative, Genus.Neuter)), "два" },
    };
}