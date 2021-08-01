using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclicMotion : MonoBehaviour
{
    private float _totalTime = 0;
    Vector3 _pos;
    public float posX { get; set; }
    public float posY { get; set; }
    private void Start()
    {
        _pos = new Vector3(0, 0);
    }
    private void Update()
    {
        _pos.x = SinCyclicMotion();
        _pos.y = SinCyclicMotion() * CosCyclicMotion();
        this.transform.position = _pos;
    }
    public float SinCyclicMotion()
    {
        _totalTime += Time.deltaTime;
        return Mathf.Sin(_totalTime) * 5;
    }
    public float CosCyclicMotion()
    {
        _totalTime += Time.deltaTime;
        return Mathf.Cos(_totalTime) * 5;
    }
}
