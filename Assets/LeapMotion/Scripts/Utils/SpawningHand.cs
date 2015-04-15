using UnityEngine;
using System.Collections;
using Leap;

// Leap Motion hand script that detects shape gestures and spawns the appropriate GameObject
class SpawningHand : HandController
{
    private Frame frame;
    public GameObject UICanvas;

    void Start()
    {
        if (leap_controller_ == null)
        {
            Debug.LogWarning("Cannot connect to controller. Make sure you have Leap Motion v2.0+ installed.");
        }
        else
        {
            leap_controller_.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            leap_controller_.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
            //leap_controller_.Config.SetFloat("Gesture.Circle.MinRadius", 10.0f);
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
                    if (gesture.State == Gesture.GestureState.STATE_STOP)
                    {
                        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        CircleGesture theCircle = new CircleGesture(frame.Gestures()[0]); // new CircleGesture();
                        Leap.Vector cCenter = theCircle.Center;

                        //float cCenterX = -1*Mathf.Round(cCenter.x);
                        //Debug.Log("cCenterX = " + cCenterX);
                        //cCenterX = cCenterX / 1000;
                        //Debug.Log("cCenterX/1000 = " + cCenterX);
                        //float cCenterY = Mathf.Round(cCenter.y);
                        //Debug.Log("cCenterY = " + cCenterY);
                        //cCenterY = cCenterY / 1000;
                        //Debug.Log("cCenterY/1000 = " + cCenterY);
                        //float cCenterZ = -1*Mathf.Round(cCenter.z);
                        //Debug.Log("cCenterZ = " + cCenterZ);
                        //cCenterZ = cCenterZ / 1000;
                        //Debug.Log("cCenterZ/1000 = " + cCenterZ);

                        cube.transform.localScale = new Vector3(1, 1, 1);
                        cube.transform.position = new Vector3(1, 1, 1); //cCenterX, cCenterY, cCenterZ);
                        cube.AddComponent<GrabbableObject>();
                        cube.AddComponent<Rigidbody>();
                        cube.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
                        cube.transform.renderer.materials[0].color = Color.blue;
                    }
                    break;
                }
                case(Gesture.GestureType.TYPE_SWIPE):
                {
                    Debug.Log("Did the swipe gesture swipe?");
                    if (gesture.State == Gesture.GestureState.STATE_STOP)
                    {
                        Debug.Log("Did the swipe gesture swipe?");
                        if (UICanvas.activeSelf)
                        { 
                            UICanvas.SetActive(false);
                        }
                        else
                        {
                            UICanvas.SetActive(true);
                        }
                        
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
}