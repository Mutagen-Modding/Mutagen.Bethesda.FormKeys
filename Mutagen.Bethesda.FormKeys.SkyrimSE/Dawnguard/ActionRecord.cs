namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class ActionRecord
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey ActionReload => ModKey.MakeFormKey(0x590d);
            public static FormKey ActionWaterwalkStart => ModKey.MakeFormKey(0x4344);
        }
    }
}
