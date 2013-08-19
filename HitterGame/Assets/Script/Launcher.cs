using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {
	
	public GameObject Shell;
	public static bool exi = false;
	
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		//弾の生成
		if(Input.GetKeyUp(KeyCode.Space)){
			if(exi == false){
				Instantiate(Shell,transform.position,Quaternion.identity);
				exi = true;
			}else{
				exi = false;
			}
		}
	}
}
