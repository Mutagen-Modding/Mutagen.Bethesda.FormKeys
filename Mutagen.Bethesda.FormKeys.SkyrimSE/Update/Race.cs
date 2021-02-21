using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Race
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IRaceGetter> Construct(uint id) => new FormLink<IRaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRaceGetter> ccBGSSSE036_BoneWolfCompanionRace => Construct(0x2f93);
            public static FormLink<IRaceGetter> ccBGSSSE035_NixHoundCompanionRace => Construct(0x2f74);
        }
    }
}
