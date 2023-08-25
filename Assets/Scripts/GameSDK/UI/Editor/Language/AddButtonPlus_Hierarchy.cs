using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class AddButtonPlus_Hierarchy 
{
    [MenuItem("GameObject/UI/ButtonPlus", false, 9)]
    static void MyTestA(MenuCommand menuCommand)
    {
        var node = (GameObject)menuCommand.context;
        var go = new GameObject("buttonPlus");
        go.transform.SetParent(node.transform);
        go.transform.localPosition = Vector3.zero;
        Selection.activeGameObject = go;
        go.AddComponent<Image>();
        var buttonp = go.AddComponent<ButtonPlus>();
        var txtp = new GameObject("textPlus");
        txtp.AddComponent<TextPlus>();
        txtp.transform.SetParent(buttonp.transform);
        txtp.transform.localPosition = Vector3.zero;
        Undo.RegisterCreatedObjectUndo(buttonp, "Create" + buttonp.name);//注册到Undo系统,允许撤销
    }
}
public class AddButtonPlus_Inspector : Editor
{
    [MenuItem("Component/UI/ButtonPlus")]
    static void AddButtonPlus()
    {
        GameObject obj = Selection.activeGameObject;
        if (obj != null)
        {
            obj.AddComponent<ButtonPlus>();
        }
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}
