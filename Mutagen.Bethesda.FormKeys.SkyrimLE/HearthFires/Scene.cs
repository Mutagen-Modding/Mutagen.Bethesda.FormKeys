namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Scene
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey RelationshipAdoption_SceneNameCalling01 => ModKey.MakeFormKey(0x1652e);
            public static FormKey RelationshipAdoption_SceneNameCalling02 => ModKey.MakeFormKey(0x1652d);
            public static FormKey BYOHHouseStewardOfferScene => ModKey.MakeFormKey(0x3179);
        }
    }
}
