#pragma strict

var	speed : int;

function Update () {
	transform.Rotate(Vector3.right * Time.deltaTime * speed);
}