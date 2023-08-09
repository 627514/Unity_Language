using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AddTextPlus_Hierarchy 
{
    [MenuItem("GameObject/UI/TextPlus", false, 10)]
    static void MyTestA(MenuCommand menuCommand)
    {
        var node =(GameObject) menuCommand.context;
        var textp= node.AddComponent<TextPlus>();
        Undo.RegisterCreatedObjectUndo(textp, "Create" + textp.name);//注册到Undo系统,允许撤销
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
