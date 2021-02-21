using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Projectile
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IProjectileGetter> Construct(uint id) => new FormLink<IProjectileGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IProjectileGetter> DLC2AshBreathProjectile => Construct(0x1e283);
            public static FormLink<IProjectileGetter> DLC2IllusionMayhemProjectile => Construct(0x3d2a0);
            public static FormLink<IProjectileGetter> DLC2BlizzardProjectile => Construct(0x3d299);
            public static FormLink<IProjectileGetter> DLC2FireStormProjectile01 => Construct(0x3d298);
            public static FormLink<IProjectileGetter> DLC2dunFahlbtharzSteamProjectile => Construct(0x3d1c8);
            public static FormLink<IProjectileGetter> DLC2MiraakStaffTentaclesProjectile => Construct(0x3a3d5);
            public static FormLink<IProjectileGetter> DLC2MorasAgonyProjectile => Construct(0x3a3cf);
            public static FormLink<IProjectileGetter> DLC2MorasGraspProjectile => Construct(0x3a297);
            public static FormLink<IProjectileGetter> DLC2MkTentacleProjectile => Construct(0x39e45);
            public static FormLink<IProjectileGetter> miraaktestShockBoltConAim => Construct(0x397ef);
            public static FormLink<IProjectileGetter> DLC2ArrowDwarvenBallistaBoltProjectile => Construct(0x365fd);
            public static FormLink<IProjectileGetter> DLC2BloodskalAreaProjectileVert => Construct(0x33a26);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderOilDecal => Construct(0x3377c);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderShockFriendSpitProjectile => Construct(0x3229f);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderPoisonFriendSpitProjectile => Construct(0x3229c);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFrostFriendSpitProjectile => Construct(0x32299);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireFriendSpitProjectile => Construct(0x32296);
            public static FormLink<IProjectileGetter> DLC2AshspawnProjectile01 => Construct(0x2c3ed);
            public static FormLink<IProjectileGetter> DLC2ArrowDwarvenSoulStealerProjectile => Construct(0x2c01b);
            public static FormLink<IProjectileGetter> DLC2BenthicLurkerProjectile => Construct(0x2b0fc);
            public static FormLink<IProjectileGetter> DLC2dunHighpointAshGuardianProjectile02 => Construct(0x296bf);
            public static FormLink<IProjectileGetter> DLC2CycloneSpellProjectile03 => Construct(0x28eba);
            public static FormLink<IProjectileGetter> DLC2CycloneSpellProjectile02 => Construct(0x28eb9);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireJumpingProjectileENEMY => Construct(0x285d0);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireCloakingProjectileENEMY => Construct(0x285cc);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireBombProjectileENEMY => Construct(0x285ca);
            public static FormLink<IProjectileGetter> DLC2AshShellProjectile => Construct(0x27e35);
            public static FormLink<IProjectileGetter> DLC2BloodskalAreaProjectileHoriz => Construct(0x274f6);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderPackmuleProjectileFriend => Construct(0x274a4);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderOilProjectileFriend => Construct(0x2749c);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderGlowingProjectileFriend => Construct(0x27493);
            public static FormLink<IProjectileGetter> dlc2DBConjureSpectralDragonProjectile => Construct(0x265a2);
            public static FormLink<IProjectileGetter> DLC2ArrowNordicProjectile => Construct(0x2623a);
            public static FormLink<IProjectileGetter> DLC2ArrowStalhrimProjectile => Construct(0x26238);
            public static FormLink<IProjectileGetter> DLC2HMDaedraMouthProjectile => Construct(0x24fc4);
            public static FormLink<IProjectileGetter> DLC2HMDaedraBallProjectile01 => Construct(0x24fbb);
            public static FormLink<IProjectileGetter> DLC2BendWillProjectile03 => Construct(0x2174f);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderShockSpitProjectile => Construct(0x20970);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderShockJumpingProjectileFriend => Construct(0x2096f);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderShockCloakingProjectileFriend => Construct(0x2096e);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderShockBombProjectile => Construct(0x2096d);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFrostSpitProjectile => Construct(0x206d0);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFrostJumpingProjectileFriend => Construct(0x206cf);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFrostCloakingProjectileFriend => Construct(0x206ce);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFrostBombProjectile => Construct(0x206cd);
            public static FormLink<IProjectileGetter> DLC2BendWillProjectile01 => Construct(0x1f139);
            public static FormLink<IProjectileGetter> dlc2BBWrithingWallProjectile => Construct(0x1ed9f);
            public static FormLink<IProjectileGetter> DLC2RunePoisonProjectile => Construct(0x1d74d);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderPoisonCloakingProjectileFriend => Construct(0x1caaf);
            public static FormLink<IProjectileGetter> DLC2BloodskalProjectile01 => Construct(0x1aeb0);
            public static FormLink<IProjectileGetter> DLC2LurkerGooProjectile01 => Construct(0x1ae99);
            public static FormLink<IProjectileGetter> DLC2AshGuardianProjectile01 => Construct(0x1aabe);
            public static FormLink<IProjectileGetter> DLC2CycloneSpellProjectile => Construct(0x1aaac);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireBombProjectile => Construct(0x19533);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireCloakingProjectileFriend => Construct(0x1952a);
            public static FormLink<IProjectileGetter> DLC2RuneFrenzyProjectile => Construct(0x177b9);
            public static FormLink<IProjectileGetter> DLC2RuneAshProjectile => Construct(0x177b0);
            public static FormLink<IProjectileGetter> DLC2AshGuardianProjectile02 => Construct(0x17783);
            public static FormLink<IProjectileGetter> DLC2ArrowRieklingSpearProjectile => Construct(0x17721);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderPoisonBombProjectile => Construct(0x1707a);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderZombieProjectileFriend => Construct(0x16e18);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderAlbinoProjectileFriend => Construct(0x145cb);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderAlbinoSpitProjectile => Construct(0x145ca);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireJumpingProjectileFriend => Construct(0x14493);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderPoisonJumpingProjectileFriend => Construct(0x14489);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderFireSpitProjectile => Construct(0x14486);
            public static FormLink<IProjectileGetter> DLC2ExpSpiderPoisonSpitProjectile => Construct(0x14455);
        }
    }
}
