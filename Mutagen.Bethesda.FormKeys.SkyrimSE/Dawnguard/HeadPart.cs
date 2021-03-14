using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class HeadPart
        {
            private static FormLink<IHeadPartGetter> Construct(uint id) => new FormLink<IHeadPartGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IHeadPartGetter> DLC1HairFemaleSeranaHuman => Construct(0xe88c);
            public static FormLink<IHeadPartGetter> DLC1HairFemaleSerana => Construct(0xd95d);
            public static FormLink<IHeadPartGetter> DLC1HairLineFemaleSerana => Construct(0xd95c);
            public static FormLink<IHeadPartGetter> MaleEyesHumanVampire01Nord => Construct(0xd6d6);
            public static FormLink<IHeadPartGetter> MaleEyesHumanVampireNord => Construct(0xd6d5);
            public static FormLink<IHeadPartGetter> FemaleEyesHumanVampire01Nord => Construct(0xd6d4);
            public static FormLink<IHeadPartGetter> FemaleEyesHumanVampireNord => Construct(0xd6d3);
            public static FormLink<IHeadPartGetter> MaleEyesSnowElfVampire => Construct(0x29e0);
            public static FormLink<IHeadPartGetter> HairLineMaleSnowElf06 => Construct(0x29df);
            public static FormLink<IHeadPartGetter> HairMaleSnowElf06 => Construct(0x29de);
            public static FormLink<IHeadPartGetter> HairMaleSnowElf03 => Construct(0x29d9);
            public static FormLink<IHeadPartGetter> HairLineMaleSnowElf03 => Construct(0x29d8);
            public static FormLink<IHeadPartGetter> HairMaleSnowElf02 => Construct(0x29d7);
            public static FormLink<IHeadPartGetter> HairLineMaleSnowElf02 => Construct(0x29d6);
            public static FormLink<IHeadPartGetter> DLC1HairLineFemaleValerica => Construct(0x29aa);
            public static FormLink<IHeadPartGetter> DLC1HairFemaleValerica => Construct(0x29a9);
            public static FormLink<IHeadPartGetter> FemaleHeadOrcVampire => Construct(0x6f9b);
            public static FormLink<IHeadPartGetter> MaleHeadOrcVampire => Construct(0x6f9a);
            public static FormLink<IHeadPartGetter> FemaleHeadWoodElfVampire => Construct(0x6f99);
            public static FormLink<IHeadPartGetter> FemaleHeadRedguardVampire => Construct(0x6f98);
            public static FormLink<IHeadPartGetter> FemaleHeadNordVampire => Construct(0x6f97);
            public static FormLink<IHeadPartGetter> FemaleHeadImperialVampire => Construct(0x6f96);
            public static FormLink<IHeadPartGetter> FemaleHeadHighElfVampire => Construct(0x6f95);
            public static FormLink<IHeadPartGetter> FemaleHeadBretonVampire => Construct(0x6f93);
            public static FormLink<IHeadPartGetter> FemaleHeadDarkElfVampire => Construct(0x6f92);
            public static FormLink<IHeadPartGetter> FemaleEyesHumanVampire01 => Construct(0x6f90);
            public static FormLink<IHeadPartGetter> MaleHeadWoodElfVampire => Construct(0x6f8f);
            public static FormLink<IHeadPartGetter> MaleHeadRedguardVampire => Construct(0x6f8e);
            public static FormLink<IHeadPartGetter> MaleHeadBretonVampire => Construct(0x6f8d);
            public static FormLink<IHeadPartGetter> MaleHeadHighElfVampire => Construct(0x6f8c);
            public static FormLink<IHeadPartGetter> MaleHeadImperialVampire => Construct(0x6f8b);
            public static FormLink<IHeadPartGetter> MaleHeadNordVampire => Construct(0x6f8a);
            public static FormLink<IHeadPartGetter> MaleEyesHumanVampire01 => Construct(0x6f88);
            public static FormLink<IHeadPartGetter> MaleHeadDarkElfVampire => Construct(0x6f84);
            public static FormLink<IHeadPartGetter> HairLineMaleSnowElf01 => Construct(0x378d);
            public static FormLink<IHeadPartGetter> HairMaleSnowElf01 => Construct(0x378c);
            public static FormLink<IHeadPartGetter> BrowsMaleSnowElf => Construct(0x3789);
            public static FormLink<IHeadPartGetter> MaleEyesSnowElf => Construct(0x3786);
            public static FormLink<IHeadPartGetter> MaleHeadHighElfSnow => Construct(0x3784);
        }
    }
}
