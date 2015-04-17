using UnityEngine;
using System.Collections;

public class ColorRed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        renderer.material.color = new Color32(255,0,0,1);
	}
}
