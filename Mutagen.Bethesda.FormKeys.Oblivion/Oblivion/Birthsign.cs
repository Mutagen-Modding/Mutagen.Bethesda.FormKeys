// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Oblivion
{
    public static partial class Birthsign
    {
        private static FormLink<IBirthsignGetter> Construct(uint id) => new FormLink<IBirthsignGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IBirthsignGetter> BirthSignWarrior => Construct(0x1fd9d);
        public static FormLink<IBirthsignGetter> BirthSignTower => Construct(0x1fd9c);
        public static FormLink<IBirthsignGetter> BirthSignSteed => Construct(0x1fd9b);
        public static FormLink<IBirthsignGetter> BirthSignShadow => Construct(0x1fd9a);
        public static FormLink<IBirthsignGetter> BirthSignSerpent => Construct(0x1fd99);
        public static FormLink<IBirthsignGetter> BirthSignRitual => Construct(0x1fd98);
        public static FormLink<IBirthsignGetter> BirthSignLover => Construct(0x1fd97);
        public static FormLink<IBirthsignGetter> BirthSignLord => Construct(0x1fd96);
        public static FormLink<IBirthsignGetter> BirthSignAtronach => Construct(0x1fd95);
        public static FormLink<IBirthsignGetter> BirthSignThief => Construct(0x1fd94);
        public static FormLink<IBirthsignGetter> BirthSignMage => Construct(0x1fd93);
        public static FormLink<IBirthsignGetter> BirthSignLady => Construct(0x1fd92);
        public static FormLink<IBirthsignGetter> BirthSignApprentice => Construct(0x1fd91);
    }
}
