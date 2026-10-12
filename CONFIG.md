# Whole Floor Climate settings

Settings live in `BepInEx\config\com.dev.survivallog.wholefloorclimate.cfg`, created the first time the game starts with the mod. Edit the file while the game is closed; changes apply at the next game start. Delete the file to get the defaults back.

## Pool

| Setting | Default | What it does |
| --- | --- | --- |
| `IndoorAndSunroom` | `true` | Running AC units, heaters and stoves in the Indoor zone or the Sunroom warm both. Off: each warms only its own zone, as in the game. |
| `Terrace` | `false` | The Terrace joins the Indoor zone's pool. The game gives the Terrace no device heat at all; on, it gets the whole pool's device heat, and devices on the Terrace warm the pool. |
| `Basement` | `false` | The Basement joins the Indoor zone's pool: its devices warm the pool and the pool's devices warm the Basement. Off: the Basement keeps its own heat, as in the game. |

The Indoor zone is always the anchor, and each setting adds its zone to it. Some examples:

- Defaults: Indoor and the Sunroom share heat. The Terrace and the Basement work as in the game.
- `IndoorAndSunroom = false`, `Basement = true`: Indoor and the Basement share heat. The Sunroom keeps its own.
- All three `false`: the mod changes nothing.

Cold storage never joins, whatever the settings.

The greenhouse on the terrace counts as the Sunroom in the game, so `IndoorAndSunroom` covers it, not `Terrace`.
