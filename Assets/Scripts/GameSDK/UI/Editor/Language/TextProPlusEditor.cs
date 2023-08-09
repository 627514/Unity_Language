using TMPro.EditorUtilities;
using UnityEditor;

public class TextProPlusEditor : TMP_BaseEditorPanel
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

    protected override void DrawExtraSettings()
    {
        //throw new System.NotImplementedException();
    }

    protected override bool IsMixSelectionTypes()
    {
        //throw new System.NotImplementedException();
        return false;
    }

    protected override void OnUndoRedo()
    {
        //throw new System.NotImplementedException();
    }
}
