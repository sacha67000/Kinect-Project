private var red : float;
private var green : float;
private var blue : float;
private var speed : float;
private var flame : GameObject;
var fireSound : AudioClip;
audio.clip = fireSound;
private var check = 0;

function Start () {
	flame = GameObject.Find("Flame");
	flame.SetActive(false);
}

function Update () {
	speed = (Mathf.Abs(this.rigidbody.velocity.x) + Mathf.Abs(this.rigidbody.velocity.z)) * 50;
	if (speed > 255)
		{
			flame.SetActive(true);
			if (check == 0)
			{
				audio.Play();
				check = 1;
			}
			blue = 0 / 255.0;
			speed -= 255;
		}
	else
		{
			flame.SetActive(false);
			if (check == 1)
			{
				audio.Stop();
				check = 0;
			}
			blue = (255.0 - speed) / 255.0;
			speed = 0;
		}
	if (speed > 255)
		{
			green = 0 / 255.0;
			speed -= 255;
		}
	else
		{
			green = (255.0 - speed) / 255.0;
			speed = 0;		
		}
	red = 255.0 / 255.0;
	this.renderer.material.color = Color(red, green, blue);
}