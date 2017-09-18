using UnityEngine;
using System.Collections;

public class pindah_scene : MonoBehaviour {

	// Use this for initialization
	public void pindahkescene (string pindahke){
		Application.LoadLevel (pindahke); 
	}
}
