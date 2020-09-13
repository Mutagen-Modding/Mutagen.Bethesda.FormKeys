namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey sGenericCraftKeywordName10 => ModKey.MakeFormKey(0x298c);
            public static FormKey sVerletCape => ModKey.MakeFormKey(0x19876);
            public static FormKey fMagicGrabActorMinDistance => ModKey.MakeFormKey(0x15713);
            public static FormKey fMagicGrabActorThrowForce => ModKey.MakeFormKey(0x15712);
            public static FormKey sInvalidTagString => ModKey.MakeFormKey(0x6995);
            public static FormKey sRSMFinishedWarning => ModKey.MakeFormKey(0x698e);
            public static FormKey sNoBolts => ModKey.MakeFormKey(0x8bd1);
        }
    }
}
