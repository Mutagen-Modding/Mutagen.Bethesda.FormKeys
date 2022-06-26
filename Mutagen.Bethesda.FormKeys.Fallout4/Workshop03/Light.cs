// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static class Light
    {
        private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILightGetter> DLC06KlaxonLightGlowNS => Construct(0x2569);
        public static FormLink<ILightGetter> DLC06LightSuperReactor => Construct(0x24fb);
        public static FormLink<ILightGetter> DLC06CaveLightNSNonSpec => Construct(0x1e11);
        public static FormLink<ILightGetter> DLC06CaveLightNS => Construct(0x1e10);
        public static FormLink<ILightGetter> DLC06UraniumLightPulseDim => Construct(0x144b);
        public static FormLink<ILightGetter> DLC06VaultCageBulbRed => Construct(0x12be);
        public static FormLink<ILightGetter> DLC06VaultBulbRedNS => Construct(0x12bd);
        public static FormLink<ILightGetter> DLC06DefaultLightCoolFLNSFlicker => Construct(0x12bc);
        public static FormLink<ILightGetter> DLC06VltLightFluorResHallLightOff => Construct(0x5e41);
        public static FormLink<ILightGetter> DLC06UraniumLightPulse => Construct(0x4d4f);
        public static FormLink<ILightGetter> DLC06UraniumLight => Construct(0x4d4e);
        public static FormLink<ILightGetter> DLC06LightWhite01Hemi => Construct(0x4d4d);
        public static FormLink<ILightGetter> DLC06VltLightFluorResWallLight02 => Construct(0x4351);
        public static FormLink<ILightGetter> DLC06VltLightFluorResWallLight => Construct(0x4350);
        public static FormLink<ILightGetter> DLC06IndCatLightNSHemi => Construct(0x434e);
        public static FormLink<ILightGetter> DLC06IndCatLightNSGobo => Construct(0x434d);
        public static FormLink<ILightGetter> DLC06VltLightFluorResHallLight => Construct(0x42fb);
        public static FormLink<ILightGetter> DLC06VltLightFluorResHallHalfLight => Construct(0x42fa);
        public static FormLink<ILightGetter> DLC06VltLightFluorBox02 => Construct(0x42f9);
        public static FormLink<ILightGetter> DLC06VltLightFluorBox => Construct(0x42f8);
        public static FormLink<ILightGetter> DLC06VltLightCeiling => Construct(0x42f7);
        public static FormLink<ILightGetter> DLC06VltLightCageWallMountedWhite => Construct(0x42f6);
        public static FormLink<ILightGetter> DLC06VltLightCageWallMountedRed => Construct(0x42f5);
        public static FormLink<ILightGetter> DLC06VltLightCageWallMountedGreen => Construct(0x42f4);
    }
}
