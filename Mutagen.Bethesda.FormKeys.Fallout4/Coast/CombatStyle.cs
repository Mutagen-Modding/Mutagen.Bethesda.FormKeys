// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class CombatStyle
    {
        private static FormLink<ICombatStyleGetter> Construct(uint id) => new FormLink<ICombatStyleGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ICombatStyleGetter> DLC03csRobobrainPaintball => Construct(0x5d0b2);
        public static FormLink<ICombatStyleGetter> DLC03_csCaptainsBlend => Construct(0x541f6);
        public static FormLink<ICombatStyleGetter> DLC03csHermitCrab => Construct(0x4f4ad);
        public static FormLink<ICombatStyleGetter> csDLC03_Angler => Construct(0x4aed9);
        public static FormLink<ICombatStyleGetter> csDLC03_Gulper => Construct(0x4aed8);
        public static FormLink<ICombatStyleGetter> csDLC03_FogCrawler => Construct(0x1c86f);
    }
}
