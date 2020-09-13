namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class AssociationType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey FavorTarget => ModKey.MakeFormKey(0x3f4da);
            public static FormKey Conspirators => ModKey.MakeFormKey(0x806d9);
            public static FormKey Courting => ModKey.MakeFormKey(0x1ee23);
            public static FormKey BusinessPartners => ModKey.MakeFormKey(0x1edfd);
            public static FormKey InLawParentChild => ModKey.MakeFormKey(0x1e917);
            public static FormKey GreatGrandparentGreatgrandchild => ModKey.MakeFormKey(0x1e90b);
            public static FormKey InLawGrandparentGrandchild => ModKey.MakeFormKey(0x1e90a);
            public static FormKey BossEmployee => ModKey.MakeFormKey(0x1e817);
            public static FormKey InLawAuntUncle => ModKey.MakeFormKey(0x1e80d);
            public static FormKey GrandAuntUncle => ModKey.MakeFormKey(0x1e80b);
            public static FormKey GrandparentGrandchild => ModKey.MakeFormKey(0x1e803);
            public static FormKey InLawBrotherSister => ModKey.MakeFormKey(0x1e764);
            public static FormKey JarlHousecarl => ModKey.MakeFormKey(0x1e75d);
            public static FormKey JarlSteward => ModKey.MakeFormKey(0x1e75a);
            public static FormKey MasterAssistant => ModKey.MakeFormKey(0x1e74f);
            public static FormKey Spouse => ModKey.MakeFormKey(0x142ca);
            public static FormKey Cousins => ModKey.MakeFormKey(0x142c8);
            public static FormKey AuntUncle => ModKey.MakeFormKey(0x142c7);
            public static FormKey ParentChild => ModKey.MakeFormKey(0x142c6);
            public static FormKey Siblings => ModKey.MakeFormKey(0x142c5);
        }
    }
}
