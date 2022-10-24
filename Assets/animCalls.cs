using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCalls : MonoBehaviour
{
  
  	public GameObject bioMojoPrefab;
    public GameObject btnSit;
    public GameObject btnStandUp;
    public GameObject btnWalk;
    public GameObject btnStop;
    public GameObject btnLayDown;
    public GameObject btnInspectLeg;
    public GameObject btnExit;
    public GameObject btnSit_deactive;
    public GameObject btnWalk_deactive;
    public GameObject btnLayDown_deactive;
    public GameObject btnInspectLeg_deactive;

    private void ExecuteTrigger (string trigger)
	{
		if(bioMojoPrefab != null)
		{
			var animator = bioMojoPrefab.GetComponent<Animator>();
			if(animator != null)
			{
				animator.SetTrigger(trigger);
			}
		}
	}
  

    public void OnSit()
    {
        ExecuteTrigger("sit");
        btnSit.SetActive(false);
        btnSit_deactive.SetActive(true);
        btnStandUp.SetActive(true);
        btnWalk.SetActive(false);
        btnWalk_deactive.SetActive(true);
        btnLayDown.SetActive(false);
        btnLayDown_deactive.SetActive(true);


    }
    public void OnStandUp()
    {
        ExecuteTrigger("standUp");
        btnSit.SetActive(true);
        btnSit_deactive.SetActive(false);
        btnWalk.SetActive(true);
        btnWalk_deactive.SetActive(false);
        btnStandUp.SetActive(false);
        btnLayDown.SetActive(true);
        btnLayDown_deactive.SetActive(false);

    }


    public void OnWalk()
    {
        ExecuteTrigger("walk");
        btnWalk.SetActive(false);
        btnStop.SetActive(true);
        btnWalk_deactive.SetActive(true);
        btnSit.SetActive(false);
        btnSit_deactive.SetActive(true);
        btnLayDown.SetActive(false);
        btnLayDown.SetActive(false);
        btnLayDown_deactive.SetActive(true);

    }

    public void OnStop()
    {
        ExecuteTrigger("stop");
        btnWalk.SetActive(true);
        btnWalk_deactive.SetActive(false);
        btnStop.SetActive(false);
        btnSit.SetActive(true);
        btnSit_deactive.SetActive(false);
        btnLayDown.SetActive(true);
        btnLayDown_deactive.SetActive(false);

    }

    public void OnLayDown()
    {
        ExecuteTrigger("laydown");
        btnSit.SetActive(false);
        btnLayDown.SetActive(false);
        btnSit_deactive.SetActive(true);
        btnWalk_deactive.SetActive(true);
        btnLayDown_deactive.SetActive(true);
        btnInspectLeg.SetActive(true);
        btnWalk.SetActive(false);

    }

    public void OnInspectLeg()
    {
        ExecuteTrigger("laydown");
        btnInspectLeg.SetActive(false);
        btnInspectLeg_deactive.SetActive(true);
        btnExit.SetActive(true);

    }

    public void OnExit1()
    {
        ExecuteTrigger("exit1");
        btnInspectLeg_deactive.SetActive(false);
        btnExit.SetActive(false);
        btnSit.SetActive(true);
        btnLayDown.SetActive(true);
        btnWalk.SetActive(true);

    }
}
