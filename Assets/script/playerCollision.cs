using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
        public GameObject outOfBounds_btn;
        bool m_ActiveMesaage;

        Coroutine m_MessageCoroutine;

    void OnCollisionEnter(Collision col)
    {
        DetectCollision(col, true);
    }

    void OnCollisionExit(Collision col)
    {
        DetectCollision(col, false);
    }

    void DetectCollision(Collision col, bool enter)
    {
         if ((col.gameObject.name=="wall_01") || (col.gameObject.name=="wall_02") || (col.gameObject.name=="wall_03") ||(col.gameObject.name=="wall_04"))
        {
            m_ActiveMesaage = enter;
            if (m_MessageCoroutine != null)
                StopCoroutine(m_MessageCoroutine);
            m_MessageCoroutine = StartCoroutine(ShowMessageCoroutine());
        }
    }

    IEnumerator ShowMessageCoroutine()
    {
        if (!m_ActiveMesaage)
        {
            if (outOfBounds_btn.activeSelf)
                yield return new WaitForSeconds(2);
            outOfBounds_btn.SetActive(false);
        }
        else
        {
            outOfBounds_btn.SetActive(true);
        }
        yield return null;
    }


}
