using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] GameObject[] _cameras;
    
    void Start()
    {
        for (int i = 0; i < 3; i++)
            _cameras[i].GetComponent<Animator>().enabled = false;
        Activate();
    }

    void Activate()
    {
        float elapsed = 0;
        int i = 0;
        while (i < 3)
        {
            _cameras[i].GetComponent<Animator>().enabled = true;
            while (elapsed < 2f)
            {
                elapsed += Time.deltaTime;
            }
            elapsed = 0;
            _cameras[i].GetComponent<Animator>().enabled = false;
            i++;
        }
    }
}
