using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class DialogView
        {
            private static FormLink<IDialogViewGetter> Construct(uint id) => new FormLink<IDialogViewGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogViewGetter> PetFramework_DialogView => Construct(0x2f24);
        }
    }
}
