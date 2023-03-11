// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static class Quest
    {
        private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IQuestGetter> DLC02WorkshopAttackStarter => Construct(0x822);
        public static FormLink<IQuestGetter> DLC02WorkshopMirelurkAttack01 => Construct(0x829);
        public static FormLink<IQuestGetter> DLC02WorkshopDogAttack01 => Construct(0x831);
        public static FormLink<IQuestGetter> DLC02WorkshopMoleratAttack01 => Construct(0x838);
        public static FormLink<IQuestGetter> DLC02WorkshopSummonedToRelax => Construct(0x83d);
        public static FormLink<IQuestGetter> DLC02WorkshopTameOff => Construct(0x84c);
        public static FormLink<IQuestGetter> DLC02WorkshopDeathclawAttack01 => Construct(0x895);
        public static FormLink<IQuestGetter> DLC02WorkshopGunnerAttack01 => Construct(0x896);
        public static FormLink<IQuestGetter> DLC02WorkshopRadscorpionAttack01 => Construct(0x897);
        public static FormLink<IQuestGetter> DLC02WorkshopSuperMutantAttack01 => Construct(0x898);
        public static FormLink<IQuestGetter> DLC02WorkshopForcedAttackAbsorber => Construct(0x89a);
        public static FormLink<IQuestGetter> DLC02WorkshopYaoGuaiAttack01 => Construct(0x90b);
        public static FormLink<IQuestGetter> DLC02WorkshopInsectAttack01 => Construct(0xcec);
        public static FormLink<IQuestGetter> DLC02WorkshopRaiderAttack01 => Construct(0xcee);
        public static FormLink<IQuestGetter> DLC02WorkshopFeralGhoulAttack01 => Construct(0xcfb);
    }
}