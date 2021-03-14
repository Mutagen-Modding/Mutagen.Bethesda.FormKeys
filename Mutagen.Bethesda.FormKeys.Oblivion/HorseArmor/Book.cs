using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Book
        {
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> DLCHorseArmorNote => Construct(0x5235);
            public static FormLink<IBookGetter> DLCHorseArmorPlans => Construct(0x16c6);
        }
    }
}
