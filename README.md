# Mutagen.Bethesda.FormKeys

This project aims to replace "loose" FormIDs/FormKeys with strongly typed and highly readable alternatives.
- No more looking up FormIDs
- Clearer intent to code readers

For example:
```
cell.Water = FormKey.Factory("000018:Skyrim.esm");
```
Can be replaced with:
```
cell.Water = Skyrim.Water.DefaultWater;
```

These systems come with autocomplete intellisense and strong typing to a `FormKey`:

![](https://i.imgur.com/fH7YSEa.gif)

## Install
Just search for and add the `Mutagen.Bethesda.FormKeys.[Your Game]` nuget package from your IDE.

Add `using Mutagen.Bethesda.FormKeys.[Your Game];`

## Create Your Own Mappings
This project contains packages of mappings for all base games.  You can create similar mappings for any mod you wish, using the included command line executable tool.
```
Mutagen.Bethesda.FormKeys.Generator.exe generate -g SkyrimSE -p path/To/Your/Mod.esp
```

This should output a `.cs` file of all the located EDID -> FormKey mappings found in that mod.  You can then add that class to any project you wish to access the custom mappings from.
