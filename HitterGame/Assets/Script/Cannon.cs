using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	
	public float CameraX;	
	GameObject CameraPos;
	
	// Use this for initialization
	void Start () {
		CameraPos = GameObject.Find ("Main Camera");
		CameraX = CameraPos.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow) && transform.rotation.z >= 0){
			transform.Rotate (0,0,1);
		}
		if(Input.GetKey (KeyCode.DownArrow) && transform.rotation.z <= 0.75){
			transform.Rotate (0,0,-1);
		}
		if(Input.GetKey (KeyCode.RightArrow)){
			if(CameraPos.transform.position.x <= 25){
				CameraPos.transform.position += new Vector3(0.5f,0f,0f);
			}
		}else if(CameraPos.transform.position.x > CameraX){
			CameraPos.transform.position -= new Vector3(1.0f,0f,0f);
		}
	}
}
