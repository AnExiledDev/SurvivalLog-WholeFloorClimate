# Whole Floor Climate

A BepInEx 6 (IL2CPP) plugin for Survival Log: AC units, heaters and other heat devices warm every zone you pool together, not only the zone they stand in. By default the Indoor zone and the Sunroom share their device heat; the Terrace and the Basement can join by config.

## What it does

- The game warms a zone with the heat of the running devices standing in it. With the mod, every zone in the pool counts the heat of the running devices in every pool zone. A heater in the Sunroom warms the Indoor zone as much as the Sunroom, and the other way round.
- Each device counts once per zone. An AC indoors and a heater in the Sunroom give both zones the AC plus the heater, never twice either one. Moving a device between pool zones changes no temperature.
- Indoor and the Sunroom pool by default. The Terrace and the Basement each join separately when you turn them on.
- The Terrace gets no device heat in the game at all. When it joins, it gets the whole pool's device heat, and heaters standing on the Terrace warm the rest of the pool.
- Cold storage never joins: its devices never warm the pool and the pool never warms it.
- Talent bonuses and the game's room temperature cap still apply in the game's own order, because the mod pools inside the game's device heat sum.
- Everything that reads a zone's temperature sees the pooled number: the thermal display, how comfortable your character feels, the warm-room checks, and plants.
- An AC running in one pool zone counts as a powered AC in every pool zone, so the game's "AC powered in your room" check and the thermal display agree with the pooled temperature. Cold storage never borrows or lends one.
- With every option off the mod hooks nothing and every number is the game's own.

## Config

`BepInEx/config/com.dev.survivallog.wholefloorclimate.cfg`:

| Setting | Default | What it does |
| --- | --- | --- |
| `Pool/IndoorAndSunroom` | `true` | Running devices in the Indoor zone or the Sunroom warm both. Off: each warms only its own zone, as in the game. |
| `Pool/Terrace` | `false` | The Terrace joins Indoor's pool: it gets the whole pool's device heat, and devices on the Terrace warm the pool. Off: the Terrace gets no device heat, as in the game. |
| `Pool/Basement` | `false` | The Basement joins Indoor's pool: its devices warm the pool and the pool's devices warm the Basement. Off: the Basement keeps its own heat, as in the game. |

Indoor anchors the pool and each setting adds its zone. So `IndoorAndSunroom = false` with `Basement = true` pools Indoor with the Basement, and the Sunroom keeps its own heat. Changes apply on the next game start.

Log: `BepInEx/whole-floor-climate.log`. It records the pool at start, the first time a temperature changes, and any failure, once.

## Known limits

- Not yet run in the game. The pooling rule is tested; the hooks are not.
- If the game counts the Terrace as outdoor, it never reports an AC standing on the Terrace as powered, so that AC does not count for the rest of the pool's AC check. Its heat still pools.
- Rooms warm up more easily, so the warm-room tags and "all rooms warm" progress are easier to reach.
- Removing the mod does not undo what it earned. Warm-room progress and plant growth gained while it was on stay in your save.
- The thermal display still marks the Terrace as a zone without device heat, even when it is pooled and its temperature includes the pool's heat.
- The game caps room temperature only for zones it warms with devices. A pooled Terrace is not capped, the same as the game leaves it.
- The greenhouse on the terrace already counts as the Sunroom in the game, so it pools with the Sunroom setting, not the Terrace one.
- If a hook fails, the game's own numbers stand and the log says so once.

## Install

Copy `WholeFloorClimate.dll` into `BepInEx/plugins`. Needs BepInEx 6 (IL2CPP build).

## Build and test

```sh
dotnet build src/WholeFloorClimate -c Release -p:GameDir="D:\path\to\Survival Log"
dotnet test tests/WholeFloorClimate.Tests
```

The build references BepInEx and the game's interop assemblies under `GameDir`, so BepInEx must be installed and the game launched once. The tests compile only the pure `Core` code and need nothing from the game.

## License

MIT, see [LICENSE](LICENSE).
