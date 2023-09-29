using Godot;
using System;

[Tool]
public partial class ToolbarButton : Godot.TextureButton 
{
	public override void _EnterTree()
	{
		Pressed += CreateNode;
	}

	public void CreateNode()
	{
		var nodeToCreate = GetNodeByName(this.Name);
		
		GetTree().EditedSceneRoot.AddChild(nodeToCreate);
   
		nodeToCreate.Owner = GetTree().EditedSceneRoot;
	}
	
	public Node GetNodeByName(string btnName)
	{
		GD.Print(btnName);
		switch (btnName)
		{
			case "Sun": return new DirectionalLight3D(); break;
			case "Omnilight": return new OmniLight3D(); break;
			case "Spot": return new SpotLight3D(); break;
			case "Cam": return new Camera3D(); break;
			case "Env": return new WorldEnvironment(); break;
			case "Tim": return new Timer(); break;
			case "Char": return new CharacterBody3D(); break;
			case "Rigid": return new RigidBody3D(); break;
			case "Static": return new StaticBody3D(); break;
			case "Mes": return new MeshInstance3D(); break;
			case "Area": return new Area3D(); break;
			case "Audio": return new AudioStreamPlayer(); break;
			case "Collision": return new CollisionShape3D(); break;
			default: return new Node3D(); break;
		}
	}
	
}
