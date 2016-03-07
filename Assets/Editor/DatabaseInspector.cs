using UnityEngine;
using System.Collections;
using UnityEditor;

public class DatabaseInspector : EditorWindow {
    
    string myString = "Hello World";
	bool groupEnabled;
	bool myBool = true;
	float myFloat = 1.23f;
    
    
    [MenuItem("Database/Overview")]
    public static void Init() {
        DatabaseInspector window = EditorWindow.GetWindow<DatabaseInspector>();
        window.minSize = new Vector2(800, 400);
        window.Show();
    }
    
    void OnGUI(){
        EditorGUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
        DisplayListArea();
        DisplayMainArea();
        EditorGUILayout.EndHorizontal();

    }
}
