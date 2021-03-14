using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Door
        {
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> BYOHWRDoorLoad01 => Construct(0xb5e);
            public static FormLink<IDoorGetter> BYOHBYOHWRtowerRTrapDoor02 => Construct(0x3b70);
            public static FormLink<IDoorGetter> BYOHBYOHWRtowerRTrapDoor01 => Construct(0x3b6f);
            public static FormLink<IDoorGetter> BYOHBYOHWRtowerLTrapDoor02 => Construct(0x3b6e);
            public static FormLink<IDoorGetter> BYOHBYOHWRtowerLTrapDoor01 => Construct(0x3b6d);
            public static FormLink<IDoorGetter> BYOHBYOHWRtowerKTrapDoor02 => Construct(0x3b6c);
            public static FormLink<IDoorGetter> BYOHBYOHWRtowerKTrapDoor01 => Construct(0x3b6b);
        }
    }
}
