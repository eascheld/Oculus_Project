using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/* This script converts the location of the slider to an integer between 0 and 255 */
public class ConvertDots : MonoBehaviour {
    public Text dotValue;
    public Text convertedDotValue;
    private float dotFloat;
    private int dotInt;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        dotFloat = float.Parse(dotValue.text);
        dotFloat *= 255;
        dotInt = (int)dotFloat;
        convertedDotValue.text = dotInt.ToString();
	}
}
