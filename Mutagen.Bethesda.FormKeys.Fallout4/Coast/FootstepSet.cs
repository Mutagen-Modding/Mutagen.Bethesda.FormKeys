// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class FootstepSet
    {
        private static FormLink<IFootstepSetGetter> Construct(uint id) => new FormLink<IFootstepSetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFootstepSetGetter> DLC03RadRabbitFootFootstepSet => Construct(0x5d7e9);
        public static FormLink<IFootstepSetGetter> DLC03NPCHermitCrabFootstepSet => Construct(0x5d3de);
        public static FormLink<IFootstepSetGetter> DLC03NPCDataRetrieverFootstepSet => Construct(0x5d128);
        public static FormLink<IFootstepSetGetter> DLC03NPCAnglerFootstepSet => Construct(0x56fdb);
        public static FormLink<IFootstepSetGetter> DLC03NPCGulperFootstepSet => Construct(0x4f57f);
        public static FormLink<IFootstepSetGetter> DLC03NPCChickenFootWalkFootstepSet => Construct(0x4b9cc);
        public static FormLink<IFootstepSetGetter> DLC03NPCFogCrawlerFootstepSet => Construct(0x4871e);
    }
}
