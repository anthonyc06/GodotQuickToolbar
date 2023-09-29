#if TOOLS
using Godot;
using System;

[Tool]
public partial class QuickToolbar : EditorPlugin
{
	Control dock;
	
	public override void _EnterTree()
	{
		dock = (Control)GD.Load<PackedScene>("addons/quick_toolbar/Toolbar_dock.tscn").Instantiate();
		AddControlToDock(DockSlot.LeftUl, dock);
	}

	public override void _ExitTree()
	{
		RemoveControlFromDocks(dock);
		dock.Free();
	}
}
#endif
