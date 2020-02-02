using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public enum State {
        HAPPY,
        AFRAID,
        PANIC,
        HOPELESS
    };
    State current_state = State.HAPPY;
    Animator ac;

    void Awake()
    {
        ac = GetComponent<Animator>();
    }

    public void Hit()
    {
        switch(current_state) {
            case State.HAPPY:
                Shock();
                break;
            case State.AFRAID:
                Panic();
                break;
        }
    }

    void Shock()
    {
        current_state = State.AFRAID;
        ac.SetTrigger("stop_walk");
    }

    void Panic()
    {
        current_state = State.PANIC;
        ac.SetTrigger("crawl_back");
    }
}
