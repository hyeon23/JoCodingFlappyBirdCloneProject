using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlienMove : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anime;
    AudioSource audi;

    // Start is called before the first frame update

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        audi = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            
            rigid.velocity = Vector2.up * 5;
            anime.SetBool("IsJumping", true);
            Invoke("CallInvoke", 0.4f);
            audi.Play();
        }
        
    }

    private void FixedUpdate()
    {
        
    }

    public void CallInvoke()
    {
        anime.SetBool("IsJumping", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOverScene");
        if(Score.bestScore < Score.score)
        {
            Score.bestScore = Score.score;
        }
    }
}
