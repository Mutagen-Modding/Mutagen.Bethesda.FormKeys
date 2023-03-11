// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static class AssociationType
    {
        private static FormLink<IAssociationTypeGetter> Construct(uint id) => new FormLink<IAssociationTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAssociationTypeGetter> Spouse => Construct(0x1996d);
        public static FormLink<IAssociationTypeGetter> Siblings => Construct(0x1996c);
        public static FormLink<IAssociationTypeGetter> ParentChild => Construct(0x1996b);
        public static FormLink<IAssociationTypeGetter> InLawParentChild => Construct(0x1996a);
        public static FormLink<IAssociationTypeGetter> InLawBrotherSister => Construct(0x19969);
        public static FormLink<IAssociationTypeGetter> GrandparentGrandchild => Construct(0x19968);
        public static FormLink<IAssociationTypeGetter> GrandAuntUncle => Construct(0x19967);
        public static FormLink<IAssociationTypeGetter> FavorTarget => Construct(0x19964);
        public static FormLink<IAssociationTypeGetter> Cousins => Construct(0x19963);
        public static FormLink<IAssociationTypeGetter> Courting => Construct(0x19962);
        public static FormLink<IAssociationTypeGetter> BusinessPartners => Construct(0x19961);
        public static FormLink<IAssociationTypeGetter> BossEmployee => Construct(0x19960);
        public static FormLink<IAssociationTypeGetter> AuntUncle => Construct(0x1995f);
    }
}