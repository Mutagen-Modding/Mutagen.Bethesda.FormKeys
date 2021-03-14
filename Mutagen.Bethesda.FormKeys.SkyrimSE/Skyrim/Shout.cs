using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Shout
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IShoutGetter> Construct(uint id) => new FormLink<IShoutGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IShoutGetter> L_DragonFrostIceStormShout => Construct(0x10fe24);
            public static FormLink<IShoutGetter> L_DragonFrostBreathShout => Construct(0x10fe23);
            public static FormLink<IShoutGetter> L_DragonFireBallShout => Construct(0x10fe22);
            public static FormLink<IShoutGetter> L_DragonFireBreathShout => Construct(0x10fe21);
            public static FormLink<IShoutGetter> LShoutDragonFrostBreath => Construct(0x10fe1b);
            public static FormLink<IShoutGetter> GreybeardElementalFuryShout => Construct(0x10f734);
            public static FormLink<IShoutGetter> GreybeardDismay => Construct(0x10f733);
            public static FormLink<IShoutGetter> GreybeardUnrelentingForceShout => Construct(0x10f732);
            public static FormLink<IShoutGetter> GreybeardWhirlwindSprintShout => Construct(0x10f731);
            public static FormLink<IShoutGetter> GreybeardIceFormShout => Construct(0x10f730);
            public static FormLink<IShoutGetter> GreybeardFrostBreathShout => Construct(0x10f72f);
            public static FormLink<IShoutGetter> GreybeardFireBreathShout => Construct(0x10f72e);
            public static FormLink<IShoutGetter> GreybeardDisarmShout => Construct(0x10f72d);
            public static FormLink<IShoutGetter> crCenturionBreathWeaponMal => Construct(0x10e755);
            public static FormLink<IShoutGetter> DragonFrostIceStormShout05 => Construct(0x10c4e2);
            public static FormLink<IShoutGetter> DragonFrostBreathShout05 => Construct(0x10c4e1);
            public static FormLink<IShoutGetter> DragonFireBreathShout05 => Construct(0x10c4e0);
            public static FormLink<IShoutGetter> DragonFireBallShout05 => Construct(0x10c4df);
            public static FormLink<IShoutGetter> MQ101DragonUnrelentingForceShout => Construct(0x107580);
            public static FormLink<IShoutGetter> MQ206AlduinFirestormShout => Construct(0x101cec);
            public static FormLink<IShoutGetter> MQAlduinResurrectShout => Construct(0xff8d8);
            public static FormLink<IShoutGetter> DragonFireBallShout03 => Construct(0xfeaa0);
            public static FormLink<IShoutGetter> DragonFireBreathShout03 => Construct(0xfea9d);
            public static FormLink<IShoutGetter> DragonFrostIceStormShout04 => Construct(0xf810b);
            public static FormLink<IShoutGetter> DragonFrostBreathShout04 => Construct(0xf810a);
            public static FormLink<IShoutGetter> DragonFireBreathShout04 => Construct(0xf8109);
            public static FormLink<IShoutGetter> DragonFireBallShout04 => Construct(0xf8108);
            public static FormLink<IShoutGetter> DragonFrostIceStormShout03 => Construct(0xf8101);
            public static FormLink<IShoutGetter> DragonFrostBreathShout03 => Construct(0xf8100);
            public static FormLink<IShoutGetter> DragonFrostBreathShout01 => Construct(0xf80fb);
            public static FormLink<IShoutGetter> DragonFrostIceStormShout01 => Construct(0xf80f9);
            public static FormLink<IShoutGetter> DragonFireBreathShout02 => Construct(0xf80f8);
            public static FormLink<IShoutGetter> DragonFireBallShout02 => Construct(0xf80f7);
            public static FormLink<IShoutGetter> DragonFrostIceStormShout02 => Construct(0xdd607);
            public static FormLink<IShoutGetter> dunCGDragonStormCallShout => Construct(0xb2387);
            public static FormLink<IShoutGetter> UnrelentingForceShoutDraugr => Construct(0x9de93);
            public static FormLink<IShoutGetter> AlduinFirestormShout => Construct(0x4c40b);
            public static FormLink<IShoutGetter> DragonUnrelentingForceShout => Construct(0x16cf0);
            public static FormLink<IShoutGetter> DragonDisarmShout => Construct(0x16c40);
            public static FormLink<IShoutGetter> MQ105WhirlwindSprintShout => Construct(0x7a4c8);
            public static FormLink<IShoutGetter> HowlWerewolfCallOfTheWild => Construct(0xe5f68);
            public static FormLink<IShoutGetter> dunCGAlduinFireBreathShout => Construct(0xe4908);
            public static FormLink<IShoutGetter> WoodElfBeastTongue => Construct(0xe40d1);
            public static FormLink<IShoutGetter> ImperialVoiceOfTheEmperor => Construct(0xe40cb);
            public static FormLink<IShoutGetter> NordBattleCry => Construct(0xe40c4);
            public static FormLink<IShoutGetter> HowlWerewolfSummonWolves => Construct(0xcf79b);
            public static FormLink<IShoutGetter> HowlWerewolfFear => Construct(0xcf790);
            public static FormLink<IShoutGetter> HowlWerewolfDetectLife => Construct(0xce218);
            public static FormLink<IShoutGetter> crCenturionBreathWeapon => Construct(0xa82bc);
            public static FormLink<IShoutGetter> DisarmShout => Construct(0x70981);
            public static FormLink<IShoutGetter> IceFormShout => Construct(0x70980);
            public static FormLink<IShoutGetter> ThrowVoiceShout => Construct(0x7097f);
            public static FormLink<IShoutGetter> KynesPeaceShout => Construct(0x7097e);
            public static FormLink<IShoutGetter> StormCallShout => Construct(0x7097d);
            public static FormLink<IShoutGetter> MarkedforDeathShout => Construct(0x7097c);
            public static FormLink<IShoutGetter> AuraWhisperShout => Construct(0x7097b);
            public static FormLink<IShoutGetter> Dismay => Construct(0x2395a);
            public static FormLink<IShoutGetter> animalAllegianceShout => Construct(0x5fc77);
            public static FormLink<IShoutGetter> FrostBreathShout => Construct(0x5d16b);
            public static FormLink<IShoutGetter> DA13AfflictedBreathShout => Construct(0x59327);
            public static FormLink<IShoutGetter> DragonFrostBreathShout02 => Construct(0x549b2);
            public static FormLink<IShoutGetter> MQDragonIceSpikeVolleyShout => Construct(0x549b1);
            public static FormLink<IShoutGetter> DragonFireBallShout01 => Construct(0x4dba5);
            public static FormLink<IShoutGetter> CallofValorShout => Construct(0x5196a);
            public static FormLink<IShoutGetter> SlowTimeShout => Construct(0x48ac9);
            public static FormLink<IShoutGetter> CallDragonShout => Construct(0x46b8c);
            public static FormLink<IShoutGetter> DragonrendShout => Construct(0x44250);
            public static FormLink<IShoutGetter> FireBreathShout => Construct(0x3f9ea);
            public static FormLink<IShoutGetter> ClearSkiesShout => Construct(0x3cd34);
            public static FormLink<IShoutGetter> ElementalFuryShout => Construct(0x32921);
            public static FormLink<IShoutGetter> BecomeEtherealShout => Construct(0x32920);
            public static FormLink<IShoutGetter> WhirlwindSprintShout => Construct(0x2f7ba);
            public static FormLink<IShoutGetter> MQ105PhantomFormShout => Construct(0x2f2df);
            public static FormLink<IShoutGetter> DragonFireBreathShout01 => Construct(0x252c0);
            public static FormLink<IShoutGetter> UnrelentingForceShout => Construct(0x13e07);
        }
    }
}
