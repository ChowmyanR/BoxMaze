using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool canMove = true;
   [SerializeField] float moveSpeed = 10f; // Start is called before the first frame update
    

    // Update is called once per ajay
    void Update()
    {
        if(canMove){
            float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

            transform.Translate(xValue,0,-zValue);
        }
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            canMove = false;
        }
    }
}
