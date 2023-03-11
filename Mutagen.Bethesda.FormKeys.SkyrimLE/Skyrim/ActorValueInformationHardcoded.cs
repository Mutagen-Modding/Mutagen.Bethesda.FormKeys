using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Skyrim
{
    public static partial class ActorValueInformation
    {
        public static FormLink<IActorValueInformationGetter> AVVoicePoints => Construct(0x3F5);
        public static FormLink<IActorValueInformationGetter> AVWaterBreathing => Construct(0x5E0);
        public static FormLink<IActorValueInformationGetter> AVWaterWalking => Construct(0x5E1);
        public static FormLink<IActorValueInformationGetter> AVWardPower => Construct(0x5E6);
        public static FormLink<IActorValueInformationGetter> AVWardDeflection => Construct(0x5EA);
        public static FormLink<IActorValueInformationGetter> AVVariable04 => Construct(0x5EE);
        public static FormLink<IActorValueInformationGetter> AVVariable05 => Construct(0x5EF);
        public static FormLink<IActorValueInformationGetter> AVWeaponSpeedMult => Construct(0x5FC);
        public static FormLink<IActorValueInformationGetter> AVSmithingMod => Construct(0x60B);
        public static FormLink<IActorValueInformationGetter> AVTwoHandedPowerMod => Construct(0x62F);
        public static FormLink<IActorValueInformationGetter> AVDestructionPowerMod => Construct(0x63C);
        public static FormLink<IActorValueInformationGetter> AVStaminaRateMult => Construct(0x644);
        public static FormLink<IActorValueInformationGetter> AVGrabActorOffset => Construct(0x647);
        public static FormLink<IActorValueInformationGetter> AVGrabbed => Construct(0x648);
        public static FormLink<IActorValueInformationGetter> AVDEPRECIATED05 => Construct(0x649);
    }
}