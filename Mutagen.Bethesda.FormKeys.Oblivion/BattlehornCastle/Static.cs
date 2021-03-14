using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Static
        {
            private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IStaticGetter> BattlehornTrophyMountainLion => Construct(0x4861);
            public static FormLink<IStaticGetter> BattlehornTrophyOgre => Construct(0x4862);
            public static FormLink<IStaticGetter> BattlehornTrophyTroll => Construct(0x4863);
            public static FormLink<IStaticGetter> BattlehornTrophyWolf => Construct(0x4864);
            public static FormLink<IStaticGetter> BattlehornCastleStackBalconyMid02b => Construct(0x7281);
            public static FormLink<IStaticGetter> BattlehornTrophyBlackBear => Construct(0x4d98);
            public static FormLink<IStaticGetter> BattlehornTrophyBear => Construct(0x485d);
            public static FormLink<IStaticGetter> FightersKeepCastle => Construct(0x8159);
            public static FormLink<IStaticGetter> FightersKeepCastleExterior => Construct(0x815a);
            public static FormLink<IStaticGetter> BattlehornTrophyClannfear => Construct(0x485e);
            public static FormLink<IStaticGetter> BattleHornBanner => Construct(0x97d5);
            public static FormLink<IStaticGetter> BattlehornTrophyDaedroth => Construct(0x485f);
            public static FormLink<IStaticGetter> TrophyBaseCircle => Construct(0xa6b6);
            public static FormLink<IStaticGetter> TrophyBaseOval => Construct(0xa6b8);
            public static FormLink<IStaticGetter> BattlehornTrophyMinotaur => Construct(0x4860);
        }
    }
}
