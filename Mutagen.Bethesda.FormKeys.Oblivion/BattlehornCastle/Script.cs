using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Script
        {
            private static FormLink<IScriptGetter> Construct(uint id) => new FormLink<IScriptGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScriptGetter> BattlehornBedroomAreaReceiptSCRIPT => Construct(0xb0a4);
            public static FormLink<IScriptGetter> BattlehornDiningAreaReceiptSCRIPT => Construct(0xb0a5);
            public static FormLink<IScriptGetter> BattlehornKitchenAreaReceiptSCRIPT => Construct(0xb0a6);
            public static FormLink<IScriptGetter> BattlehornTrainingRoomReceiptSCRIPT => Construct(0xb0a7);
            public static FormLink<IScriptGetter> BattlehornTrophyHallReceiptSCRIPT => Construct(0xb0a8);
            public static FormLink<IScriptGetter> BattlehornWineCellarReceiptSCRIPT => Construct(0xb0a9);
            public static FormLink<IScriptGetter> BattlehornBarracksReceiptSCRIPT => Construct(0xb0aa);
            public static FormLink<IScriptGetter> BattlehornForgeReceiptSCRIPT => Construct(0xb0ab);
            public static FormLink<IScriptGetter> BattlehornWineBarrelASCRIPT => Construct(0xb5f9);
            public static FormLink<IScriptGetter> BattlehornWineBarrelBSCRIPT => Construct(0xb605);
            public static FormLink<IScriptGetter> BattlehornWineBarrelCSCRIPT => Construct(0xb606);
            public static FormLink<IScriptGetter> BattlehornWineBarrelDSCRIPT => Construct(0xb607);
            public static FormLink<IScriptGetter> BattlehornWineBarrelESCRIPT => Construct(0xb608);
            public static FormLink<IScriptGetter> BattlehornWineBarrelFSCRIPT => Construct(0xb609);
            public static FormLink<IScriptGetter> BattlehornWineBarrelGSCRIPT => Construct(0xb60a);
            public static FormLink<IScriptGetter> BattlehornWineBarrelCheapSCRIPT => Construct(0xb613);
            public static FormLink<IScriptGetter> BattlehornWineBarrelMeadSCRIPT => Construct(0xb614);
            public static FormLink<IScriptGetter> BattlehornSecretDoorLever02REFSCRIPT => Construct(0x38bb);
            public static FormLink<IScriptGetter> BattlehornTrainerSCRIPT => Construct(0xc011);
            public static FormLink<IScriptGetter> BattlehornDwemerForgeScript => Construct(0xc511);
            public static FormLink<IScriptGetter> BattlehornTaxidermistSCRIPT => Construct(0xc53a);
            public static FormLink<IScriptGetter> BattlehornVintnerSCRIPT => Construct(0xca42);
            public static FormLink<IScriptGetter> BattlehornSecretDoorLever03REFSCRIPT => Construct(0x627b);
            public static FormLink<IScriptGetter> BattlehornMenAtArmsReceiptSCRIPT => Construct(0xd42a);
            public static FormLink<IScriptGetter> BattlehornCaptainSCRIPT => Construct(0xd42c);
            public static FormLink<IScriptGetter> BattlehornCaptainReceiptSCRIPT => Construct(0xd42f);
            public static FormLink<IScriptGetter> BattlehornForgottenSecretLever01REFSCRIPT => Construct(0x6393);
            public static FormLink<IScriptGetter> BattlehornKnightSCRIPT => Construct(0xd440);
            public static FormLink<IScriptGetter> BattlehornCastlePortcullis01SCRIPT => Construct(0x10b3d);
            public static FormLink<IScriptGetter> DLCBattlehornCastleScript => Construct(0xb08a);
            public static FormLink<IScriptGetter> BattlehornSecretDoorLever01REFSCRIPT => Construct(0x33d2);
            public static FormLink<IScriptGetter> DLCBattlehornMarauderSCRIPT => Construct(0x1342f);
            public static FormLink<IScriptGetter> DLCBattlehornDragonswordSCRIPT => Construct(0x147e8);
            public static FormLink<IScriptGetter> BattlehornArmorerBuffSCRIPT => Construct(0x1743e);
            public static FormLink<IScriptGetter> BattlehornLibraryReceiptSCRIPT => Construct(0xb0a3);
        }
    }
}
