using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mojoAnim : MonoBehaviour
{

    public GameObject bioMojoPrefab;
    public GameObject walkBtn;
    public GameObject stopBtn;
    public GameObject btnSit;
    public GameObject sitDownBtn;
    public GameObject liftPawBtn;
    public GameObject pawDownBtn;
    public GameObject standUpBtn;

    public GameObject walkBtn_deactivate;





    private void ExecuteTrigger(string trigger)
    {
        if (bioMojoPrefab != null)
        {
            var animator = bioMojoPrefab.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }


    public void OnWalk()
    {
        ExecuteTrigger("walk");
        walkBtn.SetActive(false);
        stopBtn.SetActive(true);
        walkBtn_deactivate.SetActive(true);

    }
    public void OnStop()
    {
        ExecuteTrigger("stopWalking");
        walkBtn.SetActive(true);
        stopBtn.SetActive(false);
        walkBtn_deactivate.SetActive(false);
    }
    public void OnSit()
    {
        ExecuteTrigger("sit");
        sitDownBtn.SetActive(false);
        liftPawBtn.SetActive(true);
    }
    public void OnLiftPaw()
    {
        ExecuteTrigger("sit_lift");
        liftPawBtn.SetActive(false);
        pawDownBtn.SetActive(true);
    }
    public void OnSitLiftRev()
    {
        ExecuteTrigger("sit_lift_rev");
        standUpBtn.SetActive(true);
        pawDownBtn.SetActive(false);
    }
    public void OnStandUpSit()
    {
        ExecuteTrigger("standup_sit");
        sitDownBtn.SetActive(true);
        standUpBtn.SetActive(false);

    }
    public void OnLay()
    {
        ExecuteTrigger("lay");
    }





}