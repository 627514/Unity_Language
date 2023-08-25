using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AddTextPlus_Hierarchy 
{
    [MenuItem("GameObject/UI/TextPlus", false, 10)]
    static void MyTestA(MenuCommand menuCommand)
    {
        var node =(GameObject) menuCommand.context;
        var go = new GameObject("textPlus");
        go.transform.SetParent(node.transform);
        go.transform.localPosition = Vector3.zero;
        Selection.activeGameObject = go;
        var textp= go.AddComponent<TextPlus>();
        Undo.RegisterCreatedObjectUndo(textp, "Create" + textp.name);//ע�ᵽUndoϵͳ,������
    }
}
public class AddTextPlus_Inspector:Editor
{
    [MenuItem("Component/UI/TextPlus")]
    static void AddTextPlus()
    {
        GameObject obj = Selection.activeGameObject;
        if (obj != null)
        {
            obj.AddComponent<TextPlus>();
        }
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}
