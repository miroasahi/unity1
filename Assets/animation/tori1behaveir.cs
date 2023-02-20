using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tori1behaveir : MonoBehaviour
{
    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに移動X軸
        if (transform.position.x > -8.0f)
        {
            transform.Translate(-0.008f, 0, 0);
        }

        //フレームごとに移動Y軸
        if (transform.position.y > -15.0f)
        {
            transform.Translate(0, -0.0027f, 0);
        }

        //アニメーション開始
        if (transform.position.y < -15.0f)
        {
            anim.SetBool("attack.T", true);
        }
        else
        {
            anim.SetBool("attack.T", false);
        }

        
    }
}
