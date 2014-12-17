#pragma strict

function Update () {
if (this.transform.position.y < -100)
	Application.LoadLevel(Application.loadedLevel);
}