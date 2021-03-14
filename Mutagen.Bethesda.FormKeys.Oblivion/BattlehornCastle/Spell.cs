using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Spell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> DLCBattlehornDragonswordPower2 => Construct(0x147da);
            public static FormLink<ISpellGetter> AbBattlehornArmorerBuff => Construct(0xc512);
            public static FormLink<ISpellGetter> DLCBattlehornDragonswordPower3 => Construct(0x147d8);
            public static FormLink<ISpellGetter> DLCBattlehornDragonswordPower1 => Construct(0x147dd);
        }
    }
}
