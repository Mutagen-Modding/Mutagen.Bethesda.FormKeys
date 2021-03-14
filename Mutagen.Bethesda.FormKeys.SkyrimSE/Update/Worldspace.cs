using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Worldspace
        {
            private static FormLink<IWorldspaceGetter> Construct(uint id) => new FormLink<IWorldspaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWorldspaceGetter> TestSnow => Construct(0x293a);
        }
    }
}
