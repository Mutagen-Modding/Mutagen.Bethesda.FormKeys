namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey Aurelinwae => ModKey.MakeFormKey(0x1246);
            public static FormKey DLCFrostcragAtronachFlame => ModKey.MakeFormKey(0x1254);
            public static FormKey CreatureClannfearRuntFC => ModKey.MakeFormKey(0x214a);
            public static FormKey DLCFrostcragAtronachStorm => ModKey.MakeFormKey(0xd27);
            public static FormKey DLCFrostcragAtronachFrost => ModKey.MakeFormKey(0xd26);
            public static FormKey CreatureImpFrostCrag => ModKey.MakeFormKey(0x8c40);
        }
    }
}
