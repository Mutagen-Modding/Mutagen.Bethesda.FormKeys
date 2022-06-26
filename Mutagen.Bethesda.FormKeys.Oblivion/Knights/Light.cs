// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Knights
{
    public static class Light
    {
        private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILightGetter> NDGarlasDaylight450 => Construct(0xef9);
        public static FormLink<ILightGetter> ChorrolLightSoftYellow128 => Construct(0xefa);
        public static FormLink<ILightGetter> CathedralCryptLight01Grey128 => Construct(0xefb);
        public static FormLink<ILightGetter> CathedralCryptLight02Gray256 => Construct(0xefc);
        public static FormLink<ILightGetter> CathedralCryptLight01Grey256 => Construct(0xefd);
        public static FormLink<ILightGetter> NDSconceOFF => Construct(0xefe);
        public static FormLink<ILightGetter> STorWhiteBright600 => Construct(0xeff);
        public static FormLink<ILightGetter> CommonLightGrey512 => Construct(0xf00);
        public static FormLink<ILightGetter> CommonLightGrey384 => Construct(0xf01);
        public static FormLink<ILightGetter> NDPilgrimLight => Construct(0xf02);
    }
}
