using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadioSingleCommentLogic : MonoBehaviour
{
    public AudioSource m_whereToPlayTheSound;
    public AudioClip m_musicToPlay;
    public OnRadoTurnOnOff m_onRadioSwitch;

    [Header("Debug (Dont touch)")]
    [SerializeField] bool m_radioStateDebug;
    public void SwitchRadioStatePlayPause()
    {
        SetRadioStatePlayPause(!m_radioStateDebug);
    }
    public void SetRadioStatePlayPause(bool setOn)  
    {
        bool previous = m_radioStateDebug;
        m_radioStateDebug = !m_radioStateDebug;
        if (previous != m_radioStateDebug) {
            m_onRadioSwitch.Invoke(m_radioStateDebug);
        }

        if (setOn)
        {
            
            m_whereToPlayTheSound.clip = m_musicToPlay;
            m_whereToPlayTheSound.Play();
            m_radioStateDebug = true;
        }
        else 
        {
            m_whereToPlayTheSound.Stop();
            m_radioStateDebug = false;
        }
        
    }



}
[System.Serializable]
    public class OnRadoTurnOnOff : UnityEvent<bool> { }
