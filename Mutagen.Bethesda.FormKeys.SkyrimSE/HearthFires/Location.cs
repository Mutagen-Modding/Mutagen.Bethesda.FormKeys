using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Location
        {
            private static FormLink<ILocationGetter> Construct(uint id) => new FormLink<ILocationGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILocationGetter> BYOHHouse3LocationInterior => Construct(0xbe1d);
            public static FormLink<ILocationGetter> BYOHHouse2LocationInterior => Construct(0xbe0a);
            public static FormLink<ILocationGetter> BYOHHouse3Location => Construct(0x520a);
            public static FormLink<ILocationGetter> BYOHHouse2Location => Construct(0x5209);
            public static FormLink<ILocationGetter> BYOHHouse1LocationInterior => Construct(0x3092);
            public static FormLink<ILocationGetter> BYOHHouse1Location => Construct(0x308a);
        }
    }
}
