using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Armor
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IArmorGetter> Construct(uint id) => new FormLink<IArmorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArmorGetter> DLCBattlehornShieldOfTrueHorn => Construct(0x97d3);
            public static FormLink<IArmorGetter> DLCBattlehornShieldReward01 => Construct(0x11f17);
            public static FormLink<IArmorGetter> DLCBattlehornShieldReward05 => Construct(0x11f19);
            public static FormLink<IArmorGetter> DLCBattlehornShieldReward10 => Construct(0x11f1a);
            public static FormLink<IArmorGetter> DLCBattlehornShieldReward15 => Construct(0x11f1b);
            public static FormLink<IArmorGetter> DLCBattlehornShieldReward20 => Construct(0x11f1c);
            public static FormLink<IArmorGetter> DLCBattlehornShieldofLight => Construct(0x156c9);
            public static FormLink<IArmorGetter> DLCBattlehornShieldReward25 => Construct(0x11f1d);
            public static FormLink<IArmorGetter> DLCBattlehornShieldReward30 => Construct(0x11f1e);
        }
    }
}
