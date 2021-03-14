using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Sound
        {
            private static FormLink<ISoundGetter> Construct(uint id) => new FormLink<ISoundGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundGetter> NPCHorseFootArmor => Construct(0x91ec);
        }
    }
}
