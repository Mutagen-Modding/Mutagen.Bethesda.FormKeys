using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class VoiceType
        {
            private static FormLink<IVoiceTypeGetter> Construct(uint id) => new FormLink<IVoiceTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IVoiceTypeGetter> CrSeekerVoice => Construct(0x3d47e);
            public static FormLink<IVoiceTypeGetter> DLC2UniqueBardInstruments => Construct(0x3a4a0);
            public static FormLink<IVoiceTypeGetter> crAshSpawnVoice => Construct(0x31db8);
            public static FormLink<IVoiceTypeGetter> DLC2CrGiantVoiceKarstaag => Construct(0x28241);
            public static FormLink<IVoiceTypeGetter> DLC2CrBristlebackVoice => Construct(0x24c3e);
            public static FormLink<IVoiceTypeGetter> CrNetchVoice => Construct(0x24c31);
            public static FormLink<IVoiceTypeGetter> DLC2FemaleDarkElfCommoner => Construct(0x247e5);
            public static FormLink<IVoiceTypeGetter> DLC2MaleDarkElfCommoner => Construct(0x247e4);
            public static FormLink<IVoiceTypeGetter> DLC2MaleUniqueModyn => Construct(0x23ff6);
            public static FormLink<IVoiceTypeGetter> DLC2RieklingVoice => Construct(0x208dc);
            public static FormLink<IVoiceTypeGetter> CrFishmanVoice => Construct(0x20767);
            public static FormLink<IVoiceTypeGetter> CrScribVoice => Construct(0x1f17b);
            public static FormLink<IVoiceTypeGetter> DLC2MaleUniqueAdril => Construct(0x1846b);
            public static FormLink<IVoiceTypeGetter> DLC2MaleUniqueLleril => Construct(0x1846a);
            public static FormLink<IVoiceTypeGetter> DLC2MaleDarkElfCynical => Construct(0x18469);
            public static FormLink<IVoiceTypeGetter> DLC2FemaleUniqueFrea => Construct(0x17f80);
            public static FormLink<IVoiceTypeGetter> DLC2MaleUniqueStorn => Construct(0x17f7f);
            public static FormLink<IVoiceTypeGetter> DLC2MaleUniqueMiraak => Construct(0x17f7e);
            public static FormLink<IVoiceTypeGetter> DLC2MaleUniqueNeloth => Construct(0x1777b);
        }
    }
}
