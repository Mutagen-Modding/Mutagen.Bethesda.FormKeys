// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static class ArmorAddon
    {
        private static FormLink<IArmorAddonGetter> Construct(uint id) => new FormLink<IArmorAddonGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IArmorAddonGetter> AAVault88SuitClean => Construct(0x5265);
        public static FormLink<IArmorAddonGetter> AAVault88Suit => Construct(0x5263);
    }
}