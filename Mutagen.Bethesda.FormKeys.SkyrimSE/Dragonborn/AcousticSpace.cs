using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class AcousticSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IAcousticSpaceGetter> Construct(uint id) => new FormLink<IAcousticSpaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAcousticSpaceGetter> IntDLC2ApocryphaBookPOI => Construct(0x39e50);
            public static FormLink<IAcousticSpaceGetter> IntDLC2TelMithrynDry => Construct(0x39751);
            public static FormLink<IAcousticSpaceGetter> IntDLC2TelMithryn => Construct(0x3974d);
        }
    }
}
