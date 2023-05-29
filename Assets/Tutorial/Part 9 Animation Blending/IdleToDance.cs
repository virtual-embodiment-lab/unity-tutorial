using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToDance : MonoBehaviour
{
    Animator animator;
    public bool isDancing = false;
    float dancingTransition = 0.0f;
    public float acceleration = 0.1f;
    int transitionHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        transitionHash = Animator.StringToHash("dancingTransition");
    }

    // Update is called once per frame
    void Update()
    {
        if (isDancing)
        {
            animator.SetBool("isDancing", true);
        }
        else
        {
            animator.SetBool("isDancing", false);
        }

        if (Input.GetKey(KeyCode.Space) && dancingTransition < 1.0f)
        {
            dancingTransition += Time.deltaTime * acceleration;
        }
        else if (dancingTransition > 0.0f)
        {
            dancingTransition -= Time.deltaTime * acceleration;
        }

        animator.SetFloat(transitionHash, dancingTransition);
    }
}
