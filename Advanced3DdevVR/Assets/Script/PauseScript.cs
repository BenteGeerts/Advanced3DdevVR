using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PauseScript : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    public TextMeshProUGUI text;
    public GameObject left;
    public GameObject right;

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
        text.enabled = true;
        Time.timeScale = 0;
        left.SetActive(false);
        right.SetActive(false);
        Debug.Log("Paused");
    }
}
