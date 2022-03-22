using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExitScript : MonoBehaviour
{
    public InputActionReference toggleReference = null;

    void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    void Toggle(InputAction.CallbackContext context)
    {
        Debug.Log("Quiting");
       Application.Quit();
    }
}
