using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Hazard
        {
            private static FormLink<IHazardGetter> Construct(uint id) => new FormLink<IHazardGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IHazardGetter> TrapFirePlateFXHaz06 => Construct(0x109ce5);
            public static FormLink<IHazardGetter> TrapFirePlateFXHaz05 => Construct(0x109ce4);
            public static FormLink<IHazardGetter> TrapFirePlateFXHaz04 => Construct(0x109ce3);
            public static FormLink<IHazardGetter> TrapFirePlateFXHaz03 => Construct(0x109ce2);
            public static FormLink<IHazardGetter> TrapFirePlateFXHaz02 => Construct(0x109ce1);
            public static FormLink<IHazardGetter> DA13PustuleGasCloud => Construct(0x106380);
            public static FormLink<IHazardGetter> MQClearSkyFogHazard => Construct(0x106375);
            public static FormLink<IHazardGetter> BlizzardThroatOfTheWorldHazard => Construct(0x105374);
            public static FormLink<IHazardGetter> FireLgPlacedHazardInvisible => Construct(0x10387e);
            public static FormLink<IHazardGetter> MS06PotemaShockBarrierHazardDrop => Construct(0x1034c1);
            public static FormLink<IHazardGetter> MS06PotemaShockBarrierHazard => Construct(0x1034bd);
            public static FormLink<IHazardGetter> GuardianCircleTurnHazard => Construct(0xfead3);
            public static FormLink<IHazardGetter> AtronachFlamelHazard => Construct(0xf71d9);
            public static FormLink<IHazardGetter> FireBarrierHazardDropCatapult => Construct(0xee9f5);
            public static FormLink<IHazardGetter> GuardianCircleHazard => Construct(0xe0cd3);
            public static FormLink<IHazardGetter> FXHavokRockHazard => Construct(0xd07bc);
            public static FormLink<IHazardGetter> TGControlLocationFXHazard => Construct(0xce275);
            public static FormLink<IHazardGetter> ClairvoyanceHazard => Construct(0x2113e);
            public static FormLink<IHazardGetter> CallStormHazardAlduinDeath => Construct(0x154bc);
            public static FormLink<IHazardGetter> CallStormHazard01 => Construct(0xe4cb3);
            public static FormLink<IHazardGetter> SummonFXLightHazard => Construct(0x95457);
            public static FormLink<IHazardGetter> ShockBarrierHazardDrop => Construct(0x592d1);
            public static FormLink<IHazardGetter> ShockBarrierHazard => Construct(0x591a5);
            public static FormLink<IHazardGetter> FrostBarrierHazard01Drop => Construct(0x590fc);
            public static FormLink<IHazardGetter> FireBarrierHazardDrop => Construct(0x590fb);
            public static FormLink<IHazardGetter> FrostBlizzardSpellHazard03 => Construct(0xb7a04);
            public static FormLink<IHazardGetter> FrostBlizzardSpellHazard02 => Construct(0xb7a03);
            public static FormLink<IHazardGetter> FrostBlizzardSpellHazard01 => Construct(0xb79f9);
            public static FormLink<IHazardGetter> CircleVitalityHazard => Construct(0xb62ea);
            public static FormLink<IHazardGetter> FrostBarrierHazard01 => Construct(0x8f3f4);
            public static FormLink<IHazardGetter> FireBarrierHazard => Construct(0x8f3ee);
            public static FormLink<IHazardGetter> TrapOilLampHazard => Construct(0x80e1f);
            public static FormLink<IHazardGetter> TrapOilHazard01 => Construct(0x303ff);
            public static FormLink<IHazardGetter> TrapFirePlateFXHaz01 => Construct(0x5a1a3);
            public static FormLink<IHazardGetter> FireLgPlacedHazard => Construct(0x57a8c);
            public static FormLink<IHazardGetter> CircleOfProtectionHazard => Construct(0x4e80c);
            public static FormLink<IHazardGetter> TestLightHazard => Construct(0x3fa51);
            public static FormLink<IHazardGetter> FireLgShortHazard => Construct(0x3e076);
            public static FormLink<IHazardGetter> FireLgLongHazard => Construct(0x3e075);
            public static FormLink<IHazardGetter> FireSmLongHazard => Construct(0x3e074);
            public static FormLink<IHazardGetter> FireSmShortHazard => Construct(0x3e073);
            public static FormLink<IHazardGetter> FireSpellHazard => Construct(0x153bf);
            public static FormLink<IHazardGetter> IceHazard01 => Construct(0x130f5);
            public static FormLink<IHazardGetter> FireDragonHazard => Construct(0x3172a);
        }
    }
}
