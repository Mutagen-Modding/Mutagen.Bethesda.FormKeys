using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class LeveledCreature
        {
            private static FormLink<ILeveledCreatureGetter> Construct(uint id) => new FormLink<ILeveledCreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledCreatureGetter> DLC06UndeadPirate100 => Construct(0x11ae0);
        }
    }
}
