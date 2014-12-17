
function Start()
{
	Debug.Log(PlayerPrefs.GetFloat("Level 2"));
}

function My_Load()
{
	if (PlayerPrefs.GetFloat("Level 2") == 0 || PlayerPrefs.GetFloat("Level 2") > GameObject.Find("Timer").GetComponent("Timer").timer)
		PlayerPrefs.SetFloat("Level 2", GameObject.Find("Timer").GetComponent("Timer").timer);
	Application.LoadLevel("Level 3");
}

function Update ()
{
	if (this.renderer.material.color == Color.green)
	{
		My_Load();
	}
}

function OnTriggerEnter (other : Collider)
{
	this.renderer.material.color = Color.green;
}
