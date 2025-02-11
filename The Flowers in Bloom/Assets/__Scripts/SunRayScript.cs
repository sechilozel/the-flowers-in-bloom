// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SunRayScript : MonoBehaviour
// {
//     private void OnTriggerStay2D(Collider2D other)
//     {
//         Debug.Log("girdi");
//         if (Input.GetKeyDown(KeyCode.D) && other.CompareTag("D"))
//         {
//             Destroy(other.gameObject);
//         Debug.Log("içerde");

//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRayScript : MonoBehaviour
{
    private Collider2D currentDropD; // İçerideki nesneyi sakla
    private Collider2D currentDropF;
    private Collider2D currentDropJ;
    private Collider2D currentDropK;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("D"))
        {
            currentDropD = other;
        }
        else if (other.CompareTag("F"))
        {
            currentDropF = other;
        }
        else if (other.CompareTag("J"))
        {
            currentDropJ = other;
        }
        else if (other.CompareTag("K"))
        {
            currentDropK = other;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other == currentDropD)
        {
            currentDropD = null; // Nesne çıktıysa sıfırla
        }
        else if (other == currentDropF)
        {
            currentDropF = null; // Nesne çıktıysa sıfırla
        }
        else if (other == currentDropJ)
        {
            currentDropJ = null; // Nesne çıktıysa sıfırla
        }
        else if (other == currentDropK)
        {
            currentDropK = null; // Nesne çıktıysa sıfırla
        }
    }

    private void Update()
    {
        if (currentDropD != null && Input.GetKeyDown(KeyCode.D))
        {
            Destroy(currentDropD.gameObject);
            Debug.Log("D tuşuna basıldı ve obje yok oldu!");
            currentDropD = null; // Nesneyi sıfırla
        }
        else if (currentDropF != null && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(currentDropF.gameObject);
            Debug.Log("F tuşuna basıldı ve obje yok oldu!");
            currentDropF = null; // Nesneyi sıfırla
        }
        else if (currentDropJ != null && Input.GetKeyDown(KeyCode.J))
        {
            Destroy(currentDropJ.gameObject);
            Debug.Log("J tuşuna basıldı ve obje yok oldu!");
            currentDropJ = null; // Nesneyi sıfırla
        }
        else if (currentDropK != null && Input.GetKeyDown(KeyCode.K))
        {
            Destroy(currentDropK.gameObject);
            Debug.Log("K tuşuna basıldı ve obje yok oldu!");
            currentDropK = null; // Nesneyi sıfırla
        }
    }
}
