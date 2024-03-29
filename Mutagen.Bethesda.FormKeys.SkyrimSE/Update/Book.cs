// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Update
{
    public static partial class Book
    {
        private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IBookGetter> Book3ValuableTamrielicLoreRevised => Construct(0x30d2);
    }
}
