// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Skyrim
{
    public static partial class AssociationType
    {
        private static FormLink<IAssociationTypeGetter> Construct(uint id) => new FormLink<IAssociationTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAssociationTypeGetter> FavorTarget => Construct(0x3f4da);
        public static FormLink<IAssociationTypeGetter> Conspirators => Construct(0x806d9);
        public static FormLink<IAssociationTypeGetter> Courting => Construct(0x1ee23);
        public static FormLink<IAssociationTypeGetter> BusinessPartners => Construct(0x1edfd);
        public static FormLink<IAssociationTypeGetter> InLawParentChild => Construct(0x1e917);
        public static FormLink<IAssociationTypeGetter> GreatGrandparentGreatgrandchild => Construct(0x1e90b);
        public static FormLink<IAssociationTypeGetter> InLawGrandparentGrandchild => Construct(0x1e90a);
        public static FormLink<IAssociationTypeGetter> BossEmployee => Construct(0x1e817);
        public static FormLink<IAssociationTypeGetter> InLawAuntUncle => Construct(0x1e80d);
        public static FormLink<IAssociationTypeGetter> GrandAuntUncle => Construct(0x1e80b);
        public static FormLink<IAssociationTypeGetter> GrandparentGrandchild => Construct(0x1e803);
        public static FormLink<IAssociationTypeGetter> InLawBrotherSister => Construct(0x1e764);
        public static FormLink<IAssociationTypeGetter> JarlHousecarl => Construct(0x1e75d);
        public static FormLink<IAssociationTypeGetter> JarlSteward => Construct(0x1e75a);
        public static FormLink<IAssociationTypeGetter> MasterAssistant => Construct(0x1e74f);
        public static FormLink<IAssociationTypeGetter> Spouse => Construct(0x142ca);
        public static FormLink<IAssociationTypeGetter> Cousins => Construct(0x142c8);
        public static FormLink<IAssociationTypeGetter> AuntUncle => Construct(0x142c7);
        public static FormLink<IAssociationTypeGetter> ParentChild => Construct(0x142c6);
        public static FormLink<IAssociationTypeGetter> Siblings => Construct(0x142c5);
    }
}
