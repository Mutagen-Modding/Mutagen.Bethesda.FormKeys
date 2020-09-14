namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey BattlehornWineBarrelE => ModKey.MakeFormKey(0xb60e);
            public static FormKey BattlehornWineBarrelF => ModKey.MakeFormKey(0xb60f);
            public static FormKey BattlehornWineBarrelG => ModKey.MakeFormKey(0xb610);
            public static FormKey BattlehornWineBarrelCheap => ModKey.MakeFormKey(0xb611);
            public static FormKey BattlehornWineBarrelMead => ModKey.MakeFormKey(0xb612);
            public static FormKey BattlehornCastlePortcullis01 => ModKey.MakeFormKey(0x10b3c);
            public static FormKey BattlehornSecretLever01 => ModKey.MakeFormKey(0x38b9);
            public static FormKey BattlehornSecretLever02 => ModKey.MakeFormKey(0x4de4);
            public static FormKey BattlehornNarrowSecretDoor01 => ModKey.MakeFormKey(0x6390);
            public static FormKey BattlehornForgottenSecretLever01 => ModKey.MakeFormKey(0x6392);
            public static FormKey BattlehornSecretLever03 => ModKey.MakeFormKey(0x6279);
            public static FormKey BattlehornDwemerForge => ModKey.MakeFormKey(0xa69f);
            public static FormKey BattlehornWineBarrelA => ModKey.MakeFormKey(0xb5fb);
            public static FormKey BattlehornWineBarrelB => ModKey.MakeFormKey(0xb60b);
            public static FormKey BattlehornWineBarrelC => ModKey.MakeFormKey(0xb60c);
            public static FormKey BattlehornWineBarrelD => ModKey.MakeFormKey(0xb60d);
        }
    }
}
