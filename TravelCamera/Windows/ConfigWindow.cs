using System;
using System.Numerics;
using Dalamud.Interface.Windowing;
using ImGuiNET;

using System;
using System.Collections.Generic;
using System.Numerics;
using Dalamud.Game.ClientState.Conditions;
using Dalamud.Interface.Internal.Notifications;
using FFXIVClientStructs.FFXIV.Component.GUI;
using Ktisis;
using ImGuiNET;

namespace TravelCamera.Windows;

public class ConfigWindow : Window, IDisposable
{
    private Configuration Configuration;

    private static GameCamera* gameCamera;

    public ConfigWindow(Plugin plugin) : base(
        "TCam Config",
        ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoScrollbar |
        ImGuiWindowFlags.NoScrollWithMouse)
    {
        this.Size = new Vector2(232, 200);
        this.SizeCondition = ImGuiCond.Always;

        this.Configuration = plugin.Configuration;

        //ImGui.Text($"The camera is {Convert.ToString(this.Configuration.Point1SinglePath)}");
        
    }

    public void Dispose() { }

    public override void Draw()
    {
        /* can't ref a property, so use a local copy
        var configValue = this.Configuration.SomePropertyToBeSavedAndWithADefault;
        if (ImGui.Checkbox("Random Config Bool", ref configValue))
        {
            this.Configuration.SomePropertyToBeSavedAndWithADefault = configValue;
            // can save immediately on change, if you don't want to provide a "Save and Close" button
            this.Configuration.Save();
        }*/
    
        if (ImGui.Button(label: "Point 1"))
        {
            var currentCamera = FFXIVClientStructs.FFXIV.Client.UI.;
            
            Configuration.Point1SinglePath = currentCamera;
            Configuration.Save();

            
        }
        ImGui.Text($"X: {this.Configuration.Point1SinglePath.LookAtVector.X}");
        ImGui.Text($"Y: {this.Configuration.Point1SinglePath.LookAtVector.Y}");
        ImGui.Text($"Z: {this.Configuration.Point1SinglePath.LookAtVector.Z}");
        

        if (ImGui.Button(label: "Test-GotoP1"))
        {
            
        }
    }
}
