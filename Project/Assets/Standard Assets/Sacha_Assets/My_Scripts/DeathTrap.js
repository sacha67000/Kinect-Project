#pragma strict

function Wait()
{
	yield WaitForSeconds(1);
	Application.LoadLevel(Application.loadedLevel);
}

function OnTriggerEnter (other : Collider)
{
	Destroy(other.gameObject);
	this.renderer.enabled = false;
	Wait();
}