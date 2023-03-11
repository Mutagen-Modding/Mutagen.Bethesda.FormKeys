// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class MusicType
    {
        private static FormLink<IMusicTypeGetter> Construct(uint id) => new FormLink<IMusicTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMusicTypeGetter> DLC01MUSDungeonMechanistLairA => Construct(0x100f0);
        public static FormLink<IMusicTypeGetter> MUSzDLC01CombatMechanistMinions => Construct(0x283e);
        public static FormLink<IMusicTypeGetter> MUSzDLC01CombatMechanist => Construct(0x2839);
    }
}