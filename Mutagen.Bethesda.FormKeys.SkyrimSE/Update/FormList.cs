using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class FormList
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IFormListGetter> Construct(uint id) => new FormLink<IFormListGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFormListGetter> HelpManualMods => Construct(0x2ecc);
            public static FormLink<IFormListGetter> RidableWorldSpaces => Construct(0x99b);
            public static FormLink<IFormListGetter> SunAffectingExceptionWorldSpaces => Construct(0x99a);
            public static FormLink<IFormListGetter> OversizedSummoningExceptionWorldSpaces => Construct(0x999);
            public static FormLink<IFormListGetter> WeatherExceptionList => Construct(0x998);
            public static FormLink<IFormListGetter> SunDamageExceptionWorldSpaces => Construct(0x969);
            public static FormLink<IFormListGetter> HelpManualKinect => Construct(0x94a);
            public static FormLink<IFormListGetter> VATSLargeRaceList => Construct(0x8f4);
        }
    }
}
