using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour {

   public bool SwitchCamera = false;
    public Camera secondCamera;
    public KeyCode pressedKey;
    

    void Update()
    {
        if (Input.GetKeyDown(pressedKey)){
            SwitchCamera = !SwitchCamera;
            secondCamera.gameObject.SetActive(SwitchCamera);
        }
    }
}
