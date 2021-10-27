using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds: MonoBehaviour
{
    private float outOfBoundProjectiles = 35f;
    private float outOfBoundEnemy = -8f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > outOfBoundProjectiles)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < outOfBoundEnemy)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }

    
}
