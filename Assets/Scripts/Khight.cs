using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Khight : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public AudioClip walkSound;
    public AudioSource Soundmaker;
    
    public AudioSource AttacksoundM;
    public AudioClip AtkSound;
    public float speed = 2;
    public bool canRun = true;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        sr.flipX = (direction < 0);
        animator.SetFloat("New Float", Mathf.Abs(direction));
        
        if(Input.GetKeyDown (0))
        {

        }

        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
            canRun = false;
            AttacksoundM.clip = AtkSound;
            AttacksoundM.Play();
        }

        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }

    }

    public void AttackHasFinished()
    {
        Debug.Log("The attack animation just finished!");
        canRun = true;
    }

    public void PuttheFootDown()
    {
        Soundmaker.clip = walkSound;
        Soundmaker.Play();
    }
}
