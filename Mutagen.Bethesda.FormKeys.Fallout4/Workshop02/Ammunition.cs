// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static class Ammunition
    {
        private static FormLink<IAmmunitionGetter> Construct(uint id) => new FormLink<IAmmunitionGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAmmunitionGetter> DLC05AmmoPaintballYellow => Construct(0xda0);
        public static FormLink<IAmmunitionGetter> DLC05AmmoPaintballWhite => Construct(0xd9f);
        public static FormLink<IAmmunitionGetter> DLC05AmmoPaintballRed => Construct(0xd9e);
        public static FormLink<IAmmunitionGetter> DLC05AmmoPaintballOrange => Construct(0xd9d);
        public static FormLink<IAmmunitionGetter> DLC05AmmoPaintballGreen => Construct(0xd9c);
        public static FormLink<IAmmunitionGetter> DLC05AmmoPaintballGlow => Construct(0xd9b);
        public static FormLink<IAmmunitionGetter> DLC05AmmoPaintballBlue => Construct(0xd91);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoPalmGold => Construct(0xd7e);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoPalmSilver => Construct(0xd7c);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoCrackle => Construct(0xd2e);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoPeonyPink => Construct(0xd2d);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoPeonyBlue => Construct(0xd2c);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoPeonyYellow => Construct(0xd2b);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoWeatherRain => Construct(0xa95);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoWeatherRadstorm => Construct(0xa94);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoWeatherClear => Construct(0xa93);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoPeonyRed => Construct(0xa92);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoPeonyGreen => Construct(0xa91);
        public static FormLink<IAmmunitionGetter> DLC05FireworkAmmoMinutemenFlare => Construct(0xa90);
    }
}
