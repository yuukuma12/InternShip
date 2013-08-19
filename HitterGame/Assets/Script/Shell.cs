using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {
	
	GameObject Cannon;
	GameObject CameraPos;
	float InitialVelocity;
	float CameraX;
	float CameraY,CameraZ;
	
	// Use this for initialization
	void Start () {
		Cannon = GameObject.Find("Cannon Base");
		CameraPos = GameObject.Find ("Main Camera");
		InitialVelocity = PowerBar.Power * 20.0f;
		CameraX = CameraPos.transform.position.x;
		CameraY = CameraPos.transform.position.y;
		CameraZ = CameraPos.transform.position.z;
		//初速度を与える
		this.rigidbody.velocity = Cannon.transform.up * InitialVelocity;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Object.Destroy(this.gameObject);
		}
		if(transform.position.x > CameraX)
			CameraPos.transform.position = new Vector3(transform.position.x,CameraY,CameraZ);
		
	}
}
