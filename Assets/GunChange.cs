using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChange : MonoBehaviour
{
    public enum GunSet
    {
        Handgun,

        Shotgun,

        Rifle
    }
    public GunSet MySetGun;

    [HideInInspector]

    public Animator anim;

    public RuntimeAnimatorController[] Animators;


    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void CambioArma()
    {
        switch(MySetGun)
        {
            case GunSet.Handgun:
                anim.runtimeAnimatorController = Animators[0];
            break;

            case GunSet.Rifle:
                anim.runtimeAnimatorController = Animators[1];
            break;

            case GunSet.Shotgun:
                anim.runtimeAnimatorController = Animators[2];
            break;
        }
    }
}
