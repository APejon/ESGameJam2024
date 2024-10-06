using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemaCar : MonoBehaviour
{
    private Vector3 _initialPosition;
    private Vector3 _camInitialPosition;
    
    [SerializeField] GameObject _camera;

    void Start()
    {
        _initialPosition = transform.position;
        _camInitialPosition = _camera.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0, 0, 10), Time.deltaTime);
    }
    
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("End"))
        {
            transform.position = _initialPosition;
            _camera.transform.position = _camInitialPosition;
        }
    }
}
