// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static class MusicType
    {
        private static FormLink<IMusicTypeGetter> Construct(uint id) => new FormLink<IMusicTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMusicTypeGetter> DLC04MUSStingerGalacticZoneRollercoasterA => Construct(0x56dbe);
        public static FormLink<IMusicTypeGetter> DLC04MUSExploreInnerNukaTown => Construct(0x3b51c);
        public static FormLink<IMusicTypeGetter> DLC04MUSExploreInnerKiddie => Construct(0x3b51b);
        public static FormLink<IMusicTypeGetter> DLC04MUSzCombatRobcoArena => Construct(0x397e7);
        public static FormLink<IMusicTypeGetter> DLC04MUSExploreInnerSafari => Construct(0x378b6);
        public static FormLink<IMusicTypeGetter> DLC04MUSExploreInnerGalactic => Construct(0x32969);
        public static FormLink<IMusicTypeGetter> DLC04MUSExploreInnerWestern => Construct(0x30ee5);
        public static FormLink<IMusicTypeGetter> DLC04MUSExploreInner => Construct(0x30ee4);
        public static FormLink<IMusicTypeGetter> DLC04MUSExploreOuter => Construct(0x2aef2);
        public static FormLink<IMusicTypeGetter> DLC04MUSzCombatArena => Construct(0xa54c);
    }
}