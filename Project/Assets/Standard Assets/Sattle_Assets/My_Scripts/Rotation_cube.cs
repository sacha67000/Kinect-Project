using UnityEngine;
using System.Collections;

public class Rotation_cube : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(new Vector3 (20, 25, 30) * Time.deltaTime * 2);
	}
}
