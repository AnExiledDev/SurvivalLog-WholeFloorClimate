# Whole Floor Climate

Heaters and AC units warm the whole house, not just the room they stand in.

In Survival Log a heater only warms the zone it is placed in, so the Indoor zone and the Sunroom each need their own. Whole Floor Climate pools the device heat of the zones you choose. By default the Indoor zone and the Sunroom share their heat; the Terrace and the Basement can join by config.

## Features

- **Shared device heat**: every zone in the pool counts the heat of the running heat devices (AC units, heaters, stoves) in every pool zone. A heater in the Sunroom warms the Indoor zone as much as the Sunroom, and the other way round.
- **Indoor and Sunroom pooled by default**: turn it off in the config to go back to the game's per-zone heat.
- **Terrace, optional**: the game gives the Terrace no device heat at all. When it joins, it gets the whole pool's device heat, and heaters on the Terrace warm the rest of the pool.
- **Basement, optional**: when it joins, its devices warm the pool and the pool's devices warm the Basement.
- **No double counting**: each device counts once per zone. An AC indoors and a heater in the Sunroom give both zones the AC plus the heater, never either one twice. Moving a device from one pool zone to another changes no temperature.
- **Cold storage left alone**: cold storage never joins. Its devices never warm the pool, and the pool never warms it.
- **Shared AC power**: an AC running in one pool zone counts as a powered AC in every pool zone, so the game's "AC powered in your room" check and the thermal display agree with the pooled temperature.
- **Everything sees the pooled number**: the thermal display, how comfortable your character feels, the warm-room checks and plants all use the pooled temperature.
- **Game rules still apply**: talent bonuses and the game's room temperature cap still apply in the game's own order, because the mod adds its heat inside the game's own device heat sum.
- **Log file**: the mod writes the pool it built, the first temperature it changed, and any failure to `BepInEx\whole-floor-climate.log`.

Whole Floor Climate adds no data of its own to your save, and you can remove it at any time. After removal every zone goes back to the game's own heat at once. Anything earned while it was on stays in your save: warm-room progress, "all rooms warm" progress and plant growth that happened because the house was warmer.

With every option turned off the mod hooks nothing and every number is the game's own.

## How it works

The Indoor zone anchors the pool, and each setting adds its zone. So `IndoorAndSunroom = false` with `Basement = true` pools Indoor with the Basement, and the Sunroom keeps its own heat.

When the game adds up the heat of the running devices in a zone, the mod adds the heat of the running devices in the other pool zones to that sum. The game then applies talents and its room temperature cap as normal.

The greenhouse on the terrace already counts as the Sunroom in the game, so it pools with the Sunroom setting, not the Terrace one.

## Known issues and limits

This mod changes temperatures, which feed into comfort, plants and the warm-room goals. Back up your save before trying it for the first time.

- Rooms warm up more easily, so the warm-room tags and "all rooms warm" progress are easier to reach. That is the point of the mod, but it does make the game easier.
- If the game counts the Terrace as outdoors, it never reports an AC standing on the Terrace as powered. That AC then does not count toward the pool's "AC powered" check, although its heat still pools.
- The thermal display still marks the Terrace as a zone without device heat, even when it is pooled and its temperature includes the pool's heat.
- The game caps room temperature only for zones it warms with devices itself. A pooled Terrace is not capped, the same as in the game.
- If one of the mod's hooks fails, the game's own numbers stand for that check and the log says so once.

If temperatures look wrong, a zone does not warm up, or something else feels off, please tell me (see [Feedback](#feedback-and-bug-reports)).

## Requirements

- Survival Log 1.1.18902. Built and tested on this version; a game update can break it until the mod is updated.
- The [BepInEx Pack for Survival Log](https://www.nexusmods.com/survivallog/mods/12), the BepInEx 6 (IL2CPP) build for the game.

## Install

1. Install the [BepInEx Pack for Survival Log](https://www.nexusmods.com/survivallog/mods/12) (if no other mods were installed before, start the game once so BepInEx finishes setup, then quit).
2. Download `WholeFloorClimate-x.y.z.zip` from the [latest release](https://github.com/AnExiledDev/SurvivalLog-WholeFloorClimate/releases/latest) or from Nexus Mods.
3. Extract the zip into the game folder (the folder with `SurvivalLog.exe`). It holds a `BepInEx` folder, so the DLL lands in the right place. When asked, merge the folders. The result should be:
   `C:\Program Files (x86)\Steam\steamapps\common\Survival Log\BepInEx\plugins\WholeFloorClimate.dll`

## Uninstall

Delete `WholeFloorClimate.dll` from the `BepInEx\plugins` folder. For a clean slate, also delete `BepInEx\config\com.dev.survivallog.wholefloorclimate.cfg` and `BepInEx\whole-floor-climate.log`.

## Configuration

Settings live in `BepInEx\config\com.dev.survivallog.wholefloorclimate.cfg`, created the first time the game starts with the mod. Edit it while the game is closed; changes apply at the next game start. Each setting in the cfg file is explained in English and Simplified Chinese. See [CONFIG.md](CONFIG.md) for every setting.

## Troubleshooting

Tested on Survival Log 1.1.18902 with BepInEx `6.0.0-be.788`.

Check `BepInEx\LogOutput.log` for a line like `===== Whole Floor Climate 0.1.1 started: Indoor and Sunroom on, Terrace off, Basement off`, followed by `device heat is shared by ...` naming the pooled zones. The same lines are in `BepInEx\whole-floor-climate.log`, which survives restarts and trims itself past 1 MB. A line starting `could not hook` means part of the mod is off and the game's own numbers are used there.

## Feedback and bug reports

Found a bug, have an idea, or something feels off? Come say so on the Core Directive Discord: https://discord.gg/trTsyxUFqg . You can also leave a comment on the Nexus page or [open an issue](https://github.com/AnExiledDev/SurvivalLog-WholeFloorClimate/issues). When reporting a bug, attach `BepInEx\LogOutput.log` and `BepInEx\whole-floor-climate.log`.

## Build

This is a BepInEx 6 IL2CPP plugin. It compiles against BepInEx and the game's IL2CPP interop assemblies, so a game install with BepInEx set up and started once is required. Those assemblies come from the game and are not part of this repo. The .NET 8 SDK is required.

```
dotnet build src/WholeFloorClimate -c Release -p:GameDir="C:\path\to\Survival Log"
```

`GameDir` is the game folder. The default in the project file is a local path you will almost certainly need to override. The output DLL is at `src\WholeFloorClimate\bin\Release\WholeFloorClimate.dll`.

The unit tests cover the pooling rules and need nothing from the game:

```
dotnet test tests/WholeFloorClimate.Tests
```

## License

MIT. Copyright (c) 2026 AnExiledDev. See [LICENSE](LICENSE).
