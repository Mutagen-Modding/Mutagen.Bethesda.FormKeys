using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class LocationReferenceType
        {
            private static FormLink<ILocationReferenceTypeGetter> Construct(uint id) => new FormLink<ILocationReferenceTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILocationReferenceTypeGetter> BYOHHouseChicken => Construct(0xc3c);
            public static FormLink<ILocationReferenceTypeGetter> BYOHHouseCow => Construct(0xc3b);
            public static FormLink<ILocationReferenceTypeGetter> BYOHHouseFrontDoor => Construct(0x8a9);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_PetDoorMarker => Construct(0x1881b);
            public static FormLink<ILocationReferenceTypeGetter> BYOHHouseBasementMarker => Construct(0x10a45);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildPlayDoll => Construct(0xd82e);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildBed => Construct(0x425e);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildChest => Construct(0x425d);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildDummy => Construct(0x425c);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildSandboxOutside => Construct(0x425b);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildSandboxRoom => Construct(0x425a);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildSandboxHome => Construct(0x4259);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildSceneMarker => Construct(0x401b);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildDiningTable => Construct(0x3f7f);
            public static FormLink<ILocationReferenceTypeGetter> BYOHAdoption_ChildPatrolChores => Construct(0x3f30);
        }
    }
}
