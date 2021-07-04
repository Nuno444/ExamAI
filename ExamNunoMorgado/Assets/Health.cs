using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    float HealthValue = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            HealthValue--;
            Destroy(collision.gameObject);
        }
        if (HealthValue == 0)
        {
            Destroy(this.gameObject);
        }

    }
}
