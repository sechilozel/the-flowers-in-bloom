using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DropScript : MonoBehaviour
{
    [SerializeField] public float noteSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.up * noteSpeed * Time.deltaTime);
    }
}
