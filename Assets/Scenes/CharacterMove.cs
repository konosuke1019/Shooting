using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    //ï‡çsë¨ìx
    private float speed = 0.5f;
    private float rotateSpeed = 0.3f;
    Animator animator;
    private float horizonralInput, verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizonralInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if (verticalInput != 0)
        {
            transform.position += transform.forward * speed * verticalInput;
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
        transform.Rotate(new Vector3(0, rotateSpeed * horizonralInput, 0));
    }   
}
