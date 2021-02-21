using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class LeveledNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<ILeveledNpcGetter> Construct(uint id) => new FormLink<ILeveledNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledNpcGetter> ccBGSSSE003_LCharUndeadList => Construct(0x3024);
        }
    }
}
