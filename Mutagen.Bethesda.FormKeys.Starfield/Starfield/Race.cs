// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class Starfield
{
    public static partial class Race
    {
        private static FormLink<IRaceGetter> Construct(uint id) => new FormLink<IRaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IRaceGetter> HumanRace => Construct(0x347d);
        public static FormLink<IRaceGetter> ModelARace => Construct(0x5629);
        public static FormLink<IRaceGetter> HopperARace => Construct(0xa1d7);
        public static FormLink<IRaceGetter> ModelSRace => Construct(0x130f0);
        public static FormLink<IRaceGetter> OctopedeARace => Construct(0x15b13);
        public static FormLink<IRaceGetter> CritterRace => Construct(0x176b6);
        public static FormLink<IRaceGetter> AutopilotRace => Construct(0x25739);
        public static FormLink<IRaceGetter> FloaterARace => Construct(0x2e9bb);
        public static FormLink<IRaceGetter> HumanCorpseRace => Construct(0x34fb1);
        public static FormLink<IRaceGetter> ModelTRace => Construct(0x45f14);
        public static FormLink<IRaceGetter> SecurityCameraRace => Construct(0x47708);
        public static FormLink<IRaceGetter> QuadrupedARace => Construct(0x50301);
        public static FormLink<IRaceGetter> CCT_DummyRace => Construct(0x1bb965);
        public static FormLink<IRaceGetter> BallisticTurretRace => Construct(0x1cc9bc);
        public static FormLink<IRaceGetter> LaserTurretRace => Construct(0x1ea1db);
        public static FormLink<IRaceGetter> MannequinRace => Construct(0x1ee4da);
        public static FormLink<IRaceGetter> TerrormorphRace => Construct(0x21a8d7);
        public static FormLink<IRaceGetter> MiniBotARace => Construct(0x227705);
        public static FormLink<IRaceGetter> BipedARace => Construct(0x243bfc);
        public static FormLink<IRaceGetter> FlyerARace => Construct(0x243e11);
        public static FormLink<IRaceGetter> QuadrupedCRace => Construct(0x261647);
        public static FormLink<IRaceGetter> SwimmerARace => Construct(0x26aecc);
        public static FormLink<IRaceGetter> MantaARace => Construct(0x28b3e4);
        public static FormLink<IRaceGetter> LarvaARace => Construct(0x29a905);
        public static FormLink<IRaceGetter> MantidARace => Construct(0x29f8a3);
        public static FormLink<IRaceGetter> ChildRace => Construct(0x2aabcd);
        public static FormLink<IRaceGetter> ParasiteARace => Construct(0x2aad58);
        public static FormLink<IRaceGetter> HumanCrowdRace => Construct(0x2bbc09);
        public static FormLink<IRaceGetter> HexapodARace => Construct(0x2ccaaa);
        public static FormLink<IRaceGetter> QuadrupedBRace => Construct(0x2ccab0);
        public static FormLink<IRaceGetter> TerrormorphElderRace => Construct(0x3e4f51);
    }
}
