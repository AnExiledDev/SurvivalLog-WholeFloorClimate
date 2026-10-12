using System.IO;
using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using WholeFloorClimate.Adapters;
using WholeFloorClimate.Core;

namespace WholeFloorClimate;

[BepInPlugin(Guid, "Whole Floor Climate", Version)]
public sealed class Plugin : BasePlugin
{
    private const string Guid = "com.dev.survivallog.wholefloorclimate";
    private const string Version = "0.1.0";

    public override void Load()
    {
        var log = new ClimateLog(Log, Path.Combine(Paths.BepInExRootPath, "whole-floor-climate.log"));

        log.TrimIfLarge();

        var settings = new PoolSettings(
            Config.Bind("Pool", "IndoorAndSunroom", PoolSettings.Default.IndoorAndSunroom,
                "Running AC units, heaters and stoves in the Indoor zone or the Sunroom warm both. Off: each warms only its own zone, as in the game.").Value,
            Config.Bind("Pool", "Terrace", PoolSettings.Default.Terrace,
                "The Terrace joins Indoor's pool. The game gives the Terrace no device heat at all; on, it gets the whole pool's device heat, and devices on the Terrace warm the pool.").Value,
            Config.Bind("Pool", "Basement", PoolSettings.Default.Basement,
                "The Basement joins Indoor's pool: its devices warm the pool and the pool's devices warm the Basement. Off: the Basement keeps its own heat, as in the game.").Value);
        var climate = new PooledClimate(new HeatPool(settings), new GameClimate());

        log.Write($"===== Whole Floor Climate {Version} started: Indoor and Sunroom {OnOff(settings.IndoorAndSunroom)}, Terrace {OnOff(settings.Terrace)}, Basement {OnOff(settings.Basement)}");
        PoolPatches.Apply(new Harmony(Guid), climate, log.Write);
    }

    private static string OnOff(bool isOn) => isOn ? "on" : "off";
}
