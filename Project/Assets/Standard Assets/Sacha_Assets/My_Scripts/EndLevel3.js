
function Start()
{
	Debug.Log(PlayerPrefs.GetFloat("Level 3"));
}

function Update () {
	var child = GameObject.Find("Step1");
	var child2 = GameObject.Find("Step2");
	var child3 = GameObject.Find("Step3");
	var child4 = GameObject.Find("Step4");
	var timer : float;

	if (child.renderer.material.color == Color.green && child2.renderer.material.color == Color.green && child3.renderer.material.color == Color.green && child4.renderer.material.color == Color.green)
	{
		if (PlayerPrefs.GetFloat("Level 3") == 0 || PlayerPrefs.GetFloat("Level 3") > GameObject.Find("Timer").GetComponent("Timer").timer)
			PlayerPrefs.SetFloat("Level 3", GameObject.Find("Timer").GetComponent("Timer").timer);
		Application.LoadLevel("Level 4");
	}
}