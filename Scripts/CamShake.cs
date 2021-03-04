using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    private float shakeTimeRemaining, shakePower;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        { 
            StartShake(1f, 3f);
        }
    }
    private void LateUpdate()
    {
        if(shakeTimeRemaining > 0)
        {
            shakeTimeRemaining -= Time.deltaTime;
            float xAmmount = Random.Range(-5f, 5f);
            float yAmmount = Random.Range(-1f, 1f);

            transform.position = new Vector3(xAmmount, yAmmount, 0);
        }
    }

    public void StartShake(float length, float power)
    {
        shakeTimeRemaining = length;
        shakePower = power;
    }
}
