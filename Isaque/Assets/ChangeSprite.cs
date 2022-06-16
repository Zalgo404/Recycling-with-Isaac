using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    Animator anim;
    public int jooj = 0;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            jooj++;
            if (jooj == 5)
            {
                jooj = 0;
            }
            anim.SetInteger("Choosen", jooj);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            jooj--;
            if (jooj == -1)
            {
                jooj = 4;
            }
            anim.SetInteger("Choosen", jooj);
        }
    }
}
