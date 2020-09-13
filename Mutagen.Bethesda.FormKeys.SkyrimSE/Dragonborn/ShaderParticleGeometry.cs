namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class ShaderParticleGeometry
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC02AshParticlesLite => ModKey.MakeFormKey(0x32337);
            public static FormKey DLC02VolcanicAshParticles01 => ModKey.MakeFormKey(0x18472);
        }
    }
}
