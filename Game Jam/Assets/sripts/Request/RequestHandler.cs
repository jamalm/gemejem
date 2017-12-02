using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RequestHandler : MonoBehaviour {

    private static string apiLink = "http://ec2-54-201-19-112.us-west-2.compute.amazonaws.com:8000/api/";
    private static string FUNC_NAME_FOR_NEW_PLAYER = "players/";
    private static string FUNC_NAME_FOR_NEW_GAME = "games/";
    private static string FUNC_NAME_FOR_JOIN_GAME = "games/";
    private static string FUNC_NAME_FOR_SEND_MAP = "maps/";
    private static string FUNC_NAME_FOR_GET_MAP = "maps/";
    private static string FUNC_NAME_FOR_SEND_SCORE = "scores/";
    private static string FUNC_NAME_FOR_GET_SCORES = "scores/";
    private static string FUNC_NAME_QUERY_FOR_NEW_PLAYER = "games/";
    private static string FUNC_NAME_ADD_BLOCK_TO_MAP = "blocks/";

    // FOR POST =
    // List<IMultipartFormSection> formData = new List<IMultipartFormSection>() is the data 


    public IEnumerator Post(string postUrl, List<IMultipartFormSection> postData) {
        Debug.Log("I totally made it");
        var request = UnityWebRequest.Post(postUrl, postData);
         yield return request.SendWebRequest();
    }

    public UnityWebRequest Get(string url) {
        return UnityWebRequest.Get(url);
    }

    // TODO - Make a new game
    public void MakeNewGame(string playerId) {
        var response = Post(FUNC_NAME_FOR_NEW_GAME + playerId, null);
    }

    public string MakePlayerId(string username) {
        var postData = new List<IMultipartFormSection>();
        postData.Add(new MultipartFormFileSection("username" , username));
        Debug.Log(postData);

        StartCoroutine(Post(apiLink + FUNC_NAME_FOR_NEW_PLAYER, postData));
        Debug.Log(FUNC_NAME_FOR_NEW_PLAYER);
 
        return "no";

    }
    // TODO - Make a new player id
    // TODO - Send a map
    public static void SendMap() {
        
    }
    public static void SendBlock() {
        //For block i map
        //Send block
    }
    // TODO - Get a map
    public static void GetMap() {
        
    }
    // TODO -Send score
    public static void SendScore() {
        
    }
    // TODO - GEt Scores
    public static void GetScore() {
        
    }
    // TODO - QUery for joined player
    public bool HasPlayerJoined(string gameId) {
        var response = Get(FUNC_NAME_QUERY_FOR_NEW_PLAYER+gameId);
        return false;
    }
    //TODO Join a Game
    public void JoinGame(string gameId, string playerId) {
        Post(FUNC_NAME_FOR_JOIN_GAME + gameId + playerId, null);        
    }
}
