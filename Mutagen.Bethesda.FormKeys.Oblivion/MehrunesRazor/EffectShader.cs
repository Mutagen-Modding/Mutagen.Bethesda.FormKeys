namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class EffectShader
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9ChampShader => ModKey.MakeFormKey(0x1a22);
            public static FormKey DL9ChampDeathFX => ModKey.MakeFormKey(0x2716);
        }
    }
}
