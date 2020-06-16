using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RadioSingleCommentLogic))]
public class RadioSingleCommentLogicEditor : Editor
{
  
        public override void OnInspectorGUI()
        {
            base.DrawDefaultInspector();
            RadioSingleCommentLogic radio = (RadioSingleCommentLogic)target;
            if (GUILayout.Button("Switch"))
                radio.SwitchRadioStatePlayPause();
        }
    }
