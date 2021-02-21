using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IAItemGetter> Construct(uint id) => new FormLink<IAItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAItemGetter> DLC06ChainmailBootsSilenced => Construct(0xbf5d);
            public static FormLink<IAItemGetter> DLC06ChainmailGauntletsSilenced => Construct(0xbf5e);
            public static FormLink<IAItemGetter> DLC06MithrilGauntletsBullseye => Construct(0xbf72);
            public static FormLink<IAItemGetter> DLC06LeatherGauntletsBullseye => Construct(0xbf74);
            public static FormLink<IAItemGetter> DLC06GlassGauntletsBullseye => Construct(0xbf75);
            public static FormLink<IAItemGetter> DLC06FurGauntletsBullseye => Construct(0xbf76);
            public static FormLink<IAItemGetter> DLC06ElvenGauntletsBullseye => Construct(0xbf77);
            public static FormLink<IAItemGetter> DLC06ChainmailGauntletsBullseye => Construct(0xbf78);
            public static FormLink<IAItemGetter> DLC06MithrilGauntletsSilenced => Construct(0xbf5f);
            public static FormLink<IAItemGetter> DLC06MithrilBootsSilenced => Construct(0xbf60);
            public static FormLink<IAItemGetter> DLC06GlassGauntletsSilenced => Construct(0xbf61);
            public static FormLink<IAItemGetter> DLC06GlassBootsSilenced => Construct(0xbf62);
            public static FormLink<IAItemGetter> DLC06ElvenGauntletsSilenced => Construct(0xbf63);
            public static FormLink<IAItemGetter> DLC06ElvenBootsSilenced => Construct(0xbf64);
            public static FormLink<IAItemGetter> DLC06LeatherBootsSilenced => Construct(0xbf65);
            public static FormLink<IAItemGetter> DLC06FurBootsSilenced => Construct(0xbf59);
            public static FormLink<IAItemGetter> DLC06FurGauntletsSilenced => Construct(0xbf5b);
            public static FormLink<IAItemGetter> DLC06LeatherGauntletsSilenced => Construct(0xbf5c);
            public static FormLink<IAItemGetter> DLC06ThievesDenCaptainsQtrUpgrade => Construct(0xbf4f);
            public static FormLink<IAItemGetter> DLC06ThievesDenSecurityUpgrade => Construct(0x6fe1);
            public static FormLink<IAItemGetter> DLC06ThievesDenFenceUpgrade => Construct(0x6fe2);
            public static FormLink<IAItemGetter> DLC06ThievesDenSupplierUpgrade => Construct(0x6fe3);
            public static FormLink<IAItemGetter> DLC06ThievesDenFletcherUpgrade => Construct(0x6fdf);
            public static FormLink<IAItemGetter> DLC06ThievesDenBook1 => Construct(0x13dc3);
            public static FormLink<IAItemGetter> DLC06ThievesDenBook2 => Construct(0x13dc4);
            public static FormLink<IAItemGetter> DLC06ThievesDenBook3 => Construct(0x13dc5);
            public static FormLink<IAItemGetter> DLC06ThievesDenBook4 => Construct(0x13dc6);
            public static FormLink<IAItemGetter> DLC06ThievesDenStealthUpgrade => Construct(0x6fe0);
            public static FormLink<IAItemGetter> DLC06Footpads01 => Construct(0x83af);
            public static FormLink<IAItemGetter> DLC06Footpads02 => Construct(0x83b1);
            public static FormLink<IAItemGetter> DLC06Footpads03 => Construct(0x83b2);
            public static FormLink<IAItemGetter> DLC06Footpads04 => Construct(0x83b3);
            public static FormLink<IAItemGetter> DLC06Footpads05 => Construct(0x83b4);
            public static FormLink<IAItemGetter> DLCConjuredLockpick => Construct(0xba5e);
            public static FormLink<IAItemGetter> WeapSteelCutlassMaster => Construct(0x11ae1);
            public static FormLink<IAItemGetter> WeapSteelCutlassSuperb => Construct(0x11ae2);
            public static FormLink<IAItemGetter> DLC06WeapTest => Construct(0x83a9);
            public static FormLink<IAItemGetter> DLC06EncArrow1Knockdown => Construct(0xba42);
            public static FormLink<IAItemGetter> DLC06EncArrow1DrFatigue => Construct(0xba51);
            public static FormLink<IAItemGetter> DLC06EncArrow2DrFatigue => Construct(0xba53);
            public static FormLink<IAItemGetter> DLC06EncArrow3DrFatigue => Construct(0xba54);
            public static FormLink<IAItemGetter> DLC06EncArrow1Light => Construct(0xba45);
            public static FormLink<IAItemGetter> DLC06EncArrow1Blindness => Construct(0xba44);
            public static FormLink<IAItemGetter> DLC06LockSolvent => Construct(0x79c9);
            public static FormLink<IAItemGetter> DLC06LockSolvent2 => Construct(0x79ca);
            public static FormLink<IAItemGetter> DLC06Nightmask1 => Construct(0x83aa);
            public static FormLink<IAItemGetter> DLC06Nightmask2 => Construct(0x83ab);
            public static FormLink<IAItemGetter> DLC06Nightmask3 => Construct(0x83ad);
            public static FormLink<IAItemGetter> DLC06LockSolvent3 => Construct(0x79cc);
            public static FormLink<IAItemGetter> DLC06VendorStealthGauntlets => Construct(0xbf66);
            public static FormLink<IAItemGetter> DLC06VendorSupplierPotions3 => Construct(0x83b7);
            public static FormLink<IAItemGetter> DLC06VendorSecurityPotions3 => Construct(0x7eb8);
            public static FormLink<IAItemGetter> DLC06VendorStealthBoots => Construct(0x7eb9);
            public static FormLink<IAItemGetter> DLC06VendorFletcherMagicArrows => Construct(0x7eba);
            public static FormLink<IAItemGetter> DLC06SkeletonWeapons => Construct(0x13dc2);
            public static FormLink<IAItemGetter> DLC06VendorSecurityScrolls1 => Construct(0x7ebb);
            public static FormLink<IAItemGetter> DLC06VendorSecurityScrolls5 => Construct(0x7ebc);
            public static FormLink<IAItemGetter> DLC06VendorSecurityScrolls2 => Construct(0x79c8);
            public static FormLink<IAItemGetter> DLC06VendorFletcher => Construct(0x79c2);
            public static FormLink<IAItemGetter> DLC06VendorSecurityScrolls3 => Construct(0x7eb6);
            public static FormLink<IAItemGetter> DLC06VendorSecurityScrolls4 => Construct(0x7eb7);
            public static FormLink<IAItemGetter> DLC06VendorSupplierPotions1 => Construct(0x83b5);
            public static FormLink<IAItemGetter> DLC06VendorSupplierPotions2 => Construct(0x83b6);
        }
    }
}
