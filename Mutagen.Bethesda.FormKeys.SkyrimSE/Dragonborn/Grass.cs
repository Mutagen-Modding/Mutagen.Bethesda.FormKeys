namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Grass
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC02VolcanicAshGrass02 => ModKey.MakeFormKey(0x1e341);
            public static FormKey DLC02VolcanicAshGrass01 => ModKey.MakeFormKey(0x17ea2);
            public static FormKey DLC02VolcanicAshRocks01 => ModKey.MakeFormKey(0x1771e);
        }
    }
}
