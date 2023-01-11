using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using BulletHell;

public class PlayerTrigger : MonoBehaviour
{
    public PlayableDirector director;
    protected bool m_AlreadyTriggered;
    public PlayerMovement playerMove;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(m_AlreadyTriggered)
            return;
        director.Play();
        m_AlreadyTriggered = true;
        playerMove.enabled = false;
        playerMove.GetComponent<Animator>().speed = 0;
        Invoke("FinishInvoke", (float)director.duration);
    }

    void FinishInvoke()
    {
        playerMove.enabled = true;
        playerMove.GetComponent<Animator>().speed = 1;
    }
}
