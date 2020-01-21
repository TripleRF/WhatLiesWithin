using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(KonamiCode))]
public class CheaterDeath : MonoBehaviour
{
    private KonamiCode code;

    [SerializeField]
    private string sceneNameToLoad;

    void Awake()
    {
        code = GetComponent<KonamiCode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (code.success)
        {
            //Regan change the level here
            SceneManager.LoadScene(sceneNameToLoad);
        }

    }
}
