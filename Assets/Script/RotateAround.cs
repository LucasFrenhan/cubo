using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer.Internal;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float xtilt;
    
    void Start()
    {
        if(target != null) return;

        target = gameObject.transform;
        Debug.Log("target não espicificado");
    }

    
    void Update()
    {
        transform.RotateAround(target.position, new Vector3(xtilt, 1 , 0), speed * Time.deltaTime);
    }
}
