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
    private const string Version = "0.1.1";

    public override void Load()
    {
        var log = new ClimateLog(Log, Path.Combine(Paths.BepInExRootPath, "whole-floor-climate.log"));

        log.TrimIfLarge();

        var settings = new PoolSettings(
            Config.Bind("Pool", "IndoorAndSunroom", PoolSettings.Default.IndoorAndSunroom,
                "Running AC units, heaters and stoves in the Indoor zone or the Sunroom warm both. Off: each warms only its own zone, as in the game.\n" +
                "室内或阳光房中运行的空调、电暖器和暖炉会同时温暖这两处。关闭后各自只温暖所在的区域，与游戏原本相同。").Value,
            Config.Bind("Pool", "Terrace", PoolSettings.Default.Terrace,
                "The Terrace joins Indoor's pool. The game gives the Terrace no device heat at all; on, it gets the whole pool's device heat, and devices on the Terrace warm the pool.\n" +
                "露台加入室内的共享范围。游戏本身不给露台任何设备热量；开启后露台获得整个共享范围的设备热量，露台上的设备也会温暖共享范围。").Value,
            Config.Bind("Pool", "Basement", PoolSettings.Default.Basement,
                "The Basement joins Indoor's pool: its devices warm the pool and the pool's devices warm the Basement. Off: the Basement keeps its own heat, as in the game.\n" +
                "地下室加入室内的共享范围：地下室的设备温暖共享范围，共享范围的设备也温暖地下室。关闭后地下室保持自己的热量，与游戏原本相同。").Value);
        var climate = new PooledClimate(new HeatPool(settings), new GameClimate());

        log.Write($"===== Whole Floor Climate {Version} started: Indoor and Sunroom {OnOff(settings.IndoorAndSunroom)}, Terrace {OnOff(settings.Terrace)}, Basement {OnOff(settings.Basement)}");
        PoolPatches.Apply(new Harmony(Guid), climate, log.Write);
    }

    private static string OnOff(bool isOn) => isOn ? "on" : "off";
}
