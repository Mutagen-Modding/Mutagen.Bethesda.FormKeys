namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey sTESVDLC2FlyingMountLandingMessage => ModKey.MakeFormKey(0x1e2bb);
            public static FormKey sTESVDLC2FlyingMountCannotLandMessage => ModKey.MakeFormKey(0x1e2ba);
            public static FormKey sTESVDLC2FlyingMountCancelLandingMessage => ModKey.MakeFormKey(0x1e2b9);
            public static FormKey sTESVDLC2FlyingDragonNoCastMessage => ModKey.MakeFormKey(0x1e2b8);
            public static FormKey sTESVDLC2DragonUnableToFlyMessage => ModKey.MakeFormKey(0x1e2b7);
        }
    }
}
