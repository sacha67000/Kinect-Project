function OnTriggerEnter (other : Collider)
{


	if (this.transform.parent.name == "key1")
	{
		Destroy(GameObject.Find("Door1"));
		Destroy(this.transform.parent.gameObject);
	}
	else if (this.transform.parent.name == "key2" || this.transform.parent.name == "key3")
	{
		if (GameObject.Find("key3") == null || GameObject.Find("key2") == null)
			Destroy(GameObject.Find("Door2"));
		Destroy(this.transform.parent.gameObject);		
	}
	else if (this.transform.parent.name == "key5")
	{
		Destroy(GameObject.Find("Door4"));
		Destroy(this.transform.parent.gameObject);
	}
	else if (this.transform.parent.name == "key6")
	{
		Destroy(GameObject.Find("Door3"));
		Destroy(this.transform.parent.gameObject);
	}
	else if (this.transform.parent.name == "key4")
	{
		Destroy(GameObject.Find("Door5"));
		Destroy(this.transform.parent.gameObject);
	}
}