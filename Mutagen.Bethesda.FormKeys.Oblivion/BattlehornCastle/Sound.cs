// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class BattlehornCastle
{
    public static partial class Sound
    {
        private static FormLink<ISoundGetter> Construct(uint id) => new FormLink<ISoundGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISoundGetter> AMBDungeon2DLP08DLCBattlehorn => Construct(0x12915);
    }
}
