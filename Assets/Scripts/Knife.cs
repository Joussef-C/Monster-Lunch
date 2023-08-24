using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public Animator KnifeAnimator;
    public bool isCutting;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public void SetCuttingState (bool state)
    {
        isCutting = state;
        
            KnifeAnimator.SetBool("isCutting", state);
        
    }
    void FixedUpdate()
    {

        if(Input.GetMouseButton(0) && isCutting == false)
        {
            SetCuttingState(true);

        }
        else
        {
            SetCuttingState(false);
        }
    }
}
