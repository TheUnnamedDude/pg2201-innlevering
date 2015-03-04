using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour {

	public void MuteMusic(bool value) {
		GameObject.Find("Canvas").gameObject.GetComponent<AudioSource> ().mute = !value;
	}
	public void Volume(float value) {
		GameObject.Find("Canvas").gameObject.GetComponent<AudioSource> ().volume = value;
	}
	public void Exit(){
		Application.Quit ();
	}
	public void Action(int scene){
		Application.LoadLevel(scene);
	}
	public void MuteGameMusic(bool value) {
		GameObject.Find("EventSystem").gameObject.GetComponent<AudioSource>().mute = !value;
	}
	public void MuteEffects(bool value) {
		GameObject.Find("Sphere").gameObject.GetComponent<AudioSource>().mute = !value;
	}
}
