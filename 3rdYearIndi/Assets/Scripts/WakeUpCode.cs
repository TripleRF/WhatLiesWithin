using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUpCode : MonoBehaviour
{
    private const float WaitTime = 1f;

    private KeyCode[] keys2 = new KeyCode[]
        {
            KeyCode.W,
            KeyCode.A,
            KeyCode.K,
            KeyCode.E,
            KeyCode.M,
            KeyCode.E
        };

    public bool success;

    IEnumerator Start()
    {
        float timer = 0f;
        int index = 0;

        while (true)
        {
            if (Input.GetKeyDown(keys2[index]))
            {
                index++;

                if (index == keys2.Length)
                {
                    success = true;
                    timer = 0f;
                }
                else
                {
                    timer = WaitTime;
                }
            }

            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0;
                index = 0;
            }

            yield return null;
        }
    }
}