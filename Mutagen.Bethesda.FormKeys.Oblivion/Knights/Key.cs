using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Key
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<IKeyGetter> Construct(uint id) => new FormLink<IKeyGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeyGetter> ND05FortKey => Construct(0xfbf);
            public static FormLink<IKeyGetter> ND01AmielKey => Construct(0xfc0);
            public static FormLink<IKeyGetter> ND02PrioryKey => Construct(0xfc1);
        }
    }
}
