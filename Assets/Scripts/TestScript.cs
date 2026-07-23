using UnityEngine;
using IngameDebugConsole;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        DebugLogConsole.AddCommand("CreateLobby", "Create Lobby", CreateLobby);
        DebugLogConsole.AddCommand("ListLobbies", "List Lobbies", ListLobbies);
        //DebugLogConsole.AddCommand<Vector3>("cube", "Creates a cube at specified position", CreateCubeAt);
        //DebugLogConsole.AddCommand<string, GameObject>("child", "Creates a new child object under " + name, AddChild);
    }

    private void CreateLobby()
    {
        TestLobby.Instance.CreateLobby();
    }

    private void ListLobbies()
    {
        TestLobby.Instance.ListLobbies();
    }


    //public static void CreateCubeAt(Vector3 position)
    //{
    //    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = position;
    //}

    //private GameObject AddChild(string name)
    //{
    //    GameObject child = new GameObject(name);
    //    child.transform.SetParent(transform);

    //    return child;
    //}
}