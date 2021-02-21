using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class LocationReferenceType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<ILocationReferenceTypeGetter> Construct(uint id) => new FormLink<ILocationReferenceTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILocationReferenceTypeGetter> DLC1HoundPatrol => Construct(0x10f63);
            public static FormLink<ILocationReferenceTypeGetter> DLC1SpawnQuestStarter => Construct(0xe684);
            public static FormLink<ILocationReferenceTypeGetter> DLC1RadiantScoutMarker => Construct(0x41cc);
            public static FormLink<ILocationReferenceTypeGetter> DLC1VQ01DeathHound2LRT => Construct(0x19a36);
            public static FormLink<ILocationReferenceTypeGetter> DLC1VQ01DeathHound1LRT => Construct(0x19a35);
            public static FormLink<ILocationReferenceTypeGetter> DLC1VQ02GargoyleLRT => Construct(0x19a34);
            public static FormLink<ILocationReferenceTypeGetter> DLC1VQ01LvLVampire2LRT => Construct(0x18dba);
            public static FormLink<ILocationReferenceTypeGetter> DLC1DurnehviirLRT => Construct(0x16684);
            public static FormLink<ILocationReferenceTypeGetter> DLC1RV07Coffin => Construct(0xa29d);
            public static FormLink<ILocationReferenceTypeGetter> DLC1LinkTargetGuard => Construct(0x33cd);
            public static FormLink<ILocationReferenceTypeGetter> DLC1LinkTargetKeepEyeOn => Construct(0x33cc);
            public static FormLink<ILocationReferenceTypeGetter> DLC1LinkTargetServices => Construct(0x33c8);
            public static FormLink<ILocationReferenceTypeGetter> DLC1LinkTargetSandbox => Construct(0x33b6);
            public static FormLink<ILocationReferenceTypeGetter> DLC1LinkTargetSleep => Construct(0x33b5);
            public static FormLink<ILocationReferenceTypeGetter> DLC1LinkTargetEat => Construct(0x33b4);
        }
    }
}
