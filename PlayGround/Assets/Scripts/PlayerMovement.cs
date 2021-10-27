using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private float horizontal;
    private float posXLeft = -1.3f;
    private float posXRight = 5.3f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);

        if (transform.position.x < posXLeft)
        {
            transform.position = new Vector3(posXLeft, transform.position.y, transform.position.z);
        }
        if (transform.position.x > posXRight)
        {
            transform.position = new Vector3(posXRight, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
