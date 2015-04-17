using UnityEngine;
using System.Collections;

public class ColorBlue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        renderer.material.color = new Color32(0,0,255,1);
	}
}
