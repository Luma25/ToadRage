#pragma strict

var waypoint : Transform[];
var speed : float = 50;
private var currentWaypoint : int = 0;
var loop : boolean = true;
var player : Transform;
private var character : CharacterController;	 

function Start ()
{
	character = GetComponent(CharacterController);
}	 
function Update () 
{
	if(currentWaypoint < waypoint.length)
	{
    	var target : Vector3 = waypoint[currentWaypoint].position;
    	target.y = transform.position.y; // keep waypoint at character's height
    	var moveDirection : Vector3 = target - transform.position;
    	if(moveDirection.magnitude < 1)
    	{
        	transform.position = target; // force character to waypoint position
        	currentWaypoint++;
    	}
    	else
    	{
        	transform.LookAt(target);
        	character.Move(moveDirection.normalized * speed * Time.deltaTime);
    	}
	}
	else
	{
    	if(loop)
    	{
        	currentWaypoint=0;
    	}
	}
}