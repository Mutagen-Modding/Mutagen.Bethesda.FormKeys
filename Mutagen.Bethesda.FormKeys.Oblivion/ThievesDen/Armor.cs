using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Armor
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IArmorGetter> Construct(uint id) => new FormLink<IArmorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArmorGetter> DLC06ChainmailBootsSilenced => Construct(0xbf5d);
            public static FormLink<IArmorGetter> DLC06ChainmailGauntletsSilenced => Construct(0xbf5e);
            public static FormLink<IArmorGetter> DLC06MithrilGauntletsBullseye => Construct(0xbf72);
            public static FormLink<IArmorGetter> DLC06LeatherGauntletsBullseye => Construct(0xbf74);
            public static FormLink<IArmorGetter> DLC06GlassGauntletsBullseye => Construct(0xbf75);
            public static FormLink<IArmorGetter> DLC06FurGauntletsBullseye => Construct(0xbf76);
            public static FormLink<IArmorGetter> DLC06ElvenGauntletsBullseye => Construct(0xbf77);
            public static FormLink<IArmorGetter> DLC06ChainmailGauntletsBullseye => Construct(0xbf78);
            public static FormLink<IArmorGetter> DLC06MithrilGauntletsSilenced => Construct(0xbf5f);
            public static FormLink<IArmorGetter> DLC06MithrilBootsSilenced => Construct(0xbf60);
            public static FormLink<IArmorGetter> DLC06GlassGauntletsSilenced => Construct(0xbf61);
            public static FormLink<IArmorGetter> DLC06GlassBootsSilenced => Construct(0xbf62);
            public static FormLink<IArmorGetter> DLC06ElvenGauntletsSilenced => Construct(0xbf63);
            public static FormLink<IArmorGetter> DLC06ElvenBootsSilenced => Construct(0xbf64);
            public static FormLink<IArmorGetter> DLC06LeatherBootsSilenced => Construct(0xbf65);
            public static FormLink<IArmorGetter> DLC06FurBootsSilenced => Construct(0xbf59);
            public static FormLink<IArmorGetter> DLC06FurGauntletsSilenced => Construct(0xbf5b);
            public static FormLink<IArmorGetter> DLC06LeatherGauntletsSilenced => Construct(0xbf5c);
        }
    }
}
