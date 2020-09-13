namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class FormList
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey HelpManualMods => ModKey.MakeFormKey(0x2ecc);
            public static FormKey RidableWorldSpaces => ModKey.MakeFormKey(0x99b);
            public static FormKey SunAffectingExceptionWorldSpaces => ModKey.MakeFormKey(0x99a);
            public static FormKey OversizedSummoningExceptionWorldSpaces => ModKey.MakeFormKey(0x999);
            public static FormKey WeatherExceptionList => ModKey.MakeFormKey(0x998);
            public static FormKey SunDamageExceptionWorldSpaces => ModKey.MakeFormKey(0x969);
            public static FormKey HelpManualKinect => ModKey.MakeFormKey(0x94a);
            public static FormKey VATSLargeRaceList => ModKey.MakeFormKey(0x8f4);
        }
    }
}
