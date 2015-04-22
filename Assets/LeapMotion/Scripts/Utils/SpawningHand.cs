using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Leap;



/* Leap Motion hand script that detects gestures and executes the appropriate actions */
class SpawningHand : HandController
{
    //private Frame frame;
    //public GameObject UICanvas;
    //public GameObject spawnAnchor;
    //public InteractionBox iBox;
    //public ObjectToSpawn spawnObject;
    


    void Start()
    {
        //if (leap_controller_ == null)
        //{
        //    Debug.LogWarning("Cannot connect to controller. Make sure you have Leap Motion v2.0+ installed.");
        //}
        //else
        //{
        //    leap_controller_.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
        //    leap_controller_.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        //    leap_controller_.Config.SetFloat("Gesture.Swipe.MinVelocity", 100f);
        //    leap_controller_.Config.SetFloat("Gesture.Swipe.MinLength", 50f);
        //    leap_controller_.Config.SetFloat("Gesture.Circle.MinRadius", 15.0f);
        //    leap_controller_.Config.SetFloat("Gesture.Circle.MinArc", 2.0f*Mathf.PI);
        //    leap_controller_.Config.Save();
        //}
        
    }

    void Update()
    {
        //if (leap_controller_ == null)
        //{
        //    return;
        //}

        //frame = GetFrame();
        //foreach (Gesture gesture in frame.Gestures())
        //{
        //    switch (gesture.Type)
        //    {
        //        case(Gesture.GestureType.TYPE_CIRCLE): //Spawn GameObject
        //        {
        //            if (gesture.State == Gesture.GestureState.STATE_STOP)
        //            {
        //                if (spawnObject.shape.text == "cube")
        //                {
        //                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //                    CircleGesture theCircle = new CircleGesture(frame.Gestures()[0]); // new CircleGesture();
        //                    //Leap.Vector cCenter = leapToWorld(theCircle.Center, iBox);

        //                    cube.transform.parent = spawnAnchor.transform;
        //                    //float cCenterX = Mathf.Round(cCenter.x);
        //                    //Debug.Log("cCenterX = " + cCenterX);
        //                    //float cCenterY = Mathf.Round(cCenter.y);
        //                    //Debug.Log("cCenterY = " + cCenterY);
        //                    //float cCenterZ = Mathf.Round(cCenter.z);
        //                    //Debug.Log("cCenterZ = " + cCenterZ);

        //                    cube.transform.localScale = new Vector3(1, 1, 1);
        //                    cube.transform.localPosition = new Vector3(0, 0.5f, 0);
        //                    cube.AddComponent<GrabbableObject>();
        //                    cube.AddComponent<Rigidbody>();
        //                    cube.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        //                    cube.transform.renderer.material.color = new Color32(spawnObject.red, spawnObject.green, spawnObject.blue, 1);
        //                    cube.transform.parent = null;
        //                }
        //                else if(spawnObject.shape.text == "cylinder")
        //                {
        //                    GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //                    CircleGesture theCircle = new CircleGesture(frame.Gestures()[0]); // new CircleGesture();
        //                    //Leap.Vector cCenter = leapToWorld(theCircle.Center, iBox);

        //                    cylinder.transform.parent = spawnAnchor.transform;
        //                    //float cCenterX = Mathf.Round(cCenter.x);
        //                    //Debug.Log("cCenterX = " + cCenterX);
        //                    //float cCenterY = Mathf.Round(cCenter.y);
        //                    //Debug.Log("cCenterY = " + cCenterY);
        //                    //float cCenterZ = Mathf.Round(cCenter.z);
        //                    //Debug.Log("cCenterZ = " + cCenterZ);

        //                    cylinder.transform.localScale = new Vector3(1, 1, 1);
        //                    cylinder.transform.localPosition = new Vector3(0, 0.5f, 0);
        //                    cylinder.AddComponent<GrabbableObject>();
        //                    cylinder.AddComponent<Rigidbody>();
        //                    cylinder.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        //                    cylinder.transform.renderer.material.color = new Color32(spawnObject.red, spawnObject.green, spawnObject.blue, 1);
        //                    cylinder.transform.parent = null;
        //                }
        //                else if (spawnObject.shape.text == "sphere")
        //                {
        //                    GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //                    CircleGesture theCircle = new CircleGesture(frame.Gestures()[0]); // new CircleGesture();
        //                    //Leap.Vector cCenter = leapToWorld(theCircle.Center, iBox);

        //                    sphere.transform.parent = spawnAnchor.transform;
        //                    //float cCenterX = Mathf.Round(cCenter.x);
        //                    //Debug.Log("cCenterX = " + cCenterX);
        //                    //float cCenterY = Mathf.Round(cCenter.y);
        //                    //Debug.Log("cCenterY = " + cCenterY);
        //                    //float cCenterZ = Mathf.Round(cCenter.z);
        //                    //Debug.Log("cCenterZ = " + cCenterZ);

        //                    sphere.transform.localScale = new Vector3(1, 1, 1);
        //                    sphere.transform.localPosition = new Vector3(0, 0.5f, 0);
        //                    sphere.AddComponent<GrabbableObject>();
        //                    sphere.AddComponent<Rigidbody>();
        //                    sphere.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        //                    sphere.transform.renderer.material.color = new Color32(spawnObject.red, spawnObject.green, spawnObject.blue, 1);
        //                    sphere.transform.parent = null;
        //                }
        //            }
        //            break;
        //        }
        //        case(Gesture.GestureType.TYPE_SWIPE): //Bring up UI
        //        {
        //            if (gesture.State == Gesture.GestureState.STATE_STOP)
        //            {
        //                if (UICanvas.activeSelf)
        //                { 
        //                    UICanvas.SetActive(false);
        //                }
        //                else
        //                {
        //                    UICanvas.SetActive(true);
        //                }
                        
        //            }
        //            break;
        //        }
        //        default:
        //        {
        //            break;
        //        }
        //    }
        //}
    }

    Leap.Vector leapToWorld(Leap.Vector leapPoint, InteractionBox iBox)
    {
        leapPoint.z *= -1.0f; //right-hand to left-hand rule
        Leap.Vector normalized = iBox.NormalizePoint(leapPoint, false);
        //normalized += new Leap.Vector(0.5f, 0f, 0.5f); //recenter origin
        return normalized * 100.0f; //scale
    }
}