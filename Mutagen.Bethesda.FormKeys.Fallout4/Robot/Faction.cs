// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class Faction
    {
        private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFactionGetter> DLC01REAssaultSC05_FactionSpeakerFaction => Construct(0x109c6);
        public static FormLink<IFactionGetter> DLC01REAssaultSC06_FactionSpeakerFaction => Construct(0x109c5);
        public static FormLink<IFactionGetter> DLC01MechBotFaction => Construct(0x10004);
        public static FormLink<IFactionGetter> DLC01CaravanFaction => Construct(0xfefe);
        public static FormLink<IFactionGetter> DLC01WorkshopRobotFaction => Construct(0xf47a);
        public static FormLink<IFactionGetter> DLC01WorkshopCrimeFaction01 => Construct(0xeb42);
        public static FormLink<IFactionGetter> DLC01RaiderFaction => Construct(0x4385);
        public static FormLink<IFactionGetter> DLC01MechanistFaction => Construct(0x8b5);
    }
}