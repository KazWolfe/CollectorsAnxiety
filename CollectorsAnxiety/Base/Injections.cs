﻿using Dalamud.Game;
using Dalamud.Game.ClientState.Objects;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace CollectorsAnxiety.Base; 


// We're ignoring CS8618 because if this *was* null, we'd have *really* big issues.
#pragma warning disable CS8618

// ReSharper disable UnusedAutoPropertyAccessor.Local - handled by injection

public class Injections {
    [PluginService] public static DalamudPluginInterface PluginInterface { get; private set; }
    [PluginService] public static IChatGui Chat { get; private set; }
    [PluginService] public static IClientState ClientState { get; private set; }
    [PluginService] public static ICommandManager CommandManager { get; private set; }
    [PluginService] public static ICondition Condition { get; private set; }
    [PluginService] public static IDataManager DataManager { get; private set; }
    [PluginService] public static IFramework Framework { get; private set; }
    [PluginService] public static IGameGui GameGui { get; private set; }
    [PluginService] public static IKeyState KeyState { get; private set; }
    [PluginService] public static ILibcFunction LibcFunction { get; private set; }
    [PluginService] public static IObjectTable Objects { get; private set; }
    [PluginService] public static ISigScanner SigScanner { get; private set; }
    [PluginService] public static ITargetManager TargetManager { get; private set; }
    [PluginService] public static IToastGui Toasts { get; private set; }
    [PluginService] public static IGameInteropProvider GameInteropProvider { get; private set; }
    [PluginService] public static IPluginLog PluginLog { get; private set; }
}