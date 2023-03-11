// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static class Explosion
    {
        private static FormLink<IExplosionGetter> Construct(uint id) => new FormLink<IExplosionGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IExplosionGetter> DLC03_HermitAmbushDebrisFX => Construct(0x5444c);
        public static FormLink<IExplosionGetter> DLC03_VimCaptainsBlendExpl => Construct(0x541fd);
        public static FormLink<IExplosionGetter> DLC03_ThrowingBearTrapExplosionBleeding => Construct(0x540f9);
        public static FormLink<IExplosionGetter> DLC03_ThrowingCaltropExplosionPoisoned => Construct(0x540ef);
        public static FormLink<IExplosionGetter> DLC03_ThrowingBearTrapExplosion => Construct(0x54074);
        public static FormLink<IExplosionGetter> DLC03_ThrowingCaltropExplosion => Construct(0x54070);
        public static FormLink<IExplosionGetter> DLC03FogCrawlerDeathExplosion => Construct(0x53dfe);
        public static FormLink<IExplosionGetter> DLC03FogCrawlerAOESilent => Construct(0x4f3df);
        public static FormLink<IExplosionGetter> DLC03HermitCrabAOESilent => Construct(0x4f3de);
        public static FormLink<IExplosionGetter> DLC03HermitCrabAOEExplosion => Construct(0x4f26c);
        public static FormLink<IExplosionGetter> DLC03FogCrawlerAOEExplosion => Construct(0x4ebb5);
        public static FormLink<IExplosionGetter> DLC03ExplosionPaintballProjectileWhite => Construct(0x4c050);
        public static FormLink<IExplosionGetter> DLC03ExplosionPaintballProjectileRed => Construct(0x4c04f);
        public static FormLink<IExplosionGetter> DLC03ExplosionPaintballProjectileOrange => Construct(0x4c04e);
        public static FormLink<IExplosionGetter> DLC03ExplosionPaintballProjectileYellow => Construct(0x4c047);
        public static FormLink<IExplosionGetter> DLC03ExplosionPaintballProjectileGreen => Construct(0x4c046);
        public static FormLink<IExplosionGetter> DLC03ExplosionPaintballProjectileBlue => Construct(0x4c045);
        public static FormLink<IExplosionGetter> DLC03HermitCrabSpawnExplosion => Construct(0x4b350);
        public static FormLink<IExplosionGetter> DLC03SubBaseTinyExplosion => Construct(0x3ce40);
        public static FormLink<IExplosionGetter> DLC03SubBaseExplosion => Construct(0x38040);
        public static FormLink<IExplosionGetter> DLC03SubBaseSmExplosion => Construct(0x3803f);
        public static FormLink<IExplosionGetter> DLC03VRBeamEnd => Construct(0x29b6f);
        public static FormLink<IExplosionGetter> DLC03VRDataRetrieverExplosion => Construct(0x2522f);
    }
}