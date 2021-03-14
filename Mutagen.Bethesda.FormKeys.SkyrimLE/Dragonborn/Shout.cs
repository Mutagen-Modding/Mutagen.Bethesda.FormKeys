using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Shout
        {
            private static FormLink<IShoutGetter> Construct(uint id) => new FormLink<IShoutGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IShoutGetter> dlc2MKMiraakMaskShoutShout => Construct(0x39d28);
            public static FormLink<IShoutGetter> DLC2MiraakDragonAspectShout => Construct(0x38b0f);
            public static FormLink<IShoutGetter> DLC2MiraakUnrelentingForceShout => Construct(0x38b0e);
            public static FormLink<IShoutGetter> DLC2MiraakFrostBreathShout => Construct(0x38b0d);
            public static FormLink<IShoutGetter> DLC2MiraakFireBreathShout => Construct(0x38b0c);
            public static FormLink<IShoutGetter> DLC2MiraakElementalFuryShout => Construct(0x38b0b);
            public static FormLink<IShoutGetter> DLC2MiraakFakeKillShout => Construct(0x382f9);
            public static FormLink<IShoutGetter> DLC2DragonFireBallShout06 => Construct(0x36132);
            public static FormLink<IShoutGetter> DLC2DragonFireBreathShout06 => Construct(0x36131);
            public static FormLink<IShoutGetter> DLC2DragonFrostIceStormShout06 => Construct(0x3612c);
            public static FormLink<IShoutGetter> DLC2DragonFrostBreathShout06 => Construct(0x3612b);
            public static FormLink<IShoutGetter> DLC2MiraakWhirlwindSprintShout => Construct(0x3547b);
            public static FormLink<IShoutGetter> DLC2BattleFuryShout => Construct(0x2ad09);
            public static FormLink<IShoutGetter> DLC2MiraakBecomeEtherealShout => Construct(0x23f7a);
            public static FormLink<IShoutGetter> DLC2MiraakCycloneShout => Construct(0x23f79);
            public static FormLink<IShoutGetter> DLC2CycloneShout => Construct(0x200c0);
            public static FormLink<IShoutGetter> DLC2DragonAspectShout => Construct(0x1df92);
            public static FormLink<IShoutGetter> DLC2BendWillShout => Construct(0x179d8);
        }
    }
}