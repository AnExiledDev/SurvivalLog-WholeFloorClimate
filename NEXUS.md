Name: Whole Floor Climate
Summary: Heaters and AC units warm the whole house, not just the room they stand in. Indoor and the Sunroom share heat; the Terrace and the Basement can join. 电暖器和空调能温暖整个家，而不只是它们所在的房间。室内和阳光房共享热量，露台和地下室也可以加入。

Description (BBCode):
In the base game a heater only warms the room it stands in. Whole Floor Climate shares the heat between the rooms you choose, so one heater in the Sunroom also warms the Indoor zone.

[size=5]Main features[/size]
[list]
[*][b]Shared heat[/b]: heaters, AC units and stoves warm every room in the pool.[/*]
[*][b]Indoor and Sunroom[/b]: pooled by default.[/*]
[*][b]Terrace and Basement[/b]: can join the pool, each with its own setting.[/*]
[*][b]No double counting[/b]: each device counts once per room.[/*]
[*][b]Cold storage left alone[/b]: it never warms or gets warmed by the pool.[/*]
[*][b]Shared AC power[/b]: an AC running in one pooled room counts as powered in all of them.[/*]
[*][b]Game rules kept[/b]: talents and the room temperature cap still apply.[/*]
[/list]
The mod adds no data of its own to your save, and you can remove it at any time. After removal every room goes back to the game's own heat. Progress earned while it was on (warm-room goals, plant growth) stays in your save.

Works in English and Chinese.

[size=5]Known issues[/size]
[list]
[*]Back up your save before trying it for the first time.[/*]
[*]Rooms warm up more easily, so warm-room goals are easier to reach.[/*]
[*]The thermal display still shows the Terrace as a room without device heat, even when it is pooled.[/*]
[*]An AC standing on the Terrace may not count as powered for the rest of the pool. Its heat still counts.[/*]
[/list]
If you run into anything strange, please tell me (see Feedback below).

[size=5]Requirements[/size]
[list]
[*]Survival Log 1.1.18902. A game update can break it until the mod is updated.[/*]
[*][url=https://www.nexusmods.com/survivallog/mods/12]BepInEx for Survival Log[/url]. Install it first.[/*]
[/list]

[size=5]Installation[/size]
[list=1]
[*]Install [url=https://www.nexusmods.com/survivallog/mods/12]BepInEx[/url] [i](if no other mods were installed before, start the game once so BepInEx finishes setup, then quit)[/i].[/*]
[*]Put [font=Courier New]WholeFloorClimate.dll[/font] in the BepInEx&#92;plugins folder inside the game folder. Full path example:
[code]C:&#92;Program Files (x86)&#92;Steam&#92;steamapps&#92;common&#92;Survival Log&#92;BepInEx&#92;plugins&#92;WholeFloorClimate.dll[/code][/*]
[/list]

[size=5]Uninstall[/size]
Delete [font=Courier New]WholeFloorClimate.dll[/font] from the [font=Courier New]BepInEx&#92;plugins[/font] folder.

[size=5]Configuration[/size]
To choose which rooms share heat, edit [font=Courier New]BepInEx&#92;config&#92;com.dev.survivallog.wholefloorclimate.cfg[/font] while the game is closed (see [url=https://github.com/AnExiledDev/SurvivalLog-WholeFloorClimate/blob/main/CONFIG.md]CONFIG.md[/url] for every setting; the cfg file explains each setting in English and Chinese). Changes apply at the next game start.

[size=5]Feedback[/size]
Found a bug or have an idea? Come say hi on the [url=https://discord.gg/trTsyxUFqg]Core Directive Discord[/url], or leave a comment here. For bugs, please include [font=Courier New]BepInEx&#92;LogOutput.log[/font] and [font=Courier New]BepInEx&#92;whole-floor-climate.log[/font].

[size=5]Source and license[/size]
Open source under MIT: [url=https://github.com/AnExiledDev/SurvivalLog-WholeFloorClimate]github.com/AnExiledDev/SurvivalLog-WholeFloorClimate[/url]

[line]
[size=5]简体中文[/size]

游戏原本的电暖器只能温暖它所在的房间。Whole Floor Climate 让你选择的房间共享热量，所以阳光房里的一台电暖器也能温暖室内。

[size=5]主要功能[/size]
[list]
[*][b]共享热量[/b]：电暖器、空调和暖炉会温暖共享范围内的每个房间。[/*]
[*][b]室内和阳光房[/b]：默认共享。[/*]
[*][b]露台和地下室[/b]：可以加入共享，各有单独的设置。[/*]
[*][b]不会重复计算[/b]：每台设备在每个房间只算一次。[/*]
[*][b]冷库不受影响[/b]：冷库既不会温暖共享范围，也不会被它温暖。[/*]
[*][b]空调供电共享[/b]：在一个共享房间里运行的空调，在所有共享房间都算作已供电。[/*]
[*][b]保留游戏规则[/b]：天赋和房间温度上限依然有效。[/*]
[/list]
模组不会往存档里写入自己的数据，你可以随时移除它。移除后每个房间都会恢复游戏自己的热量。开启期间获得的进度（温暖房间目标、植物生长）会保留在存档中。

支持英文和中文。

[size=5]已知问题[/size]
[list]
[*]第一次使用前请备份存档。[/*]
[*]房间更容易变暖，所以温暖房间的目标更容易达成。[/*]
[*]即使露台加入了共享，温度显示仍然把露台当作没有设备热量的房间。[/*]
[*]放在露台上的空调可能不会让共享范围内的其他房间算作已供电，但它的热量依然算数。[/*]
[/list]
如果遇到任何奇怪的情况，请告诉我（见下方反馈）。

[size=5]前置要求[/size]
[list]
[*]Survival Log 1.1.18902。游戏更新后模组可能暂时失效，直到模组更新为止。[/*]
[*][url=https://www.nexusmods.com/survivallog/mods/12]BepInEx for Survival Log[/url]，请先安装。[/*]
[/list]

[size=5]安装[/size]
[list=1]
[*]安装 [url=https://www.nexusmods.com/survivallog/mods/12]BepInEx[/url] [i]（如果之前没有装过其他模组，先启动一次游戏，让 BepInEx 完成初始化，然后退出）[/i]。[/*]
[*]把 [font=Courier New]WholeFloorClimate.dll[/font] 放进游戏目录下的 BepInEx&#92;plugins 文件夹。完整路径示例：
[code]C:&#92;Program Files (x86)&#92;Steam&#92;steamapps&#92;common&#92;Survival Log&#92;BepInEx&#92;plugins&#92;WholeFloorClimate.dll[/code][/*]
[/list]

[size=5]卸载[/size]
从 [font=Courier New]BepInEx&#92;plugins[/font] 文件夹中删除 [font=Courier New]WholeFloorClimate.dll[/font]。

[size=5]配置[/size]
如需选择哪些房间共享热量，请在游戏关闭时编辑 [font=Courier New]BepInEx&#92;config&#92;com.dev.survivallog.wholefloorclimate.cfg[/font]。配置文件中每项设置都有中文说明，完整说明见 [url=https://github.com/AnExiledDev/SurvivalLog-WholeFloorClimate/blob/main/CONFIG.md]CONFIG.md[/url]（英文）。修改会在下次启动游戏时生效。

[size=5]反馈[/size]
发现 bug 或有好点子？欢迎来 [url=https://discord.gg/trTsyxUFqg]Core Directive Discord[/url] 打个招呼，或在这里留言。报告 bug 时，请附上 [font=Courier New]BepInEx&#92;LogOutput.log[/font] 和 [font=Courier New]BepInEx&#92;whole-floor-climate.log[/font]。

[size=5]源代码与许可[/size]
基于 MIT 许可开源：[url=https://github.com/AnExiledDev/SurvivalLog-WholeFloorClimate]github.com/AnExiledDev/SurvivalLog-WholeFloorClimate[/url]
