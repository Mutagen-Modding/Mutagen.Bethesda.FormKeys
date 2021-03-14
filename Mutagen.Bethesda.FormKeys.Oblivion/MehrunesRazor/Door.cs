using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Door
        {
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> DL9HiddenDoor => Construct(0x353f);
            public static FormLink<IDoorGetter> DL9DrothanClosetDoor => Construct(0x14fd);
            public static FormLink<IDoorGetter> DL9StewardDoor => Construct(0x158a);
        }
    }
}
