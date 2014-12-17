
function	Start()
{
	if (PlayerPrefs.GetFloat(this.name) != 0)
		this.guiText.text += " " + PlayerPrefs.GetFloat(this.name);
	else
		this.guiText.text += " Not Done";
}