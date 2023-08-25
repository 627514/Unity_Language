using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AddTextProPlus_Hierarchy 
{
    [MenuItem("GameObject/UI/TextProPlus", false, 11)]
    static void MyTestA(MenuCommand menuCommand)
    {
        var node = (GameObject)menuCommand.context;
        var go = new GameObject("textProPlus");
        go.transform.SetParent(node.transform);
        go.transform.localPosition = Vector3.zero;
        Selection.activeGameObject = go;
        var textp = go.AddComponent<TextProPlus>();
        Undo.RegisterCreatedObjectUndo(textp, "Create" + textp.name);//注册到Undo系统,允许撤销
    }
}
public class AddTextProPlus_Inspector : Editor
{
    [MenuItem("Component/UI/TextProPlus")]
    static void AddTextProPlus()
    {
        GameObject obj = Selection.activeGameObject;
        if (obj != null)
        {
            obj.AddComponent<TextProPlus>();
        }
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}
