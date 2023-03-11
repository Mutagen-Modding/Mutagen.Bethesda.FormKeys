// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static class Armor
    {
        private static FormLink<IArmorGetter> Construct(uint id) => new FormLink<IArmorGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_Torso_SugarBombs => Construct(0xb6a);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_Torso_Abraxo => Construct(0xb69);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_LegRight_SugarBombs => Construct(0xb68);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_LegRight_Abraxo => Construct(0xb67);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_LegLeft_SugarBombs => Construct(0xb66);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_LegLeft_Abraxo => Construct(0xb65);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_Helmet_SugarBombs => Construct(0xb64);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_Helmet_Abraxo => Construct(0xb63);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_ArmRight_SugarBombs => Construct(0xb62);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_ArmRight_Abraxo => Construct(0xb61);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_ArmLeft_SugarBombs => Construct(0xb60);
        public static FormLink<IArmorGetter> DLC05_Armor_Power_T51_ArmLeft_Abraxo => Construct(0xb5f);
        public static FormLink<IArmorGetter> DLC05ArmorRackSkin => Construct(0x8ad);
    }
}