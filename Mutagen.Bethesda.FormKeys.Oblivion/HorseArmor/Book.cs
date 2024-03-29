// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class HorseArmor
{
    public static partial class Book
    {
        private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IBookGetter> DLCHorseArmorNote => Construct(0x5235);
        public static FormLink<IBookGetter> DLCHorseArmorPlans => Construct(0x16c6);
    }
}
