using UnityEngine;
using IngameDebugConsole;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        DebugLogConsole.AddCommand("CreateLobby", "Create Lobby", CreateLobby);
        DebugLogConsole.AddCommand("ListLobbies", "List Lobbies", ListLobbies);
        DebugLogConsole.AddCommand<string>("JoinLobbyByCode", "Join Lobby by code", JoinLobbyByCode);
        DebugLogConsole.AddCommand("QuickJoinLobby", "Quick Join Lobby", QuickJoinLobby);
        DebugLogConsole.AddCommand<string>("UpdateLobbyGameMode", "Update Lobby GameMode", UpdateLobbyGameMode);
        DebugLogConsole.AddCommand("PrintPlayers", "Print Players", PrintPlayers);
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

    private void JoinLobbyByCode(string lobbyCode)
    {
        TestLobby.Instance.JoinLobbyByCode(lobbyCode);
    }

    private void QuickJoinLobby()
    {
        TestLobby.Instance.QuickJoinLobby();
    }

    private void UpdateLobbyGameMode(string gameMode)
    {
        TestLobby.Instance.UpdateLobbyGameMode(gameMode);
    }

    private void PrintPlayers()
    {
        TestLobby.Instance.PrintPlayers();
    }

    //private GameObject AddChild(string name)
    //{
    //    GameObject child = new GameObject(name);
    //    child.transform.SetParent(transform);

    //    return child;
    //}
}