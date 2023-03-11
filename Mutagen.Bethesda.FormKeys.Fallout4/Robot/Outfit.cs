// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class Outfit
    {
        private static FormLink<IOutfitGetter> Construct(uint id) => new FormLink<IOutfitGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IOutfitGetter> DLC01Caravan_ShadesOutfit => Construct(0xff07);
        public static FormLink<IOutfitGetter> DLC01Caravan_LizaOutfit => Construct(0xff05);
        public static FormLink<IOutfitGetter> DLC01Caravan_ZoeOutfit => Construct(0xff02);
        public static FormLink<IOutfitGetter> DLC01Caravan_JacksonOutfit => Construct(0xfeff);
        public static FormLink<IOutfitGetter> DLC01MechanistOutfitJumpsuit => Construct(0xebb9);
        public static FormLink<IOutfitGetter> DLC01MechanistOutfitArmor => Construct(0xebb8);
        public static FormLink<IOutfitGetter> DLC01Outfit_BotRaider => Construct(0x863d);
    }
}