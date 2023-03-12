using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class ImpactDataSet
    {
        public static FormLink<IImpactDataSetGetter> DefaultImpactDataSet => Construct(0x248014);
    }
}