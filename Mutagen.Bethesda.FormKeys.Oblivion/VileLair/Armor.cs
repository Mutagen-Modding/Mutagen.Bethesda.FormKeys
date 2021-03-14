using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Armor
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IArmorGetter> Construct(uint id) => new FormLink<IArmorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArmorGetter> LairVileCrimsonScarRaiment05 => Construct(0xbe66);
            public static FormLink<IArmorGetter> LairVileCrimsonScarRaiment10 => Construct(0xbe67);
            public static FormLink<IArmorGetter> LairVileCrimsonScarRaiment15 => Construct(0xbe68);
            public static FormLink<IArmorGetter> LairVileCrimsonScarRaiment25 => Construct(0xbe6a);
            public static FormLink<IArmorGetter> LairVileCrimsonScarRaiment20 => Construct(0xc35e);
            public static FormLink<IArmorGetter> LairVileCrimsonScarRaiment01 => Construct(0xbe65);
        }
    }
}
