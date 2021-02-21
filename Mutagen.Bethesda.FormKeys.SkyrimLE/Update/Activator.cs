using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IActivatorGetter> Construct(uint id) => new FormLink<IActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActivatorGetter> Patch1_8DLC1DoorFix => Construct(0x9a0);
            public static FormLink<IActivatorGetter> WEDL06LetrushCleanupTrigger => Construct(0x99d);
            public static FormLink<IActivatorGetter> TG09DoorOverrideFixTrigger => Construct(0x80e);
            public static FormLink<IActivatorGetter> dunDA14PortalDisableTrigger => Construct(0x80c);
            public static FormLink<IActivatorGetter> C05RepairTrigger => Construct(0x800);
        }
    }
}
