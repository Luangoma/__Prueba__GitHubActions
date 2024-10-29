using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotational : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(UnityEngine.Random.Range(0, 100) * Time.deltaTime, UnityEngine.Random.Range(0, 100) * Time.deltaTime, UnityEngine.Random.Range(0, 100) * Time.deltaTime);
    }
}
