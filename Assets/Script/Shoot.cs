using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform position;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            shooting();
        }
    }

    void shooting() {
        Instantiate(Bullet, position.position, position.rotation);
    }
}
