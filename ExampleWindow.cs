using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ExampleWindow : EditorWindow {

    Color color;

    [MenuItem("Window/Coloriar Objecto")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<ExampleWindow>("Color");
    }
    void OnGUI ()
    {
        GUILayout.Label("Seleciona el Color del Objeto", EditorStyles.boldLabel);


        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Coloriar"))
        {
            Colorize();
        }
    }

    void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }
}
