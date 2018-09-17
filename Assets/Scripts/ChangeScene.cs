using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    AsyncOperation async;

    private void Start()
    {
        Player.Instance.transform.position = Vector3.zero;

        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            async = SceneManager.LoadSceneAsync("Scene2");
            async.allowSceneActivation = false;
        }
        else if (SceneManager.GetActiveScene().name == "Scene2")
        {
            async = SceneManager.LoadSceneAsync("Scene1");
            async.allowSceneActivation = false;
        }

    }


    private void OnMouseDown()
    {
        async.allowSceneActivation = true;
       Debug.Log("points: " + Player.Instance.points);
    }
}
