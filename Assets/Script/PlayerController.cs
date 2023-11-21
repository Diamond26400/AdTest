using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animation PlayerAnim;
    public Animator animator;

    private float speed = 5.0f;

    [SerializeField]
    public bool isRunning;
    public bool isRunnigBackwards;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Runnig");
            isRunning = true;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
