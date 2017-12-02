using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public static class RequestHandler {

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


    public static UnityWebRequest Post(string postUrl, List<IMultipartFormSection> postData) {
        return UnityWebRequest.Post(postUrl, postData);
    }

    public static UnityWebRequest Get(string url) {
        return UnityWebRequest.Get(url);
    }

    // TODO - Make a new game
    public static void MakeNewGame(string playerId) {
        var response = Post(FUNC_NAME_FOR_NEW_GAME + playerId, null);
    }

    public static void MakePlayerId() {
        
    }
    // TODO - Make a new player id
    // TODO - Send a map
    public static void SendMap() {
        
    }
    public static void SendBlock() {
        //FOr block i map
        //SEnd block
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
    public static bool HasPlayerJoined(string gameId) {
        var response = Get(FUNC_NAME_QUERY_FOR_NEW_PLAYER+gameId);
        return false;
    }
    //TODO Join a Game
    public static void JoinGame(string gameId, string playerId) {
        Post(FUNC_NAME_FOR_JOIN_GAME + gameId + playerId, null);        
    }
}
