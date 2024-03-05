using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcontrol : MonoBehaviour
{
    public float speed = 0;
    public AudioSource audioSource;
    public AudioClip jumpsfx;
    private Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += Vector3.forward * speed * Time.deltaTime;
            myAnimator.Play("forward");
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += Vector3.left * speed * Time.deltaTime;
            myAnimator.Play("turnL");
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += Vector3.back * speed * Time.deltaTime;
            myAnimator.Play("back");
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += Vector3.right * speed * Time.deltaTime;
            myAnimator.Play("turnR");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            audioSource.PlayOneShot(jumpsfx);
            myAnimator.Play("jumping");
        }
    }
}