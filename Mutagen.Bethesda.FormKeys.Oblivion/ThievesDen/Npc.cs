using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> DLC06Fence => Construct(0x348f);
            public static FormLink<INpcGetter> DLC06Supplier => Construct(0x3492);
            public static FormLink<INpcGetter> DLC06StealthTrainer => Construct(0x2fa1);
            public static FormLink<INpcGetter> DLC06FirstMate => Construct(0x398b);
            public static FormLink<INpcGetter> DLC06Pirate03 => Construct(0x11ad6);
            public static FormLink<INpcGetter> DLC06Pirate01 => Construct(0x398e);
            public static FormLink<INpcGetter> DLC06Pirate02 => Construct(0x398f);
            public static FormLink<INpcGetter> DLC06SecurityTrainer => Construct(0x348b);
            public static FormLink<INpcGetter> DLC06Fletcher => Construct(0x2f9f);
        }
    }
}