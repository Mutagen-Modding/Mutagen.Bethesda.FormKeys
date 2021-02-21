using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            private static FormLink<IPlaceGetter> Construct(uint id) => new FormLink<IPlaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlaceGetter> DLCHorseArmorDummyCell => Construct(0x1bb0);
        }
    }
}
