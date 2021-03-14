using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Potion
        {
            private static FormLink<IPotionGetter> Construct(uint id) => new FormLink<IPotionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPotionGetter> DLC06LockSolvent => Construct(0x79c9);
            public static FormLink<IPotionGetter> DLC06LockSolvent2 => Construct(0x79ca);
            public static FormLink<IPotionGetter> DLC06Nightmask1 => Construct(0x83aa);
            public static FormLink<IPotionGetter> DLC06Nightmask2 => Construct(0x83ab);
            public static FormLink<IPotionGetter> DLC06Nightmask3 => Construct(0x83ad);
            public static FormLink<IPotionGetter> DLC06LockSolvent3 => Construct(0x79cc);
        }
    }
}
