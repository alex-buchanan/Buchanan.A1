using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        float horizMovement = Input.GetAxis("Horizontal");
        Vector3 Movement = new Vector3(horizMovement, 0, 0);
        transform.Translate(Movement*speed*Time.deltaTime);
    }
}
