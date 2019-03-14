using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance = null;
    AsyncOperation asyncLoader;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void LoadScenes(string scene)
    {
        StartCoroutine(LoadSceneAsync(scene));
    }

    public IEnumerator LoadSceneAsync(string scene)
    {
        yield return new WaitForSeconds(3f);
        asyncLoader = SceneManager.LoadSceneAsync(scene);
        while(!asyncLoader.isDone)
        {
            Debug.Log("Loading Progress: " + asyncLoader.progress);
            yield return null;
        }
    }
}

