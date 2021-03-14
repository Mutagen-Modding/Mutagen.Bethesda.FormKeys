using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Shout
        {
            private static FormLink<IShoutGetter> Construct(uint id) => new FormLink<IShoutGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IShoutGetter> DLC1DragonUndeadSummonShout => Construct(0x1a165);
            public static FormLink<IShoutGetter> DLC1DragonDrainVitalityShout02 => Construct(0x18244);
            public static FormLink<IShoutGetter> DLC1DragonDrainVitalityShout03 => Construct(0x181b8);
            public static FormLink<IShoutGetter> DLC1DragonDrainVitalityShout04 => Construct(0x181b7);
            public static FormLink<IShoutGetter> DLC1DragonDrainVitalityShout05 => Construct(0x181b6);
            public static FormLink<IShoutGetter> DLC1LD_ForgemasterFireballShout03 => Construct(0x15c4d);
            public static FormLink<IShoutGetter> DLC1LD_ForgemasterFireBreathShout03 => Construct(0x15c4c);
            public static FormLink<IShoutGetter> DLC1LD_ForgemasterFireballShout02 => Construct(0x15c4b);
            public static FormLink<IShoutGetter> DLC1LD_ForgemasterFireBreathShout02 => Construct(0x15c4a);
            public static FormLink<IShoutGetter> DLC1LD_ForgemasterFlameCloakShout => Construct(0x15c43);
            public static FormLink<IShoutGetter> DLC1LD_ForgemasterFireBreathShout01 => Construct(0x15c3e);
            public static FormLink<IShoutGetter> DLC1LD_ForgemasterFireballShout01 => Construct(0x15c39);
            public static FormLink<IShoutGetter> DLC1DragonFrostBreathShout07 => Construct(0xc5fb);
            public static FormLink<IShoutGetter> DLC1DragonFireBreathShout07 => Construct(0xc5fa);
            public static FormLink<IShoutGetter> DLC1DragonDrainVitalityShout07 => Construct(0xc5f9);
            public static FormLink<IShoutGetter> DLC1VQ05DurnehviirShout => Construct(0xbfed);
            public static FormLink<IShoutGetter> DLC1DrainVitalityShout => Construct(0x8a62);
            public static FormLink<IShoutGetter> DLC1DragonDrainVitalityShout06 => Construct(0x8442);
            public static FormLink<IShoutGetter> DLC1DragonFrostIceStormShout06 => Construct(0x843d);
            public static FormLink<IShoutGetter> DLC1DragonFrostBreathShout06 => Construct(0x843c);
            public static FormLink<IShoutGetter> DLC1DragonFireBreathShout06 => Construct(0x843b);
            public static FormLink<IShoutGetter> DLC1DragonFireBallShout06 => Construct(0x843a);
            public static FormLink<IShoutGetter> DLC1SoulTearShout => Construct(0x7cb6);
            public static FormLink<IShoutGetter> DLC1SummonDragonShout => Construct(0x30d2);
        }
    }
}
