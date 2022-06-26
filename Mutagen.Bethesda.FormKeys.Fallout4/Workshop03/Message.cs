// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static class Message
    {
        private static FormLink<IMessageGetter> Construct(uint id) => new FormLink<IMessageGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMessageGetter> DLC06WorkshopBarberSurgeryMessage => Construct(0x2568);
        public static FormLink<IMessageGetter> DLC06MQ03OverseerExpelledConfirmation => Construct(0x1b43);
        public static FormLink<IMessageGetter> DLC06SecurityChiefName => Construct(0x1087);
        public static FormLink<IMessageGetter> DLC06JulianName => Construct(0x1084);
        public static FormLink<IMessageGetter> DLC06PrototypesUnlockedMessage => Construct(0x53db);
        public static FormLink<IMessageGetter> DLC06OverseerName => Construct(0x5142);
        public static FormLink<IMessageGetter> DLC06VaultWorkshopActivator04Name => Construct(0x50f3);
        public static FormLink<IMessageGetter> DLC06VaultWorkshopActivator03Name => Construct(0x50f2);
        public static FormLink<IMessageGetter> DLC06VaultWorkshopActivator02Name => Construct(0x4fc1);
        public static FormLink<IMessageGetter> DLC06VaultWorkshopRadioName => Construct(0x4fbf);
        public static FormLink<IMessageGetter> DLC06ClemName => Construct(0x49da);
        public static FormLink<IMessageGetter> DLC06WorkshopNeedControlBoardMessage => Construct(0x4970);
        public static FormLink<IMessageGetter> DLC06WorkshopInsertControlBoardMessage => Construct(0x496b);
        public static FormLink<IMessageGetter> DLC06TrackerMessageHide => Construct(0x3de6);
        public static FormLink<IMessageGetter> DLC06TrackerMessageShow => Construct(0x3de5);
    }
}
