// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Keyword
        {
            private static FormLink<IKeywordGetter> Construct(uint id) => new FormLink<IKeywordGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeywordGetter> ArmorMaterialBlades => Construct(0x9c0);
            public static FormLink<IKeywordGetter> ArmorMaterialThievesGuildLeader => Construct(0x9bf);
            public static FormLink<IKeywordGetter> ArmorMaterialBearStormcloak => Construct(0x9be);
            public static FormLink<IKeywordGetter> ArmorMaterialFalmer => Construct(0x9bd);
            public static FormLink<IKeywordGetter> ArmorMaterialThievesGuild => Construct(0x9bc);
            public static FormLink<IKeywordGetter> ArmorMaterialPenitus => Construct(0x9bb);
            public static FormLink<IKeywordGetter> ArmorMaterialMS02Forsworn => Construct(0x9ba);
            public static FormLink<IKeywordGetter> ArmorMaterialForsworn => Construct(0x9b9);
            public static FormLink<IKeywordGetter> ImmuneDragonPairedKill => Construct(0x9a2);
            public static FormLink<IKeywordGetter> WEDL06Letrush => Construct(0x99f);
            public static FormLink<IKeywordGetter> DA15WabbajackExcludedKeyword => Construct(0x997);
        }
    }
}
