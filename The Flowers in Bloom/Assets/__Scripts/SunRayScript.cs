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
using UnityEngine.SceneManagement;

public class SunRayScript : MonoBehaviour
{
    private Collider2D currentDropD; // İçerideki nesneyi sakla
    private Collider2D currentDropF;
    private Collider2D currentDropJ;
    private Collider2D currentDropK;
    private Collider2D currentDropLAST;
    [SerializeField] GameObject dropVFX;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("D"))
        {
            currentDropD = other;
        }
        if (other.CompareTag("F"))
        {
            currentDropF = other;
        }
        if (other.CompareTag("J"))
        {
            currentDropJ = other;
        }
        if (other.CompareTag("K"))
        {
            currentDropK = other;
        }
        if (other.CompareTag("FINISH"))
        {
            currentDropLAST = other;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other == currentDropD)
        {
            currentDropD = null; // Nesne çıktıysa sıfırla
        }
        if (other == currentDropF)
        {
            currentDropF = null; // Nesne çıktıysa sıfırla
        }
        if (other == currentDropJ)
        {
            currentDropJ = null; // Nesne çıktıysa sıfırla
        }
        if (other == currentDropK)
        {
            currentDropK = null; // Nesne çıktıysa sıfırla
        }
        if (other == currentDropLAST)
        {
            currentDropLAST = null; // Nesne çıktıysa sıfırla
        }
    }

    private void Update()
    {
        if (currentDropD != null && Input.GetKeyDown(KeyCode.D))
        {
            Destroy(currentDropD.gameObject);
            // Debug.Log("D tuşuna basıldı ve obje yok oldu!");
            GameObject vfx = Instantiate(dropVFX, transform.position + new Vector3(0, -1.95f, 0), transform.rotation);
            Destroy(vfx, 2.5f);
            currentDropD = null; // Nesneyi sıfırla
        }
        if (currentDropF != null && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(currentDropF.gameObject);
            // Debug.Log("F tuşuna basıldı ve obje yok oldu!");
            GameObject vfx = Instantiate(dropVFX, transform.position + new Vector3(0, -1.95f, 0), transform.rotation);
            Destroy(vfx, 2.5f);
            currentDropF = null; // Nesneyi sıfırla
        }
        if (currentDropJ != null && Input.GetKeyDown(KeyCode.J))
        {
            Destroy(currentDropJ.gameObject);
            // Debug.Log("J tuşuna basıldı ve obje yok oldu!");
            GameObject vfx = Instantiate(dropVFX, transform.position + new Vector3(0, -1.95f, 0), transform.rotation);
            Destroy(vfx, 2.5f);
            currentDropJ = null; // Nesneyi sıfırla
        }
        if (currentDropK != null && Input.GetKeyDown(KeyCode.K))
        {
            Destroy(currentDropK.gameObject);
            // Debug.Log("K tuşuna basıldı ve obje yok oldu!");
            GameObject vfx = Instantiate(dropVFX, transform.position + new Vector3(0, -1.95f, 0), transform.rotation);
            Destroy(vfx, 2.45f);
            currentDropK = null; // Nesneyi sıfırla
        }
        if (currentDropLAST != null && Input.GetKeyDown(KeyCode.K))
        {
            Destroy(currentDropLAST.gameObject);
            // Debug.Log("K tuşuna basıldı ve obje yok oldu!");
            GameObject vfx = Instantiate(dropVFX, transform.position + new Vector3(0, -1.95f, 0), transform.rotation);
            Destroy(vfx, 2.45f);
            SceneManager.LoadScene("Result Scene");
            currentDropK = null; // Nesneyi sıfırla
        }
        
    }
}
