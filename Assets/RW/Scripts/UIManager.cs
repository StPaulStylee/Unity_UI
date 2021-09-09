using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
  public Animator StartButton;
  public Animator SettingsButtons;
  public Animator SettingsDialog;
  public Animator ContentPanel;
  public Animator GearIcon;

  public void CloseSettings() {
    StartButton.SetBool("isHidden", false);
    SettingsButtons.SetBool("isHidden", false);
    SettingsDialog.SetBool("isHidden", true);
  }
  
  public void OpenSettings() {
    StartButton.SetBool("isHidden", true);
    SettingsButtons.SetBool("isHidden", true);
    SettingsDialog.SetBool("isHidden", false);
  }

  public void StartGame() {
    SceneManager.LoadScene("RocketMouse");
  }

  public void ToggleMenu() {
    bool isHidden = ContentPanel.GetBool("isHidden");
    ContentPanel.SetBool("isHidden", !isHidden);
    GearIcon.SetBool("isRotating", isHidden);
  }
}
