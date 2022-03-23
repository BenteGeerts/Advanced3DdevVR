using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PauseScript : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    public TextMeshProUGUI text;
    public GameObject origin;
    public GameObject camera;
    public bool paused = true;

    void Awake()
    {
        toggleReference.action.started += Toggle;
        text.enabled = false;
    }

    void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    void Toggle(InputAction.CallbackContext context)
    {
        paused = !paused;
        if(paused == false)
        {
            text.enabled = true;
            Time.timeScale = 0;
            origin.SetActive(false);
            camera.SetActive(true);
            Debug.Log("Paused");
        }
        if(paused)
        {
            text.enabled = false;
            Time.timeScale = 1;
            origin.SetActive(true);
            camera.SetActive(false);
            Debug.Log("Unpaused");
        }
        
    }
}
