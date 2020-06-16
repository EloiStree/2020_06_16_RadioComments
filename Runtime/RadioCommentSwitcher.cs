using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadioCommentSwitcher : MonoBehaviour
{//Don't forget you can code better version, it is just for the demo ;)

    public UnityEvent m_onUserEnter;
    public LayerMask m_allowOnlyThoseCollision;
    public bool m_checkForInteractionTag=true;
    private void OnTriggerEnter(Collider other)
    {
        if (!CollisionIsValide(other.gameObject))
            return;
        m_onUserEnter.Invoke();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!CollisionIsValide(collision.gameObject)) 
            return;
        m_onUserEnter.Invoke();
    }

    public bool CollisionIsValide(GameObject target) {
        if (!Contains(m_allowOnlyThoseCollision, target.layer))
            return false;
        if (m_checkForInteractionTag && !target.GetComponent<RadioCommentInteractionTag>())
            return false;
        return true;
    }


    public static bool Contains( LayerMask mask, int layer)
    {
        //Source: https://answers.unity.com/questions/50279/check-if-layer-is-in-layermask.html
        return mask == (mask | (1 << layer));
    }
}
