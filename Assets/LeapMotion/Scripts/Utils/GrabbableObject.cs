/******************************************************************************\
* Copyright (C) Leap Motion, Inc. 2011-2014.                                   *
* Leap Motion proprietary. Licensed under Apache 2.0                           *
* Available at http://www.apache.org/licenses/LICENSE-2.0.html                 *
\******************************************************************************/

using UnityEngine;
using System.Collections;

public class GrabbableObject : MonoBehaviour {

  public bool useAxisAlignment = false;
  public Vector3 rightHandAxis;
  public Vector3 objectAxis;

  public bool rotateQuickly = true;
  public bool centerGrabbedObject = false;

  public Rigidbody breakableJoint;
  public float breakForce;
  public float breakTorque;

  protected bool grabbed_ = false;
  protected bool hovered_ = false;

  public bool IsHovered() {
    return hovered_;
  }

  public bool IsGrabbed() {
    return grabbed_;
  }

  public virtual void OnStartHover() {
    hovered_ = true;
  }

  public virtual void OnStopHover() {
    hovered_ = false;
  }

  public virtual void OnGrab() {
    grabbed_ = true;
    hovered_ = false;

    //Release GameObject position lock
    rigidbody.constraints = RigidbodyConstraints.None;
    rigidbody.constraints = RigidbodyConstraints.FreezeRotation;

    if (breakableJoint != null) {
      Joint breakJoint = breakableJoint.GetComponent<Joint>();
      if (breakJoint != null) {
        breakJoint.breakForce = breakForce;
        breakJoint.breakTorque = breakTorque;
      }
    }
  }

  public virtual void OnRelease() {
    grabbed_ = false;

    Vector3 newPos = rigidbody.transform.position;

    newPos.x = Mathf.Round(newPos.x);
    newPos.y = Mathf.Round(newPos.y);
    newPos.z = Mathf.Round(newPos.z);

    transform.position = newPos;
    //Lock GameObject to position
    rigidbody.constraints = RigidbodyConstraints.FreezeAll;

    if (breakableJoint != null) {
      Joint breakJoint = breakableJoint.GetComponent<Joint>();
      if (breakJoint != null) {
        breakJoint.breakForce = Mathf.Infinity;
        breakJoint.breakTorque = Mathf.Infinity;
      }
    }

   

  }
}
