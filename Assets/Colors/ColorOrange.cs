using UnityEngine;
using System.Collections;

public class ColorOrange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        renderer.material.color = new Color32(255,165,0,1);
	}
}
