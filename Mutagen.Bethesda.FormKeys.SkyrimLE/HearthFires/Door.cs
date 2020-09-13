namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHWRDoorLoad01 => ModKey.MakeFormKey(0xb5e);
            public static FormKey BYOHBYOHWRtowerRTrapDoor02 => ModKey.MakeFormKey(0x3b70);
            public static FormKey BYOHBYOHWRtowerRTrapDoor01 => ModKey.MakeFormKey(0x3b6f);
            public static FormKey BYOHBYOHWRtowerLTrapDoor02 => ModKey.MakeFormKey(0x3b6e);
            public static FormKey BYOHBYOHWRtowerLTrapDoor01 => ModKey.MakeFormKey(0x3b6d);
            public static FormKey BYOHBYOHWRtowerKTrapDoor02 => ModKey.MakeFormKey(0x3b6c);
            public static FormKey BYOHBYOHWRtowerKTrapDoor01 => ModKey.MakeFormKey(0x3b6b);
        }
    }
}
