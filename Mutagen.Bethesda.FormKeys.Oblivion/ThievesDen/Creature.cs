// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Creature
        {
            private static FormLink<ICreatureGetter> Construct(uint id) => new FormLink<ICreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICreatureGetter> DLC06CreatureSkeleton4Champion => Construct(0x11ade);
            public static FormLink<ICreatureGetter> DLCBoar => Construct(0x3e8f);
            public static FormLink<ICreatureGetter> DL06Dog => Construct(0x34a2);
            public static FormLink<ICreatureGetter> DLC06CreatureSkeleton1 => Construct(0x11ad8);
            public static FormLink<ICreatureGetter> DLC06CreatureSkeleton2 => Construct(0x11ada);
            public static FormLink<ICreatureGetter> DLC06CreatureSkeleton3Hero => Construct(0x11adc);
        }
    }
}
