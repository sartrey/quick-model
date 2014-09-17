using UnityEngine;
using System.Collections;

public class SceneCamera : MonoBehaviour {

	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float MouseSenseX = 10F;
	public float MouseSenseY = 10F;
	
	public float MinX = -360F;
	public float MaxX = 360F;
	public float MinY = -60F;
	public float MaxY = 60F;

	public float HSpeed = 3;
	public float VSpeed = 6;

	float rotationY = 0F;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0))
			WatchSceneByMouse ();
		if (Input.GetMouseButton (1)) {
			WatchSceneByMouse ();
			float x = Input.GetAxis("Horizontal") * Time.deltaTime * HSpeed;
			float z = Input.GetAxis("Vertical") * Time.deltaTime * VSpeed;
			transform.Translate (x, 0, z);
		}
	}

	void WatchSceneByMouse() {
		if (axes == RotationAxes.MouseXAndY)
		{
			float rotationX = transform.localEulerAngles.y + 
				Input.GetAxis("Mouse X") * MouseSenseX;
			rotationY += Input.GetAxis("Mouse Y") * MouseSenseY;
			rotationY = Mathf.Clamp (rotationY, MinY, MaxY);
			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
		}
		else if (axes == RotationAxes.MouseX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * MouseSenseX, 0);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * MouseSenseY;
			rotationY = Mathf.Clamp (rotationY, MinY, MaxY);
			transform.localEulerAngles = 
				new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		}
	}
}