using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/* DataBinder for the properties of the GameObject the user wants to spawn */
public class ObjectToSpawn : MonoBehaviour {
    //Setting Shape
    public Text shape;
    //Setting Color
    public Text redValue;
    public Text greenValue;
    public Text blueValue;
    protected internal byte red;
    protected internal byte green;
    protected internal byte blue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        red = byte.Parse(redValue.text);
        green = byte.Parse(greenValue.text);
        blue = byte.Parse(blueValue.text);
	}
}
