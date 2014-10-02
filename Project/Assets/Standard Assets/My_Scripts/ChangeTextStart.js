#pragma strict

function Start () {
	this.guiText.pixelOffset = Vector2((Screen.width * 0.50) - 100, 10);
}

var couleurEntrer : Color = Color.green;
var couleurSortie : Color = Color.white;
var tailleEntrer : float = 80;
var tailleSortie : float = 70;

function OnMouseEnter() {
	guiText.material.color = couleurEntrer;
	guiText.fontSize = tailleEntrer;
}

function OnMouseExit() {
	guiText.material.color = couleurSortie;
	guiText.fontSize = tailleSortie;
}

function OnMouseUp() {
// Application.LoadLevel(levelSuivant);
}