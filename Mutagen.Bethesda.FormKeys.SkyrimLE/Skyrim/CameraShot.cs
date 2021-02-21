using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class CameraShot
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<ICameraShotGetter> Construct(uint id) => new FormLink<ICameraShotGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICameraShotGetter> DS04aDragonKillCamA01L => Construct(0x10fdad);
            public static FormLink<ICameraShotGetter> DS03aDragonKillCamA01R => Construct(0x10fdac);
            public static FormLink<ICameraShotGetter> S08bLSideBackCam02 => Construct(0x10f8af);
            public static FormLink<ICameraShotGetter> S08aSLSideBackCam02 => Construct(0x10f8ae);
            public static FormLink<ICameraShotGetter> S08aLSideBackCam02 => Construct(0x10f8ad);
            public static FormLink<ICameraShotGetter> S07bRSideCam02 => Construct(0x10f8aa);
            public static FormLink<ICameraShotGetter> S07aSRSideBackCam01 => Construct(0x10f8a9);
            public static FormLink<ICameraShotGetter> S07aRSideBackCam01 => Construct(0x10f8a8);
            public static FormLink<ICameraShotGetter> DS02dDragonKillCamD01L => Construct(0x10f197);
            public static FormLink<ICameraShotGetter> DS02cDragonKillCamC01L => Construct(0x10f196);
            public static FormLink<ICameraShotGetter> DS02bDragonKillCamB01L => Construct(0x10f195);
            public static FormLink<ICameraShotGetter> DS02aDragonKillCamA01L => Construct(0x10f194);
            public static FormLink<ICameraShotGetter> DS01dDragonKillCamD01R => Construct(0x10f193);
            public static FormLink<ICameraShotGetter> DS01dRightSideBackCam01 => Construct(0x10f192);
            public static FormLink<ICameraShotGetter> DS01cDragonKillCamC01R => Construct(0x10f191);
            public static FormLink<ICameraShotGetter> DS01d_RodeoStab => Construct(0x10e751);
            public static FormLink<ICameraShotGetter> DS01cPlayerActionCam01R => Construct(0x10e74e);
            public static FormLink<ICameraShotGetter> DS01bDragonKillCamB01R => Construct(0x10e74d);
            public static FormLink<ICameraShotGetter> DS01aDragonKillCamA01R => Construct(0x10e74c);
            public static FormLink<ICameraShotGetter> KillCam_RightSideFarA_SlowEnd => Construct(0x10e74b);
            public static FormLink<ICameraShotGetter> KillCam_RightSideCloseUpA_SlowEnd => Construct(0x10e74a);
            public static FormLink<ICameraShotGetter> KillCam_LeftSideFarA_SlowEnd => Construct(0x10e749);
            public static FormLink<ICameraShotGetter> KillCam_LeftSideCloseUpA_SlowEnd => Construct(0x10e748);
            public static FormLink<ICameraShotGetter> KillCam_FrontSideFarA_SlowEnd => Construct(0x10e747);
            public static FormLink<ICameraShotGetter> KillCam_FrontSideCloseUpA_SlowEnd => Construct(0x10e746);
            public static FormLink<ICameraShotGetter> S06aSPlayerActionCam02L => Construct(0x10e745);
            public static FormLink<ICameraShotGetter> S05aSPlayerActionCam02R => Construct(0x10e744);
            public static FormLink<ICameraShotGetter> S02aSPlayerActionCam01L => Construct(0x10e743);
            public static FormLink<ICameraShotGetter> S01aSPlayerActionCam01R => Construct(0x10e742);
            public static FormLink<ICameraShotGetter> CamTESTSDistanceCam => Construct(0x10d65d);
            public static FormLink<ICameraShotGetter> S04aSPlayerFaceCamL => Construct(0x10d2ac);
            public static FormLink<ICameraShotGetter> S03aSPlayerFaceCamR => Construct(0x10d2ab);
            public static FormLink<ICameraShotGetter> S06bLSideCam02 => Construct(0x10d2a9);
            public static FormLink<ICameraShotGetter> S06aPlayerActionCam02L => Construct(0x10d2a8);
            public static FormLink<ICameraShotGetter> S05bRSideCam02 => Construct(0x10d2a6);
            public static FormLink<ICameraShotGetter> S05aPlayerActionCam02R => Construct(0x10d2a5);
            public static FormLink<ICameraShotGetter> S04bLSideBackCam01 => Construct(0x10c75c);
            public static FormLink<ICameraShotGetter> S04aPlayerFaceCamL => Construct(0x10c75b);
            public static FormLink<ICameraShotGetter> S03bRSideBackCam01 => Construct(0x10c759);
            public static FormLink<ICameraShotGetter> S03aPlayerFaceCamR => Construct(0x10c758);
            public static FormLink<ICameraShotGetter> S02bLSideCam01 => Construct(0x10c756);
            public static FormLink<ICameraShotGetter> S02aPlayerActionCam01L => Construct(0x10c755);
            public static FormLink<ICameraShotGetter> S01bRSideCam01 => Construct(0x10ab48);
            public static FormLink<ICameraShotGetter> S01aPlayerActionCam01R => Construct(0x10ab46);
            public static FormLink<ICameraShotGetter> PlayerActionCam01R => Construct(0x10ab44);
            public static FormLink<ICameraShotGetter> _1stPCam => Construct(0x106367);
            public static FormLink<ICameraShotGetter> KillCam_TopSideCloseUpA => Construct(0x105826);
            public static FormLink<ICameraShotGetter> KillCamDragon_RodeoStab => Construct(0xd0798);
            public static FormLink<ICameraShotGetter> KillCam_RightSideFarA_Slow => Construct(0xb7029);
            public static FormLink<ICameraShotGetter> KillCam_RightSideFarA => Construct(0xb7025);
            public static FormLink<ICameraShotGetter> KillCam_LeftSideFarA_Slow => Construct(0xb7024);
            public static FormLink<ICameraShotGetter> KillCam_LeftSideFarA => Construct(0xb7023);
            public static FormLink<ICameraShotGetter> KillCam_FrontSideFarA_Slow => Construct(0xb7022);
            public static FormLink<ICameraShotGetter> KillCam_FrontSideFarA => Construct(0xb7020);
            public static FormLink<ICameraShotGetter> KillCam_RightSideCloseUpA_longer => Construct(0xa67fb);
            public static FormLink<ICameraShotGetter> KillCam_RightSideCloseUpA_Hit => Construct(0xa67fa);
            public static FormLink<ICameraShotGetter> KillCam_FrontSideCloseUpA_Slow => Construct(0x9bb87);
            public static FormLink<ICameraShotGetter> KillCam_LeftSideCloseUpA_Slow => Construct(0x9bb86);
            public static FormLink<ICameraShotGetter> KillCamBear_LeftSide => Construct(0x40958);
            public static FormLink<ICameraShotGetter> KillCamGiant_LeftSide => Construct(0x8a90d);
            public static FormLink<ICameraShotGetter> KillCam_RightSideCloseUpA_Slow => Construct(0xe773a);
            public static FormLink<ICameraShotGetter> KillCam_FrontSideCloseUpA => Construct(0xe7736);
            public static FormLink<ICameraShotGetter> KillCam_LeftSideCloseUpA => Construct(0xe7735);
            public static FormLink<ICameraShotGetter> KillCam_RightSideCloseUpA => Construct(0xd168e);
            public static FormLink<ICameraShotGetter> ProjectileBaseCamLeftLong => Construct(0x54222);
            public static FormLink<ICameraShotGetter> BaseCamLeftSlow => Construct(0x54221);
            public static FormLink<ICameraShotGetter> BaseCamLeftLong => Construct(0x54220);
            public static FormLink<ICameraShotGetter> BaseCamLeftFinish => Construct(0x5421f);
            public static FormLink<ICameraShotGetter> BaseCamLeft => Construct(0x5421e);
            public static FormLink<ICameraShotGetter> ArrowCloseUp => Construct(0x537eb);
            public static FormLink<ICameraShotGetter> ProjectileBaseCamLong => Construct(0x3858e);
            public static FormLink<ICameraShotGetter> LSideCam01Slow => Construct(0x35309);
            public static FormLink<ICameraShotGetter> LSideCam01Fast => Construct(0x35308);
            public static FormLink<ICameraShotGetter> LSideCam01 => Construct(0x35307);
            public static FormLink<ICameraShotGetter> RSideCam01Fast => Construct(0x35306);
            public static FormLink<ICameraShotGetter> RSideCam01Slow => Construct(0x35305);
            public static FormLink<ICameraShotGetter> RSideCam01 => Construct(0x35302);
            public static FormLink<ICameraShotGetter> TestProjectileTracking => Construct(0x34cf2);
            public static FormLink<ICameraShotGetter> BaseCamLong => Construct(0x34cf1);
            public static FormLink<ICameraShotGetter> BaseCamFinish => Construct(0x34a9d);
            public static FormLink<ICameraShotGetter> BaseCamSlow => Construct(0x34a9c);
            public static FormLink<ICameraShotGetter> BaseCam => Construct(0x34a9b);
            public static FormLink<ICameraShotGetter> TestAbove => Construct(0x2c3d1);
            public static FormLink<ICameraShotGetter> PlayerDeathBack01 => Construct(0x142e6);
            public static FormLink<ICameraShotGetter> PlayerDeathAbove01 => Construct(0x142e5);
            public static FormLink<ICameraShotGetter> PlayerDeathDefault01 => Construct(0x142e4);
        }
    }
}
