#pragma strict

function OnTriggerEnter (other : Collider)
{
	this.renderer.material.color = Color.green;
}