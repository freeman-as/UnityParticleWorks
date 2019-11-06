 using UnityEngine;
using System.Collections;

public class Button_EffectPlay2 : MonoBehaviour {
	
	public GameObject Normal;
	public GameObject Rare;
	public GameObject SuperRare;
	 
	void Start(){
		if(Normal != null){	Normal.active = true;}
		if(Rare != null){Rare.active =false;}
		if(SuperRare != null){SuperRare.active =false;}
	}

	void OnGUI () {
		if(Normal != null){
			if(GUI.Button(new Rect(20,40,80,20), " Normal")) {
				Normal.active = true;
				if(Rare != null){Rare.active =false;}
				if(SuperRare != null){SuperRare.active =false;}
			}
		}
		if(Rare != null){
			if(GUI.Button(new Rect(20,70,80,20), " Rare")) {
				if(Normal != null){	Normal.active = false;}
				Rare.active =true;
				if(SuperRare != null){SuperRare.active =false;}
			}
		}
		if(SuperRare != null){
			if(GUI.Button(new Rect(20,100,80,20), " SuperRare")) {
				if(Normal != null){	Normal.active = false;}
				if(Rare != null){Rare.active =false;}
				SuperRare.active = true;
			}
		}
		 
	}
}