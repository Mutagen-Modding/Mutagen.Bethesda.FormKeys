using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class Message
    {
        public static FormLink<IMessageGetter> HelpChargenTagSkills => Construct(0x176);
        public static FormLink<IMessageGetter> HelpDialogue => Construct(0x179);
    }
}