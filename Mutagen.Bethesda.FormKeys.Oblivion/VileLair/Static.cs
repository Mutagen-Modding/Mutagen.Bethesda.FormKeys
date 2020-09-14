namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Static
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey HumanStatue1 => ModKey.MakeFormKey(0x6f83);
            public static FormKey HumanStatue2 => ModKey.MakeFormKey(0x6f84);
            public static FormKey HumanStatue3 => ModKey.MakeFormKey(0x6f85);
            public static FormKey LairVileSithisShrineStatic => ModKey.MakeFormKey(0x37f3);
        }
    }
}
