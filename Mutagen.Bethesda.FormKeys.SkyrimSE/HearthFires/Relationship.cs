namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Relationship
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHHousecarlPalePlayerRelationship => ModKey.MakeFormKey(0x5227);
            public static FormKey BYOHHousecarlHjaalmarchPlayerRelationship => ModKey.MakeFormKey(0x5226);
            public static FormKey BYOHHousecarlFalkreathPlayerRelationship => ModKey.MakeFormKey(0x5225);
        }
    }
}
