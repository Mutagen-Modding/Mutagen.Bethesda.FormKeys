using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class LoadScreen
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> DL9VillageLoadDoor => Construct(0x1b8d);
            public static FormLink<ILoadScreenGetter> DL9extLoadDoor => Construct(0x1567);
            public static FormLink<ILoadScreenGetter> DL9MinesLoadDoor => Construct(0x1b87);
            public static FormLink<ILoadScreenGetter> DL9CommuneLoadDoor => Construct(0x1b88);
        }
    }
}
