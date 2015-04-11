using UnityEngine;
using System.Collections;
using Leap;

// Leap Motion hand script that detects shape gestures and spawns the appropriate GameObject
class SpawningHand : HandController
{
    //public GameObject spawnCube;
    private Frame frame;
    private bool spawned;
    private int numSpawned = 0;

    void Start()
    {
        if (leap_controller_ == null)
        {
            Debug.LogWarning("Cannot connect to controller. Make sure you have Leap Motion v2.0+ installed.");
        }
        else
        {
            leap_controller_.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            leap_controller_.Config.SetFloat("Gesture.Circle.MinRadius", 10.0f);
            //leap_controller_.Config.SetFloat("Gesture.Circle.MinArc", 2.0f*Mathf.PI);
            leap_controller_.Config.Save();
        }
        
    }

    void Update()
    {
        if (leap_controller_ == null)
        {
            return;
        }

        frame = GetFrame();
        foreach (Gesture gesture in frame.Gestures())
        {
            switch (gesture.Type)
            {
                case(Gesture.GestureType.TYPE_CIRCLE):
                {
                    if (!spawned && numSpawned == 0)
                    {
                        Debug.Log("Got a circle gesture!");
                        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        numSpawned++;
                        //CircleGesture theCircle = new CircleGesture(frame.Gestures()[0]); // new CircleGesture();
                        //Leap.Vector v = theCircle.Center;
                        cube.transform.localScale = new Vector3(1, 1, 1);
                        cube.transform.position = new Vector3(0, 0.5f, 0);
                        cube.AddComponent<GrabbableObject>();
                        cube.AddComponent<Rigidbody>();
                        cube.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
                        cube.transform.renderer.materials[0].color = Color.blue;
                        spawned = true;
                        Debug.Log("Number Spawned: " + numSpawned);
                    }
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }

    void FixedUpdate()
    {
        //spawned = false;
    }
}