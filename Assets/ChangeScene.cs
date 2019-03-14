using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    SceneLoader scene_;
    public string scene;
    
    void Start()
    {
        scene_.GetComponent<SceneLoader>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            scene_.LoadSceneAsync(scene);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            scene_.LoadSceneAsync(scene);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            scene_.LoadSceneAsync(scene);
        }
    }
}
