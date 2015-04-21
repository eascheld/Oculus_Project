using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
