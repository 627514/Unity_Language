using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AddImagePlus_Hierarchy 
{
    [MenuItem("GameObject/UI/ImagePlus", false, 12)]
    static void MyTestA(MenuCommand menuCommand)
    {
        var node = (GameObject)menuCommand.context;
        var imgtp = node.AddComponent<ImagePlus>();
        Undo.RegisterCreatedObjectUndo(imgtp, "Create" + imgtp.name);//注册到Undo系统,允许撤销
    }
}
public class AddImagePlus_Inspector : Editor
{
    [MenuItem("Component/UI/ImagePlus")]
    static void AddImagePlus()
    {
        GameObject obj = Selection.activeGameObject;
        if (obj != null)
        {
            obj.AddComponent<ImagePlus>();
        }
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}
