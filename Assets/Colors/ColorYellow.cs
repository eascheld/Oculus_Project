using UnityEngine;
using System.Collections;

public class ColorYellow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        renderer.material.color = new Color32(255,255,0,1);
	}
}
