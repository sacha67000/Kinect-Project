using UnityEngine;
using System.Collections;
using Leap;

public class MOVE : MonoBehaviour {

	//	SampleListener listenerSubclass;
	Controller leapController;
	Vector3 rot_hand;
	// Use this for initialization
	void Start () {
	//	SampleListener listenerSubclass = new SampleListener();
		leapController = new Controller();
	
	}

	// Update is called once per frame
	void Update ()
	{
		if(leapController.IsConnected) //controller is a Controller object
		{
			Frame frame = leapController.Frame(); //The latest frame
			Frame previous = leapController.Frame(1); //The previous frame
			rot_hand.x = 180 * frame.RotationAngle(previous, Vector.XAxis) / Mathf.PI * 100;
			rot_hand.y = 0;
			rot_hand.z = -1 * 180 * frame.RotationAngle(previous, Vector.ZAxis) / Mathf.PI * 100;
		}
		transform.Rotate(rot_hand, 10.0f * Time.deltaTime);
	}
}
