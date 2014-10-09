#pragma strict

function Reload()
{
	yield WaitForSeconds(1);
	Application.LoadLevel(Application.loadedLevel);
}

function OnTriggerEnter (other : Collider)
{
	Reload();
}
