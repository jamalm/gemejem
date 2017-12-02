using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TestRequest : MonoBehaviour
{

    private static string apiLink = "http://ec2-54-201-19-112.us-west-2.compute.amazonaws.com:8000/api/";
    public string _playerId;
    public string _currentGameId;
    public string _mapId;
    void Start()
    {
        StartCoroutine(_createPlayerId("kennyk"));
    }

    IEnumerator GetText()
    {
        using (UnityWebRequest request = UnityWebRequest.Get("http://unity3d.com/"))
        {
            yield return request.SendWebRequest();

            if (request.isNetworkError) // Error
            {
                Debug.Log(request.error);
            }
            else // Success
            {
                Debug.Log(request.downloadHandler.text);
            }
        }
    }
    public void CreatePlayerId(string username) {
        StartCoroutine(_createPlayerId(username));
    }
    IEnumerator _createPlayerId(string username) {
        var postData = new List<IMultipartFormSection>();
        postData.Add(new MultipartFormFileSection("username", username));
        Debug.Log(postData);
        using (UnityWebRequest request = UnityWebRequest.Post(apiLink, postData)) {
            yield return request.SendWebRequest();
            if (request.isNetworkError) // Error
            {
                Debug.Log(request.error);
            }
            else // Success
            {
                _playerId = request.downloadHandler.text;
                Debug.Log(_playerId);
            }

        }
    }
}