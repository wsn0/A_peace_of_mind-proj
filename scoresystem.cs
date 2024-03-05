using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoresystem : MonoBehaviour
{
    public int score = 0;
    public Text Scoretext;
    public AudioSource biting;
    public AudioSource miss;
    public AudioSource flushing;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider item)
    {
        if(item.tag == "onepoint")
        {
            biting.Play();
            score = score + 1;
            Scoretext.text = "SCORE :    " + score;
            Destroy(item.gameObject);
        }
        if (item.tag == "minusone")
        {
            miss.Play();
            score = score - 1;
            Scoretext.text = "SCORE :    " + score;
            Destroy(item.gameObject);
        }
        if (item.tag == "minustwo")
        {
            miss.Play();
            score = score - 2;
            Scoretext.text = "SCORE :    " + score;
            Destroy(item.gameObject);
        }
        if (item.tag == "fivepoint")
        {
            biting.Play();
            score = score + 5;
            Scoretext.text = "SCORE :    " + score;
            Destroy(item.gameObject);
            flushing.PlayDelayed(1);

        }
        if (item.tag == "twopoint")
        {
            biting.Play();
            score = score + 2;
            Scoretext.text = "SCORE :    " + score;
            Destroy(item.gameObject);
        }
    }
}
