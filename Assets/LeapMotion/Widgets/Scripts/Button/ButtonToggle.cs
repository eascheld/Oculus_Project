using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using LMWidgets;

public class ButtonToggle : ButtonToggleBase 
{
  public GameObject UICanvas;
  public Text buttonPressed;
  public Text shapeChosen;

  public override void ButtonTurnsOn()
  {
      TurnsOnGraphics();
  }

  public override void ButtonTurnsOff()
  {
    TurnsOffGraphics();
  }

  private void TurnsOnGraphics()
  {
      if (buttonPressed.text == "off")
      {
          UICanvas.SetActive(false);
      }
      else if (buttonPressed.text == "cylinder")
      {
          shapeChosen.text = "cylinder";
      }
      else if (buttonPressed.text == "cube")
      {
          shapeChosen.text = "cube";
      }
      else if (buttonPressed.text == "sphere")
      {
          shapeChosen.text = "sphere";
      }
      else
      {
          Debug.Log("Button Press Failure!");
      }
  }

  private void TurnsOffGraphics()
  {

  }

  private void UpdateGraphics()
  {
    Vector3 position = transform.localPosition;
    position.z = Mathf.Min(position.z, m_localTriggerDistance);
    Vector3 bot_position = position;
    bot_position.z = Mathf.Max(bot_position.z, m_localTriggerDistance - m_localCushionThickness);
    Vector3 mid_position = position;
    mid_position.z = (position.z + bot_position.z) / 2.0f;
  }

  protected override void Start()
  {
    base.Start();
  }

  protected override void FixedUpdate()
  {
    base.FixedUpdate();
    UpdateGraphics();
  }
}
