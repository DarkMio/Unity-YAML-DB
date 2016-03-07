using UnityEngine;
using System.Collections;
using UnityEditor;

public class DatabaseInspector : EditorWindow {
    private enum InspectorState {
        EMPTY,
        READ,
        EDIT
    }
    Vector2 _scrollPos;
    
    
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
    
     void DisplayListArea()
    {
        EditorGUILayout.BeginVertical(GUILayout.Width(160));
        EditorGUILayout.Space();

        _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, "box", GUILayout.ExpandHeight(true));
        DatabaseContainer[] containers = Resources.LoadAll<DatabaseContainer>("Container/");
        foreach(DatabaseContainer a in containers) {
            EditorGUILayout.BeginHorizontal();
            if(GUILayout.Button("> Found something <", "box", GUILayout.ExpandWidth(true))){
                return;
            }
            EditorGUILayout.EndHorizontal();
        }
        for(int i = 0; i < 25; i++) {
            EditorGUILayout.BeginHorizontal();
            if(GUILayout.Button("This will represent my table", "box", GUILayout.ExpandWidth(true))){
                return;
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.EndScrollView();
        
        EditorGUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
        EditorGUILayout.LabelField("Databases: " + 25, GUILayout.Width(100));

        GUILayout.Button("New modifier");
           
/*
        for (int cnt = 0; cnt < modifier.COUNT; cnt++)
        {
            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("-", GUILayout.Width(25)))
            {
                modifier.RemoveAt(cnt);
                modifier.SortAlphabeticallyAtoZ();
                EditorUtility.SetDirty(modifier);
                state = State.BLANK;
                return;
            }

            if (GUILayout.Button(modifier.Modifier(cnt).modifierName, "box", GUILayout.ExpandWidth(true)))
            {
                selectedModifier = cnt;
                state = State.EDIT;
            }

            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.EndScrollView();

        EditorGUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
        EditorGUILayout.LabelField("modifier: " + modifier.COUNT, GUILayout.Width(100));

        if (GUILayout.Button("New modifier"))
            state = State.ADD;
*/
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Space();
        EditorGUILayout.EndVertical();
    }

    void DisplayMainArea()
    {
        EditorGUILayout.BeginVertical(GUILayout.ExpandWidth(true));
        EditorGUILayout.Space();
/*
        switch (state)
        {
            case State.ADD:
                DisplayAddMainArea();
                break;
            case State.EDIT:
                DisplayEditMainArea();
                break;
            default:
                DisplayBlankMainArea();
                break;
        }
*/
        EditorGUILayout.Space();
        EditorGUILayout.EndVertical();
    }
}
