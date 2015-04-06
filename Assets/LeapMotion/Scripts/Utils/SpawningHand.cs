using UnityEngine;
using System.Collections;
using Leap;

// Leap Motion hand script that detects shape gestures and spawns the appropriate GameObject
class SpawningHand : MonoBehaviour
{
    private Controller controller;
    private Frame frame;

    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
    }

    void Update()
    {
        frame = controller.Frame();
        foreach (Gesture gesture in frame.Gestures())
        {
            switch (gesture.Type)
            {
                case(Gesture.GestureType.TYPE_CIRCLE):
                { 
                    //Code
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