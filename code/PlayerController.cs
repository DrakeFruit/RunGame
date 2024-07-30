using Sandbox;

public sealed class PlayerController : Component
{
	[Property] List<GameObject> Points { get; set; }
	int currentPoint = 1;
	protected override void OnUpdate()
	{
		if(Input.Pressed("Left") && currentPoint != 0){
			currentPoint--;
		}else if(Input.Pressed("Right") && currentPoint != 2){
			currentPoint++;
		}

		Transform.Position = Transform.Position.LerpTo( Points[currentPoint].Transform.Position, 0.1f );
	}
}
