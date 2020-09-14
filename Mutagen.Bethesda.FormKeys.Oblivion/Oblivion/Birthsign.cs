namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Birthsign
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            public static FormKey BirthSignWarrior => ModKey.MakeFormKey(0x1fd9d);
            public static FormKey BirthSignTower => ModKey.MakeFormKey(0x1fd9c);
            public static FormKey BirthSignSteed => ModKey.MakeFormKey(0x1fd9b);
            public static FormKey BirthSignShadow => ModKey.MakeFormKey(0x1fd9a);
            public static FormKey BirthSignSerpent => ModKey.MakeFormKey(0x1fd99);
            public static FormKey BirthSignRitual => ModKey.MakeFormKey(0x1fd98);
            public static FormKey BirthSignLover => ModKey.MakeFormKey(0x1fd97);
            public static FormKey BirthSignLord => ModKey.MakeFormKey(0x1fd96);
            public static FormKey BirthSignAtronach => ModKey.MakeFormKey(0x1fd95);
            public static FormKey BirthSignThief => ModKey.MakeFormKey(0x1fd94);
            public static FormKey BirthSignMage => ModKey.MakeFormKey(0x1fd93);
            public static FormKey BirthSignLady => ModKey.MakeFormKey(0x1fd92);
            public static FormKey BirthSignApprentice => ModKey.MakeFormKey(0x1fd91);
        }
    }
}
