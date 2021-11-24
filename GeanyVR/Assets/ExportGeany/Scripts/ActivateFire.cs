using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFire : MonoBehaviour
{
   [SerializeField] GameObject fire;


    private void Start()
    {
        fire = GameObject.FindGameObjectWithTag("Fire");
    }
    public void ToggleVisibilityOn()
    {
        if (fire != null)
        {
            fire.SetActive(true);
        }
        else
            Debug.Log("DEAD");
       
    }
    public void ToggleVisibilityOFF()
    {
        if (fire != null)
        {
            fire.SetActive(false);
        }
        else
            Debug.Log("DEAD");
    }
}
