using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemnt : MonoBehaviour
{
    public float speedHorizontal;
    public float speedVeritical;

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        transform.GetComponent<Rigidbody>().velocity = Vector3.forward * speedVeritical + new Vector3(x * speedVeritical, 0);
    }

}
