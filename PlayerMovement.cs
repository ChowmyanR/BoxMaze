using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f; // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,-zValue);
    }
}
