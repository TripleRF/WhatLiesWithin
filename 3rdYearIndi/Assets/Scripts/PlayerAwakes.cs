using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(WakeUpCode))]
public class PlayerAwakes : MonoBehaviour
{
    private WakeUpCode code;

    [SerializeField]
    private string sceneNameToLoad;

    void Awake()
    {
        code = GetComponent<WakeUpCode>();
    }

    void Update()
    {
        if (code.success)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
