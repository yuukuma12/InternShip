using UnityEngine;
using System.Collections;

public class PowerBar : MonoBehaviour {
	
	public Texture2D bgImage;
	public Texture2D fgImage;
	public static float Power = 0.5f;
	bool flag = false;
	
	public GameObject Cannon;
	
	// Use this for initialization
	void Start () {
		Cannon = GameObject.Find("Cannon Base");
	}
	
	// Update is called once per frame
	void OnGUI () {
		if(Launcher.exi == false && Input.GetKey (KeyCode.Space)){
			//cannon.transform
			GUI.BeginGroup(new Rect(10,10,100,22));
			GUI.DrawTexture(new Rect(0,0,100,22),bgImage,ScaleMode.StretchToFill,true,10.0f);
			
			GUI.BeginGroup(new Rect(2,2,Power * 100,18));
			GUI.DrawTexture(new Rect(0,0,100,18),fgImage,ScaleMode.StretchToFill,true,10.0f);
			
			GUI.EndGroup();
			GUI.EndGroup();
		}
	}
	
	void Update () {
		if(Launcher.exi == false){
			if(Input.GetKeyDown(KeyCode.Space)){
				Power = 0.5f;
				flag = false;
			}
			if(Input.GetKey (KeyCode.Space)){
				if(flag == true){
					Power -= Time.deltaTime;
					if(Power < 0)
						flag = false;
				}
				else if(flag == false){
					Power += Time.deltaTime;
					if(Power > 1.0)
						flag = true;
				}
			}
		}
	}
	
}
