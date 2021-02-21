using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> DLCBattlehornDragonswordPower2 => Construct(0x147da);
            public static FormLink<IASpellGetter> AbBattlehornArmorerBuff => Construct(0xc512);
            public static FormLink<IASpellGetter> DLCBattlehornDragonswordPower3 => Construct(0x147d8);
            public static FormLink<IASpellGetter> DLCBattlehornDragonswordPower1 => Construct(0x147dd);
        }
    }
}
