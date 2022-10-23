using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCalls : MonoBehaviour
{
  
  	public GameObject bioMojoPrefab;
	public GameObject btnpaw;
	
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
  
  	public void OnIdle()
	{
		ExecuteTrigger("idle");
        btnpaw.SetActive(true);
    }

    public void OnSit()
    {
        ExecuteTrigger("sit");
		btnpaw.SetActive(false);

    }
    public void OnWalk()
    {
        ExecuteTrigger("walk");
	


    }


}
