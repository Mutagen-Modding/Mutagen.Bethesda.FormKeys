using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Sound
        {
            private static FormLink<ISoundGetter> Construct(uint id) => new FormLink<ISoundGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundGetter> AMBDungeon2DLP08DLCBattlehorn => Construct(0x12915);
        }
    }
}
