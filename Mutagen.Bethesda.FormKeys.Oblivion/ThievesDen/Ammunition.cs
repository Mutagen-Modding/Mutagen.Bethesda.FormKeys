using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Ammunition
        {
            private static FormLink<IAmmunitionGetter> Construct(uint id) => new FormLink<IAmmunitionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAmmunitionGetter> DLC06EncArrow1Knockdown => Construct(0xba42);
            public static FormLink<IAmmunitionGetter> DLC06EncArrow1DrFatigue => Construct(0xba51);
            public static FormLink<IAmmunitionGetter> DLC06EncArrow2DrFatigue => Construct(0xba53);
            public static FormLink<IAmmunitionGetter> DLC06EncArrow3DrFatigue => Construct(0xba54);
            public static FormLink<IAmmunitionGetter> DLC06EncArrow1Light => Construct(0xba45);
            public static FormLink<IAmmunitionGetter> DLC06EncArrow1Blindness => Construct(0xba44);
        }
    }
}
