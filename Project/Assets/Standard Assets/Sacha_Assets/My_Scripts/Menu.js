

function Start () {
this.guiText.enabled = false;
}

function Update () {
	if (Input.GetKeyDown(KeyCode.Escape) && this.guiText.enabled == false)
	{
		this.guiText.enabled = true;
		Time.timeScale = 0;
		GameObject.Find("ALL").GetComponent("Move").work = 0;
	}
	else if (Input.GetKeyDown(KeyCode.Escape) && this.guiText.enabled == true)
	{
		this.guiText.enabled = false;
		Time.timeScale = 1;
		GameObject.Find("ALL").GetComponent("Move").work = 1;
	}
}

function OnMouseEnter()
{
	this.guiText.color = Color.green;
}

function OnMouseExit()
{
	this.guiText.color = Color.white;
}

function OnMouseUp()
{
	if (this.guiText.text == "Restart")
		{
			Time.timeScale = 1;
			Application.LoadLevel(Application.loadedLevel);
		}
	else if (this.guiText.text == "Exit")
		{
			Time.timeScale = 1;
			Application.LoadLevel("StartMenu");
		}
}