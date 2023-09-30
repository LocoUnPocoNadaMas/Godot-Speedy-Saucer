using Godot;

namespace SpeedySaucer.scripts;

public partial class Player : RigidBody2D
{
	private const int Force = 1000;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//ApplyImpulse(new Vector2(25,-10));
	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//GD.Print(Engine.GetFramesPerSecond());
		//ApplyForce(new Vector2(25,0));
	}

	public override void _PhysicsProcess(double delta)
	{
		if(Input.IsActionPressed("Move_Left"))
			ApplyForce(new Vector2(-Force,0));
		if(Input.IsActionPressed("Move_Right"))
			ApplyForce(new Vector2(Force,0));
		if(Input.IsActionPressed("Move_Up"))
			ApplyForce(new Vector2(0,-Force));
		if(Input.IsActionPressed("Move_Down"))
			ApplyForce(new Vector2(0,Force));
		
	}
}
