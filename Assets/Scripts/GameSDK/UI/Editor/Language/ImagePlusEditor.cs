using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

[CustomEditor(typeof(ImagePlus), true)]
[CanEditMultipleObjects]
public class ImagePlusEditor : ImageEditor
{
    SerializedProperty _key;

    protected override void OnEnable()
    {
        base.OnEnable();
        _key = serializedObject.FindProperty("languageKey");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.Space();
        serializedObject.Update();
        EditorGUILayout.PropertyField(_key);
        serializedObject.ApplyModifiedProperties();

    }
}
