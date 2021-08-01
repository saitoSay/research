using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSphere : MonoBehaviour
{
    [SerializeField] GameObject _sphere;
    private void Start()
    {
        Instantiate(_sphere);
    }
}
