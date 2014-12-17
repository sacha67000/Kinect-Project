public var timer : float;
timer = 0;
function Update () {
	timer += Time.deltaTime;
	this.guiText.text = "Timer : " + timer;
}

