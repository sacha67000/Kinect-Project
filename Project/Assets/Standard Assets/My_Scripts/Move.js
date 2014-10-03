#pragma strict

function Update () {

if (Input.GetButton("Down") && this.transform.rotation.x > -0.40)
	{
		this.transform.rotation.x = this.transform.rotation.x - 0.01;
	}
if (Input.GetButton("Up") && this.transform.rotation.x < 0.40)
	{
		this.transform.rotation.x = this.transform.rotation.x + 0.01;
	}
if (Input.GetButton("Left") && this.transform.rotation.z < 0.40)
	{
		this.transform.rotation.z = this.transform.rotation.z + 0.01;
	}
if (Input.GetButton("Right") && this.transform.rotation.z > -0.40)
	{
		this.transform.rotation.z = this.transform.rotation.z - 0.01;
	}
}