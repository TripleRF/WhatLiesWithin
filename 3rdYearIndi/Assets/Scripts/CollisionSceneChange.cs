using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneChange : MonoBehaviour
{

    [SerializeField]
    private string sceneNameToLoad;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
