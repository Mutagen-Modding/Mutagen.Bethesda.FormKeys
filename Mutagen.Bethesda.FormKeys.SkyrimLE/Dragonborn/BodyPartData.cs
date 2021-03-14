using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class BodyPartData
        {
            private static FormLink<IBodyPartDataGetter> Construct(uint id) => new FormLink<IBodyPartDataGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBodyPartDataGetter> DLC2MountedRieklingBodyPartData => Construct(0x1e2a3);
            public static FormLink<IBodyPartDataGetter> DwarvenBallistaCenturionBodyPartData => Construct(0x2b018);
            public static FormLink<IBodyPartDataGetter> BenthicLurkerBodyPartData => Construct(0x28537);
            public static FormLink<IBodyPartDataGetter> DLC2NetchBodyPartData => Construct(0x1feb9);
            public static FormLink<IBodyPartDataGetter> DLC2HMDaedraPartData => Construct(0x1dcbc);
            public static FormLink<IBodyPartDataGetter> DLC2DragonBodyPartData => Construct(0x1bc4a);
            public static FormLink<IBodyPartDataGetter> DLC2ScribBodyPartData => Construct(0x19ad2);
            public static FormLink<IBodyPartDataGetter> DLC2RieklingBodyPartData => Construct(0x17f53);
        }
    }
}
