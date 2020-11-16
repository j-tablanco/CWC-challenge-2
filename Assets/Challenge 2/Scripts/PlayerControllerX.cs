using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeDelay = 2f;
    private float delayTimer;

    // Update is called once per frame
    void Update()
    {
        if (delayTimer >= 0f)
        {
            delayTimer -= Time.deltaTime;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && delayTimer < 0f)
        {
            SpawnDog();
        }
    }

    private void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        delayTimer = timeDelay;
    }
}
