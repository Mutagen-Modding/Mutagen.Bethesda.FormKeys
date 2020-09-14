namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class EffectShader
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            public static FormKey ND05PlateEffect => ModKey.MakeFormKey(0x2e64);
            public static FormKey NDSpiritEffect => ModKey.MakeFormKey(0x2e65);
            public static FormKey ND05ItemEffect => ModKey.MakeFormKey(0x2e66);
            public static FormKey NDGhostEffect => ModKey.MakeFormKey(0x2e63);
        }
    }
}
