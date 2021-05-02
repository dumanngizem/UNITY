using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kure_hareket : MonoBehaviour
{
    Vector3 yon;
    public float hiz;

    // Start is called before the first frame update
    void Start()
    {
        yon = Vector3.forward;
        //0 0 1 yönünde gitmek demektir.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //mousun sol tuşuna basıldıysa
            if(yon.x == 0)
            {
                //z yönünde gidiyorum demek x e çeviriyorum
                yon = Vector3.left;
            }
            else
            {
                //yani x yönünde gidiyorum z ye çeviriyorum mouse basınca
                yon = Vector3.forward;
            }
            //z bizim forwardımız x bizim leftimiz olarak düşünün
        }
    }
    void FixedUpdate()
    {
        Vector3 kure_move = yon * Time.deltaTime * hiz;
        transform.position += kure_move;
    }
}
