using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class SoundOutputModel
        {
            private static FormLink<ISoundOutputModelGetter> Construct(uint id) => new FormLink<ISoundOutputModelGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D4000BARDS => Construct(0xf86);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad09000_verbSHOUTS => Construct(0xec7);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad12000MS06 => Construct(0xe8b);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D8000ThrowVoiceShout => Construct(0xe81);
            public static FormLink<ISoundOutputModelGetter> SOMMono09000_verbSHOUTS => Construct(0x17497);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3DDefault_verb => Construct(0x17465);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRadDragonRoar40960 => Construct(0x17464);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad40960 => Construct(0x172a3);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D10000Dragon => Construct(0x10fddf);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D10000Odahviing => Construct(0x10fdde);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D10000Alduin => Construct(0x10fddd);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D10000Paarthurnax => Construct(0x10fddc);
            public static FormLink<ISoundOutputModelGetter> SOMMono10000SovengardePortal => Construct(0x10f5ec);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D4000 => Construct(0x10f216);
            public static FormLink<ISoundOutputModelGetter> SOMMono01800_verb => Construct(0x10e425);
            public static FormLink<ISoundOutputModelGetter> SOMMono02500DistantFirePillar => Construct(0x10d278);
            public static FormLink<ISoundOutputModelGetter> SOMMono10000_dryDistant => Construct(0x10c300);
            public static FormLink<ISoundOutputModelGetter> SOMMono06000_dry => Construct(0x10c2ed);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad06000_verb => Construct(0x109ac9);
            public static FormLink<ISoundOutputModelGetter> SOMMono10000_verb => Construct(0x104d56);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue2D_verb => Construct(0x103463);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad00900 => Construct(0x100fae);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad04000DA16Distant => Construct(0x100402);
            public static FormLink<ISoundOutputModelGetter> SOMMono06000ElkAggroWarningDistant => Construct(0x1003fc);
            public static FormLink<ISoundOutputModelGetter> SOMMono04000_verb => Construct(0xfe240);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad03000_verb => Construct(0xfd93d);
            public static FormLink<ISoundOutputModelGetter> SOMMono06000_verb => Construct(0xf1b1a);
            public static FormLink<ISoundOutputModelGetter> SOMMono03000_verb => Construct(0xf1b12);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad01400 => Construct(0xf11fd);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad02100_verb => Construct(0xe32bf);
            public static FormLink<ISoundOutputModelGetter> SOMMono02000_verb => Construct(0xe324b);
            public static FormLink<ISoundOutputModelGetter> SOMMono00900_verb => Construct(0xe322c);
            public static FormLink<ISoundOutputModelGetter> SOMStereo_verb => Construct(0xd78b8);
            public static FormLink<ISoundOutputModelGetter> SOMMono01400_verb => Construct(0xd78b4);
            public static FormLink<ISoundOutputModelGetter> SOMMono00400 => Construct(0x99391);
            public static FormLink<ISoundOutputModelGetter> SOMMono03000LargeInnerRadius => Construct(0x960e8);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D8000 => Construct(0x2de0e);
            public static FormLink<ISoundOutputModelGetter> SOMMono01400Player3rd => Construct(0x428b6);
            public static FormLink<ISoundOutputModelGetter> SOMMono08000WolfHowlDistant => Construct(0xe670d);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad04000 => Construct(0xe363a);
            public static FormLink<ISoundOutputModelGetter> SOMMono10000LinearCoastWaves => Construct(0xe360e);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D5000 => Construct(0xd92ef);
            public static FormLink<ISoundOutputModelGetter> SOMMono15000Linear => Construct(0x1a2ff);
            public static FormLink<ISoundOutputModelGetter> SOMUIDefault => Construct(0xb75fb);
            public static FormLink<ISoundOutputModelGetter> SOMMono06000 => Construct(0xb6465);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad10000 => Construct(0xb6464);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad05000 => Construct(0xb6463);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3DDefault => Construct(0xb5184);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue2D => Construct(0xb5183);
            public static FormLink<ISoundOutputModelGetter> SOMMono15000 => Construct(0xb4249);
            public static FormLink<ISoundOutputModelGetter> SOMMono10000 => Construct(0xb4248);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad09000DragonCrashLand => Construct(0xb4247);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad03000 => Construct(0xb4246);
            public static FormLink<ISoundOutputModelGetter> SOMMono01400Player1st => Construct(0xb4058);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad02100 => Construct(0xabf1a);
            public static FormLink<ISoundOutputModelGetter> SOMMono03000 => Construct(0xabef3);
            public static FormLink<ISoundOutputModelGetter> SOMMono04000 => Construct(0xa0e4b);
            public static FormLink<ISoundOutputModelGetter> SOMMono40960 => Construct(0xa0d92);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad05000Linear => Construct(0x9173e);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad10000Linear => Construct(0x8f3e5);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad07000 => Construct(0x8f3e4);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad09000Linear => Construct(0x8f3e3);
            public static FormLink<ISoundOutputModelGetter> SOMMono00900 => Construct(0x6cb4f);
            public static FormLink<ISoundOutputModelGetter> SOMMono01400 => Construct(0x5a28a);
            public static FormLink<ISoundOutputModelGetter> SOMMono08000 => Construct(0x81970);
            public static FormLink<ISoundOutputModelGetter> SOMMono02000 => Construct(0x7f80c);
            public static FormLink<ISoundOutputModelGetter> SOMStereo => Construct(0x7edca);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad01800 => Construct(0x7e5dd);
            public static FormLink<ISoundOutputModelGetter> SOMMono01800 => Construct(0x7e5dc);
        }
    }
}
