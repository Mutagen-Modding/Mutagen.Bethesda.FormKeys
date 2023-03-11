// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class ActorValueInformation
    {
        private static FormLink<IActorValueInformationGetter> Construct(uint id) => new FormLink<IActorValueInformationGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IActorValueInformationGetter> DLC01Bot_BurnDamage_AV => Construct(0x26b8);
        public static FormLink<IActorValueInformationGetter> DLC01Bot_BleedDamageUnstable_AV => Construct(0x1dc4);
        public static FormLink<IActorValueInformationGetter> DLC01Bot_Stagger_AV => Construct(0x12a3);
        public static FormLink<IActorValueInformationGetter> DLC01Bot_Knockdown_AV => Construct(0x129c);
        public static FormLink<IActorValueInformationGetter> DLC01Bot_EnergyDamage_AV => Construct(0x1292);
        public static FormLink<IActorValueInformationGetter> DLC01Bot_PoisonDamage_AV => Construct(0x1257);
        public static FormLink<IActorValueInformationGetter> DLC01Bot_RadsDamage_AV => Construct(0x1256);
        public static FormLink<IActorValueInformationGetter> DLC01Bot_BleedDamage_AV => Construct(0x1254);
        public static FormLink<IActorValueInformationGetter> DLC01WorkshopRatingWorkbenchRobot => Construct(0x10e2a);
        public static FormLink<IActorValueInformationGetter> DLC01RobotDefaultOff => Construct(0xf6d8);
        public static FormLink<IActorValueInformationGetter> DLC01_CompanionFailedToUnlock => Construct(0x8bf8);
        public static FormLink<IActorValueInformationGetter> DLC01_Ability_Lockpicking => Construct(0x8bf6);
        public static FormLink<IActorValueInformationGetter> DLC01_Ability_Hacking => Construct(0x8bf5);
        public static FormLink<IActorValueInformationGetter> DLC01PersonalityMode => Construct(0x77db);
        public static FormLink<IActorValueInformationGetter> DLC01_StagedInteraction => Construct(0x2747);
        public static FormLink<IActorValueInformationGetter> DLC01WorkshopResourceTargetActive => Construct(0x24ab);
        public static FormLink<IActorValueInformationGetter> DLC01TrackSystemDropoffPointBusy => Construct(0x21b7);
        public static FormLink<IActorValueInformationGetter> DLC01TrackSystemTrackID => Construct(0x21b6);
    }
}