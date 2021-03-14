using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class ShaderParticleGeometry
        {
            private static FormLink<IShaderParticleGeometryGetter> Construct(uint id) => new FormLink<IShaderParticleGeometryGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IShaderParticleGeometryGetter> DLC02AshParticlesLite => Construct(0x32337);
            public static FormLink<IShaderParticleGeometryGetter> DLC02VolcanicAshParticles01 => Construct(0x18472);
        }
    }
}
