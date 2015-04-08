using UnityEngine;
using System.Collections;
using Leap;

// Leap Motion hand script that detects shape gestures and spawns the appropriate GameObject
class SpawningHand : MonoBehaviour
{
    public GameObject spawnCube;
    private Controller controller;
    private Frame frame;

    void Start()
    {
        controller = new Controller();
        if (controller == null)
        {
            Debug.LogWarning("Cannot connect to controller. Make sure you have Leap Motion v2.0+ installed.");
        }
        else
        {
            controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
        }
        
    }

    void Update()
    {
        frame = controller.Frame();
        if (frame.Gestures().Count > 0) {
            foreach (Gesture gesture in frame.Gestures())
            {
                switch (gesture.Type)
                {
                    case(Gesture.GestureType.TYPE_CIRCLE):
                    {
                        Debug.Log("Got a circle gesture!");
                        Instantiate(spawnCube);
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
        }
    }
}