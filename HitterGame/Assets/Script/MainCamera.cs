using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	
	public float ShellPos;
	public float CameraX;
	public float CameraY;
	public float CameraZ;
	
	
	// Use this for initialization
	void Start () {
		CameraX = transform.position.x;
		CameraY = transform.position.y;
		CameraZ = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		//発弾前の移動処理
		if(Launcher.exi == false){
			if(Input.GetKey (KeyCode.RightArrow)){
				if(transform.position.x <= 25){
					transform.position += new Vector3(0.25f,0f,0f);
				}
			}else if(transform.position.x > CameraX){
				transform.position -= new Vector3(1.0f,0f,0f);
			}
		}
	}
}
