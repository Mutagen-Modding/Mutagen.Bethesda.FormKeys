// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static class Race
    {
        private static FormLink<IRaceGetter> Construct(uint id) => new FormLink<IRaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IRaceGetter> DLC03_GulperSmallRace => Construct(0x4e28e);
        public static FormLink<IRaceGetter> DLC03_SynthGen2RaceDiMa => Construct(0x42ebb);
        public static FormLink<IRaceGetter> DLC03_RadChickenRace => Construct(0x3fd66);
        public static FormLink<IRaceGetter> DLC03_RadRabbitRace => Construct(0x3ddde);
        public static FormLink<IRaceGetter> DLC03_MutatedWolfRace => Construct(0x3d077);
        public static FormLink<IRaceGetter> DLC03StingwingRace => Construct(0x3cf1e);
        public static FormLink<IRaceGetter> DLC03RoboBrainRace => Construct(0x33e79);
        public static FormLink<IRaceGetter> DLC03VRDataRetrieverRace => Construct(0x2e010);
        public static FormLink<IRaceGetter> DLC03PowerArmorRaceAdditiveSubgraphData => Construct(0x2bee6);
        public static FormLink<IRaceGetter> DLC03_GulperRace => Construct(0x247c1);
        public static FormLink<IRaceGetter> DLC03_HermitCrabRace => Construct(0x180a8);
        public static FormLink<IRaceGetter> DLC03_FogCrawlerRace => Construct(0x14174);
        public static FormLink<IRaceGetter> DLC03_AnglerRace => Construct(0xfeea);
        public static FormLink<IRaceGetter> DLC03HumanRaceAdditiveSubgraphData => Construct(0xc6a7);
        public static FormLink<IRaceGetter> DLC03VRDefenderTurretRace => Construct(0x9591);
    }
}