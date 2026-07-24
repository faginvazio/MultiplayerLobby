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
        DebugLogConsole.AddCommand<string>("UpdatePlayerName", "Update PlayerName", UpdatePlayerName);
        DebugLogConsole.AddCommand("LeaveLobby", "Leave Lobby", LeaveLobby);
        DebugLogConsole.AddCommand("KickPlayer", "Kick Player", KickPlayer);
        DebugLogConsole.AddCommand("MigrateLobbyHost", "Migrate LobbyHost", MigrateLobbyHost);
        DebugLogConsole.AddCommand("DeleteLobby", "Delete Lobby", DeleteLobby);
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

    private void UpdatePlayerName(string newPlayerName)
    {
        TestLobby.Instance.UpdatePlayerName(newPlayerName);
    }

    private void LeaveLobby()
    {
        TestLobby.Instance.LeaveLobby();
    }

    private void KickPlayer()
    {
        TestLobby.Instance.KickPlayer();
    }

    private void MigrateLobbyHost()
    {
        TestLobby.Instance.MigrateLobbyHost();
    }

    private void DeleteLobby()
    {
        TestLobby.Instance.DeleteLobby();
    }
}