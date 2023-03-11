// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static class LeveledNpc
    {
        private static FormLink<ILeveledNpcGetter> Construct(uint id) => new FormLink<ILeveledNpcGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILeveledNpcGetter> DLC02LCharViciousDog => Construct(0xeb9);
        public static FormLink<ILeveledNpcGetter> DLC02LCharYaoGuai => Construct(0xeb6);
        public static FormLink<ILeveledNpcGetter> DLC02LCharStingwing => Construct(0xeb4);
        public static FormLink<ILeveledNpcGetter> DLC02LCharRadStag => Construct(0xeb2);
        public static FormLink<ILeveledNpcGetter> DLC02LCharRadScorpion => Construct(0xeb0);
        public static FormLink<ILeveledNpcGetter> DLC02LCharRadroach => Construct(0xeae);
        public static FormLink<ILeveledNpcGetter> DLC02LCharMutantHound => Construct(0xeac);
        public static FormLink<ILeveledNpcGetter> DLC02LCharMolerat => Construct(0xea9);
        public static FormLink<ILeveledNpcGetter> DLC02LCharMirelurkAll => Construct(0xea5);
        public static FormLink<ILeveledNpcGetter> DLC02LCharFeralGhoulGlowingOne => Construct(0xea4);
        public static FormLink<ILeveledNpcGetter> DLC02LCharDeathclaw => Construct(0xea1);
        public static FormLink<ILeveledNpcGetter> DLC02LCharBloodbug => Construct(0xe9d);
        public static FormLink<ILeveledNpcGetter> DLC02LCharBloatfly => Construct(0xe9c);
        public static FormLink<ILeveledNpcGetter> DLC02LCharInsects => Construct(0x846);
    }
}