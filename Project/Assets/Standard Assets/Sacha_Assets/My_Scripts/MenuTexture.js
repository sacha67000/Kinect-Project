#pragma strict

function Start () {
this.guiTexture.enabled = false;
}

function Update () {
	if (Input.GetKeyDown(KeyCode.Escape) && this.guiTexture.enabled == false)
		this.guiTexture.enabled = true;
	else if (Input.GetKeyDown(KeyCode.Escape) && this.guiTexture.enabled == true)
		this.guiTexture.enabled = false;
}