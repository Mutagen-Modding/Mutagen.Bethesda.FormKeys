using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class ActionRecord
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IActionRecordGetter> Construct(uint id) => new FormLink<IActionRecordGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActionRecordGetter> ActionReload => Construct(0x590d);
            public static FormLink<IActionRecordGetter> ActionWaterwalkStart => Construct(0x4344);
        }
    }
}
