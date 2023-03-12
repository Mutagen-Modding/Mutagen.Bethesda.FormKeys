using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class AStoryManagerNode
    {
        public static FormLink<IAStoryManagerNodeGetter> Root => Construct(0x5B);
    }
}