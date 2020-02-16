using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform aim;
    RaycastHit hit;
    Ray ray;
    Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        var v = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(cam.transform.position, Vector3.forward, Color.red, 1);
    }

    void OnMouseDown()
    {
        
    }
}
