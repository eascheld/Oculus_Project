using UnityEngine;
using System.Collections;
using Leap;

// Leap Motion hand script that detects shape gestures and spawns the appropriate GameObject
class GestureListener : Listener
{
    public GameObject largeCube;
    public Vector3 playerPos;
    public Vector3 playerDir;
    public Quaternion playerRot;
    protected float spawnDis = 5;

    private void SpawnObject(GameObject gObject, Vector3 spawnPos, Vector3 playerRot)
    {
        lock (thisLock)
        {
            Instantiate(gObject, spawnPos, playerRot);
        }
    }

    public override void OnConnect(Controller controller)
    {
        controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
    }

    public override void OnFrame(Controller controller)
    {
        // Get the most recent frame and report some basic information
        Frame frame = controller.Frame();

        foreach (Hand hand in frame.Hands)
        {
            // Get gestures
            GestureList gestures = frame.Gestures();
            for (int i = 0; i < gestures.Count; i++)
            {
                Gesture gesture = gestures[i];

                switch (gesture.Type)
                {
                    case Gesture.GestureType.TYPE_CIRCLE:
                        playerPos = yourPlayer.transform.position;
                        playerDir = player.transform.forward;
                        playerRot = player.transform.rotation;
                        Vectror3 spawnPos = playerPos + playerDir * spawnDis;

                        Instantiate(largeCube, spawnPos, playerRot);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

public class SpawningHand : MonoBehaviour {
    void Spawn()
    {
        GestureListener listener = new GestureListener();
        Controller conroller = new Controller();

        controller.AddListener(listener);



        controller.RemoveListener(listener);
        controller.Dispose();
    }
}
