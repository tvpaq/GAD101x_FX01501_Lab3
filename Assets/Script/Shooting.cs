using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Inventory;

public class Shooting : MonoBehaviour
{
    public Stuff myStuff = new Stuff(10, 7, 25);
    public Rigidbody projectileAPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && myStuff.projectileA > 0)
        {
            Rigidbody projectileAInstance = Instantiate(projectileAPrefab, firePosition.position, firePosition.rotation);
            projectileAInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.projectileA--;
        }
    }
}
