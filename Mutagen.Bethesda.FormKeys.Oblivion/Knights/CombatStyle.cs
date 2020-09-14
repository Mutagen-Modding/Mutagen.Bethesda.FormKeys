namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class CombatStyle
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            public static FormKey NDDefaultAuroran => ModKey.MakeFormKey(0x2e62);
            public static FormKey NDDefaultUmaril => ModKey.MakeFormKey(0x2e61);
        }
    }
}
