using System;
using UnityEngine;

public class Player : MonoBehaviour {

	public enum Facing { Up, Left, Down, Right }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetInput();
	}

	private void GetInput()
	{
		//Left/Right movement
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * Time.deltaTime;
			Debug.Log("X position= " + transform.position.x);

		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * Time.deltaTime;
			Debug.Log("X position= " + transform.position.x);
		}
		//Up/Down movement
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * Time.deltaTime;
			Debug.Log("Y position= " + transform.position.y);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * Time.deltaTime;
			Debug.Log("Y position= " + transform.position.y);
		}

	}
}
