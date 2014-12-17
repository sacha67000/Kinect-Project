using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	public GameObject player;
	private Vector3	offset;

	// Use this for initialization
	void Start ()
	{
		offset = transform.position;
	}

	void LateUpdate () 
	{
		float px = player.transform.position.x + offset.x;  
		float py = player.transform.position.y + offset.y;
		float pz = player.transform.position.z + offset.z;
		transform.position = new Vector3 (px, py, pz);
	//	transform.position = player.transform.position + offset;
	}
}
