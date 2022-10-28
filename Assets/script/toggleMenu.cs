using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleMenu : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            canvas.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            canvas.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            canvas.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            canvas.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            canvas.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            canvas.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            canvas.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            canvas.SetActive(true);
        }
    }

}
