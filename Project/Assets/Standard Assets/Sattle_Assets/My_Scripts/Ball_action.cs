using UnityEngine;
using System.Collections;

public class Ball_action : MonoBehaviour {

	public GameObject	wall;
	public GameObject	wall2;
	public GameObject	wall3;
	private int			count;
	private int			r;
	private	int			g;
	private	int			b;

	void Start()
	{
		r = 0;
		g = 0;
		b = 0;
		count = 0;
	}
	void OnTriggerEnter( Collider obj)
	{
		if (obj.gameObject.tag == "key1") 
		{
			obj.gameObject.SetActive(false);
			wall.gameObject.SetActive(false);
		}
		if (obj.gameObject.tag == "key2")
		{
			obj.gameObject.SetActive(false);
			count = count + 1;
			if (count == 2)
			{
				wall2.gameObject.SetActive(false);
			}
		}
		if (obj.gameObject.tag == "keyr") {
			r = 1;
			obj.gameObject.SetActive(false);
				}
		if (obj.gameObject.tag == "keyg" && r == 1) {
			g = 1;
			obj.gameObject.SetActive(false);
				}
		if (obj.gameObject.tag == "keyb" && r == 1 && g == 1) {
			b = 1;
			obj.gameObject.SetActive(false);
				}
		if (r == 1 && g == 1 && b == 1) {
			wall3.SetActiveRecursively(false);
				}
	}
}
