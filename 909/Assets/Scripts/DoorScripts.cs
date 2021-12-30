﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScripts : MonoBehaviour
{

    private Animator Anim;
    public bool IsOpen = false;
    private AudioSource MyPlayer;

    [SerializeField] AudioClip CabinSound;
    [SerializeField] AudioClip RoomSound;
    [SerializeField] AudioClip HouseSound;
    [SerializeField] bool Cabin;
    [SerializeField] bool Room;
    [SerializeField] bool House;


    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        MyPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorOpen()
    {
        if(IsOpen == false)
        {
            Anim.SetTrigger("Open");
            IsOpen = true;

            if(Cabin == true)
            {
                MyPlayer.clip = CabinSound;
                MyPlayer.Play();
            }

            if (Room == true)
            {
                MyPlayer.clip = RoomSound;
                MyPlayer.Play();
            }

            if (House == true)
            {
                MyPlayer.clip = HouseSound;
                MyPlayer.Play();
            }
        }

        else if(IsOpen == true)
        {
            Anim.SetTrigger("Close");
            IsOpen = false;

            if (IsOpen == false)
            {
                Anim.SetTrigger("Open");
                IsOpen = true;

                if (Cabin == true)
                {
                    MyPlayer.clip = CabinSound;
                    MyPlayer.Play();
                }

                if (Room == true)
                {
                    MyPlayer.clip = RoomSound;
                    MyPlayer.Play();
                }

                if (House == true)
                {
                    MyPlayer.clip = HouseSound;
                    MyPlayer.Play();
                }
            }
        }
    }
}
