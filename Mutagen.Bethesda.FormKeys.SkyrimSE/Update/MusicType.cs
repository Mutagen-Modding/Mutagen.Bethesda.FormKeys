using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class MusicType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IMusicTypeGetter> Construct(uint id) => new FormLink<IMusicTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMusicTypeGetter> ccMUSDungeonOblivion => Construct(0x3053);
            public static FormLink<IMusicTypeGetter> MUSCombatBossUmbra => Construct(0x301e);
        }
    }
}
