namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey DLCOrreryBandit3 => ModKey.MakeFormKey(0x11c3d5);
            public static FormKey DLCOrreyBandit4 => ModKey.MakeFormKey(0x11c3d7);
            public static FormKey DLCOrreryBandit5 => ModKey.MakeFormKey(0x11c3d8);
            public static FormKey DLCOrreyBandit1 => ModKey.MakeFormKey(0x11c3d1);
            public static FormKey DLCOrreyBandit2 => ModKey.MakeFormKey(0x11c3d4);
        }
    }
}
