using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelScript))]
public class LevelScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LevelScript myTarget = (LevelScript)target;
        myTarget.experience = EditorGUILayout.IntField("Experience", myTarget.experience);
        EditorGUILayout.LabelField("Level", myTarget.Level.ToString());

        //myTarget.experience = EditorGUILayout.IntSlider("Val-you", myTarget.experience, 1, 10);
        EditorGUILayout.IntSlider("Level", myTarget.Level, 1, 10);

    }
}