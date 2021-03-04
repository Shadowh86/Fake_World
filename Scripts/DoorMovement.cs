using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public GameObject door;
    public Vector3 position;
    public float timer, interval =2f;
    public DoorOpen dO;

    private void Start()
    {
        
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if( dO == true )
        {
            Vector3 position = new Vector3(Random.Range(24, 20), 0,0);
        }
    }
}
