using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mojoAnim : MonoBehaviour
{

    public GameObject bioMojoPrefab;
    public GameObject walkBtn;
    public GameObject stopBtn;

    public GameObject sitDownBtn;
    public GameObject liftPawBtn;
    public GameObject pawDownBtn;
    public GameObject standUpBtn;

    public GameObject layDownBtn;
    public GameObject InspectBtn;
    public GameObject pawDownInspectBtn;
    public GameObject standUpBtn_lay;

    public GameObject walkBtn_deactivate;
    public GameObject sitDownBtn_deactivate;
    public GameObject layDownBtn_deactivate;
    public GameObject liftPawBtn_deactivate;
    public GameObject InspectBtn_deactivate;

    
 
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
        
 //     walkBtn.SetActive(false);
        sitDownBtn.SetActive(false);
        layDownBtn.SetActive(false);

 //     walkBtn_deactivate.SetActive(true);
        sitDownBtn_deactivate.SetActive(true);
        layDownBtn_deactivate.SetActive(true);

 //     stopBtn.SetActive(true);

    }
    public void OnStop()
    {
        ExecuteTrigger("stopWalking");

//      walkBtn.SetActive(true);
        sitDownBtn.SetActive(true);
        layDownBtn.SetActive(true);

//      walkBtn_deactivate.SetActive(false);
        sitDownBtn_deactivate.SetActive(false);
        layDownBtn_deactivate.SetActive(false);

//      stopBtn.SetActive(false);

    }
    public void OnSit()
    {
        ExecuteTrigger("sit");

 //     walkBtn_deactivate.SetActive(true);
        sitDownBtn_deactivate.SetActive(true);
        layDownBtn_deactivate.SetActive(true);

        sitDownBtn.SetActive(false);
//      walkBtn.SetActive(false);
        layDownBtn.SetActive(false);

        liftPawBtn.SetActive(true);
        bioMojoPrefab.GetComponent<player>().enabled = false;
        bioMojoPrefab.GetComponent<toggleMenu>().enabled = false;



    }

    public void OnLiftPaw()
    {
        ExecuteTrigger("sit_lift");

        liftPawBtn.SetActive(false);
        pawDownBtn.SetActive(true);

        liftPawBtn_deactivate.SetActive(true);

    }

    public void OnSitLiftRev()
    {
        ExecuteTrigger("sit_lift_rev");

        standUpBtn.SetActive(true);
        pawDownBtn.SetActive(false);

        liftPawBtn_deactivate.SetActive(false);

    }

    public void OnStandUpSit()
    {
        ExecuteTrigger("standup_sit");

//      walkBtn.SetActive(true);
        sitDownBtn.SetActive(true);
        layDownBtn.SetActive(true);

//      walkBtn_deactivate.SetActive(false);
        sitDownBtn_deactivate.SetActive(false);
        layDownBtn_deactivate.SetActive(false);

        standUpBtn.SetActive(false);
        bioMojoPrefab.GetComponent<player>().enabled = true;
        bioMojoPrefab.GetComponent<toggleMenu>().enabled = true;

    }

    public void OnLay()
    {
        ExecuteTrigger("lay");

 //     walkBtn.SetActive(false);
        sitDownBtn.SetActive(false);
        layDownBtn.SetActive(false);

 //     walkBtn_deactivate.SetActive(true);
        sitDownBtn_deactivate.SetActive(true);
        layDownBtn_deactivate.SetActive(true);

        InspectBtn.SetActive(true);

        bioMojoPrefab.GetComponent<player>().enabled = false;
        bioMojoPrefab.GetComponent<toggleMenu>().enabled = false;

    }

    public void OnLayLift()
    {
        ExecuteTrigger("lay_lift");
        InspectBtn.SetActive(false);
        pawDownInspectBtn.SetActive(true);

        InspectBtn_deactivate.SetActive(true);



    }

    public void OnLayLiftRev()
    {
        ExecuteTrigger("lay_lift_rev");
        standUpBtn_lay.SetActive(true);
        pawDownInspectBtn.SetActive(false);

        InspectBtn_deactivate.SetActive(false);

    }

    public void OnStandUpLay()
    {
        ExecuteTrigger("standup_lay");

//      walkBtn.SetActive(true);
        sitDownBtn.SetActive(true);
        layDownBtn.SetActive(true);

 //     walkBtn_deactivate.SetActive(false);
        sitDownBtn_deactivate.SetActive(false);
        layDownBtn_deactivate.SetActive(false);

        standUpBtn_lay.SetActive(false);

        bioMojoPrefab.GetComponent<player>().enabled = true;
        bioMojoPrefab.GetComponent<toggleMenu>().enabled = true;

    }



}