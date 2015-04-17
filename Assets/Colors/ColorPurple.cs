using UnityEngine;
using System.Collections;

public class ColorPurple : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        renderer.material.color = new Color32(128,0,128,1);
	}
}
