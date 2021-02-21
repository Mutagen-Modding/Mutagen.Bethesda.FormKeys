using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IGameSettingGetter> Construct(uint id) => new FormLink<IGameSettingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName10 => Construct(0x298c);
            public static FormLink<IGameSettingGetter> sVerletCape => Construct(0x19876);
            public static FormLink<IGameSettingGetter> fMagicGrabActorMinDistance => Construct(0x15713);
            public static FormLink<IGameSettingGetter> fMagicGrabActorThrowForce => Construct(0x15712);
            public static FormLink<IGameSettingGetter> sInvalidTagString => Construct(0x6995);
            public static FormLink<IGameSettingGetter> sRSMFinishedWarning => Construct(0x698e);
            public static FormLink<IGameSettingGetter> sNoBolts => Construct(0x8bd1);
        }
    }
}
