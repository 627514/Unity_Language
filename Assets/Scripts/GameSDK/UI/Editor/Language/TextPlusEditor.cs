using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(TextPlus), true)]
[CanEditMultipleObjects]
public class TextPlusEditor : TextEditor
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