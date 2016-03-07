using UnityEngine;
using System.Collections;

public class DatabaseContainer : ScriptableObject {
    public string Prefix;
    public string Suffix;

    public static DatabaseContainer Get(string id) {
        return Resources.Load<DatabaseContainer>("Databases/" + id);
    }
    public static DatabaseContainer GetRandom() {
        var list = Resources.LoadAll<DatabaseContainer>("Databases");
        return list[Random.Range(0, list.Length)];
    }
    
    public override string ToString(){
        return "I am a database container";
    }
}