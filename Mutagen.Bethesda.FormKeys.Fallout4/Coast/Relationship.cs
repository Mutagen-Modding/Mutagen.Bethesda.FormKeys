// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class Relationship
    {
        private static FormLink<IRelationshipGetter> Construct(uint id) => new FormLink<IRelationshipGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IRelationshipGetter> DLC03MrNakanoKasumiNakano => Construct(0x3ecf);
        public static FormLink<IRelationshipGetter> DLC03MrsNakanoKasumi => Construct(0x3ece);
        public static FormLink<IRelationshipGetter> DLC03MrNakanoMrsNakano => Construct(0x3ecd);
    }
}
