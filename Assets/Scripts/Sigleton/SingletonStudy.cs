using UnityEngine;
using System.Collections;

public class SingletonStudy<T> : MonoBehaviour where T : MonoBehaviour{


    private static T instance;

    public static T Instance {

        get {

            if (instance == null) {

                GameObject singleton = new GameObject("Singleton");

                instance = singleton.AddComponent<T>();
            }

            return instance;
        }

    }

    public void OnApplicationQuit()
    {

        instance = null;

        Debug.Log("quit");

    }

}

