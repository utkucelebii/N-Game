using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var mapGenerator = (MapGenerator)target;
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Generate"))
        {
            if(!mapGenerator.GetComponent<EdgeCollider2D>())
            {
                mapGenerator.ClearMap();
                mapGenerator.isGenerated = false;
            }
            mapGenerator.GenerateMap();
            mapGenerator.isGenerated = true;
        }
        if (GUILayout.Button("Clear"))
        {
            mapGenerator.ClearMap();
            mapGenerator.isGenerated = false;
        }
        if (GUILayout.Button("Save Map"))
        {
            if (mapGenerator.isGenerated)
                mapGenerator.SaveMeshes();
            else
                Debug.LogError("There is no mesh to generate!");
        }
        GUI.enabled = true;
        GUILayout.EndHorizontal();
    }
}
