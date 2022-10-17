using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
   

    bool isActive;

    public void activate1(InputAction.CallbackContext context)
    {
        isActive = !isActive;
        particle1.SetActive(isActive);
    }

    public void activate2(InputAction.CallbackContext context)
    {
        isActive = !isActive;
        particle2.SetActive(isActive);
    }
    public void activate3(InputAction.CallbackContext context)
    {
        isActive = !isActive;
        particle3.SetActive(isActive);
    }
    public void activate4(InputAction.CallbackContext context)
    {
        isActive = !isActive;
        particle4.SetActive(isActive);
    }
}