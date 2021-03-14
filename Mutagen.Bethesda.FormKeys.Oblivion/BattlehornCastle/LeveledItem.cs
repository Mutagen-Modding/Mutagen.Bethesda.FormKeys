using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class LeveledItem
        {
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> DLCBattlehornDragonswordLL => Construct(0x12e14);
            public static FormLink<ILeveledItemGetter> DLCBattlehornShieldRewardLeveled => Construct(0x11f2d);
        }
    }
}
