using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Skyrim
{
    public static partial class ImpactDataSet
    {
        public static FormLink<IImpactDataSetGetter> DefaultImpactDataSet => Construct(0x276);
    }
}