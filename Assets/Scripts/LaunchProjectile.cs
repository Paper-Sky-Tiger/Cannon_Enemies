using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public float projectileSpeed;
    public GameObject cannon_ball;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cannon_ball, transform.position, transform.rotation).GetComponent<Rigidbody>().AddForce(10f * projectileSpeed * transform.up, ForceMode.Force);

            Destroy(cannon_ball, 2f);

        }
    }
}
