using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/* This script changes the color of an object based on slider settings */
public class ColorChanger : MonoBehaviour {
    public ObjectToSpawn newColor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.renderer.material.color = new Color32(newColor.red, newColor.green, newColor.blue, 1);
	}
}
