using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform world;
    // Start is called before the first frame update
    void Start()
    {
        world = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        world.transform.Rotate(0f, 1f, 0f, Space.World);
    }
}
