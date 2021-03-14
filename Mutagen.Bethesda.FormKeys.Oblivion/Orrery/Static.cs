using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Static
        {
            private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IStaticGetter> ArchitectureOrreryDoorFrame => Construct(0x11eb57);
        }
    }
}
