// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static class AStoryManagerNode
    {
        private static FormLink<IAStoryManagerNodeGetter> Construct(uint id) => new FormLink<IAStoryManagerNodeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopCageAttacks => Construct(0xd16);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackNode => Construct(0x823);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackInsect => Construct(0xced);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackAbsorbEventNode => Construct(0x89b);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopTameOffNode => Construct(0x84d);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopRelaxAlarmNode => Construct(0x841);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackFeralGhoul => Construct(0x83b);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackDog => Construct(0x83a);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackMolerat => Construct(0x839);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackYaoGuai => Construct(0x82c);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackSuperMutant => Construct(0x82b);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackMirelurk => Construct(0x82a);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackRadscorpion => Construct(0x827);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackGunner => Construct(0x826);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackDeathclaw => Construct(0x825);
        public static FormLink<IAStoryManagerNodeGetter> DLC02WorkshopAttackRaider => Construct(0x824);
    }
}