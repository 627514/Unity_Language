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
        var textp = node.AddComponent<TextProPlus>();
        Undo.RegisterCreatedObjectUndo(textp, "Create" + textp.name);//ע�ᵽUndoϵͳ,������
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
