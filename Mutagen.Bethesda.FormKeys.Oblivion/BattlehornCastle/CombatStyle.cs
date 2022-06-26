// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class BattlehornCastle
{
    public static class CombatStyle
    {
        private static FormLink<ICombatStyleGetter> Construct(uint id) => new FormLink<ICombatStyleGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ICombatStyleGetter> DLCBattlehornLichCombatStyle => Construct(0xe823);
    }
}
