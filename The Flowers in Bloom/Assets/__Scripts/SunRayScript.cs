using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRayScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Input.GetKeyDown(KeyCode.D) && other.gameObject.CompareTag("D"))
        {
            Destroy(other.gameObject);
        }
    }
}
