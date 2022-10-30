using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleMenu : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject layDownBtn;
    [SerializeField] GameObject sitDownBtn;
    public GameObject W_btn;
    public GameObject W_opacity_btn;
    public GameObject A_btn;
    public GameObject A_opacity_btn;
    public GameObject S_btn;
    public GameObject S_opacity_btn;
    public GameObject D_btn;
    public GameObject D_opacity_btn;



    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)))
        {
            layDownBtn.SetActive(false);
            sitDownBtn.SetActive(false);
        }
        else if ((Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.S)) || (Input.GetKeyUp(KeyCode.D)))
        {
            layDownBtn.SetActive(true);
            sitDownBtn.SetActive(true);
        }
        if ((Input.GetKeyDown(KeyCode.W)))
        {
            W_btn.SetActive(true);
            W_opacity_btn.SetActive(false);
        }
        else if ((Input.GetKeyUp(KeyCode.W)))
        {
            W_btn.SetActive(false);
            W_opacity_btn.SetActive(true);

        }
        if ((Input.GetKeyDown(KeyCode.A)))
        {
            A_btn.SetActive(true);
            A_opacity_btn.SetActive(false);
        }
        else if ((Input.GetKeyUp(KeyCode.A)))
        {
            A_btn.SetActive(false);
            A_opacity_btn.SetActive(true);

        }
        if ((Input.GetKeyDown(KeyCode.S)))
        {
            S_btn.SetActive(true);
            S_opacity_btn.SetActive(false);
        }
        else if ((Input.GetKeyUp(KeyCode.S)))
        {
            S_btn.SetActive(false);
            S_opacity_btn.SetActive(true);

        }
        if ((Input.GetKeyDown(KeyCode.D)))
        {
            D_btn.SetActive(true);
            D_opacity_btn.SetActive(false);
        }
        else if ((Input.GetKeyUp(KeyCode.D)))
        {
            D_btn.SetActive(false);
            D_opacity_btn.SetActive(true);

        }


    }

}
