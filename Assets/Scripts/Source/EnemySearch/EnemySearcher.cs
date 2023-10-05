using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemySearcher : MonoBehaviour
{
    [SerializeField] private string _url = "https://randomuser.me/api/";

    public event Action SearchingStarted;
    public event Action<string, Texture2D> EnemyFound;

    public void Search()
    {
        // TODO: stop corutine
        SearchingStarted?.Invoke();
        StartCoroutine(Searching());
    }

    private IEnumerator Searching()
    { // TODO: separate
        using (UnityWebRequest request = UnityWebRequest.Get(_url))
        {
            string result = "";
            while (string.IsNullOrEmpty(result))
            {
                yield return request.SendWebRequest();
                result = request.downloadHandler.text;
            }

            RootObject rootObject = (RootObject)JsonUtility.FromJson(result, typeof(RootObject));
            string name = rootObject.results[0].name.ToString();
            string pictureUrl = rootObject.results[0].picture.large;

            using (UnityWebRequest pictureRequest = UnityWebRequestTexture.GetTexture(pictureUrl))
            {
                Texture2D texture = null;
                while (texture == null)
                {
                    yield return pictureRequest.SendWebRequest();
                    texture = ((DownloadHandlerTexture)pictureRequest.downloadHandler).texture;
                }

                EnemyFound?.Invoke(name, texture);
            }
        }

        yield return null;
    }

    [Serializable]
    public struct Name
    {
        public string title;
        public string first;
        public string last;

        public override string ToString()
        {
            return $"{title} {first} {last}";
        }
    }

    [Serializable]
    public struct Result
    {
        public Name name;
        public Picture picture;
    }

    [Serializable]
    public struct Picture
    {
        public string large;
    }

    [Serializable]
    public struct RootObject
    {
        public List<Result> results;
    }
}