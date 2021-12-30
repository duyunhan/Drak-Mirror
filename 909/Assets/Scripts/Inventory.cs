using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject InventoryMenu;
    private bool InventoryActive = false;
    private AudioSource MyPlayer;
    [SerializeField] AudioClip AppleBite;
    [SerializeField] AudioClip BatteryChange;
    [SerializeField] AudioClip WeaponChange;
    [SerializeField] AudioClip Gunshot;
    [SerializeField] AudioClip Arrowshot;



    [SerializeField] GameObject PlayerArms;
    [SerializeField] GameObject Knife;
    [SerializeField] GameObject Axe;
    [SerializeField] GameObject Bat;

    //Yuan chengwuqi
    [SerializeField] GameObject Gun;
    [SerializeField] GameObject Crossbow;


    [SerializeField] Animator Anim;


    //APPLE
    [SerializeField] GameObject AppleImage1;
    [SerializeField] GameObject AppleButton1;

    [SerializeField] GameObject AppleImage2;
    [SerializeField] GameObject AppleButton2;

    [SerializeField] GameObject AppleImage3;
    [SerializeField] GameObject AppleButton3;

    [SerializeField] GameObject AppleImage4;
    [SerializeField] GameObject AppleButton4;

    [SerializeField] GameObject AppleImage5;
    [SerializeField] GameObject AppleButton5;

    [SerializeField] GameObject AppleImage6;
    [SerializeField] GameObject AppleButton6;


    //BATTERY
    [SerializeField] GameObject BatteryImage1;
    [SerializeField] GameObject BatteryButton1;

    [SerializeField] GameObject BatteryImage2;
    [SerializeField] GameObject BatteryButton2;

    [SerializeField] GameObject BatteryImage3;
    [SerializeField] GameObject BatteryButton3;

    [SerializeField] GameObject BatteryImage4;
    [SerializeField] GameObject BatteryButton4;

    //Weapom
    [SerializeField] GameObject KnifeImage;
    [SerializeField] GameObject KnifeButton;

    [SerializeField] GameObject BatImage;
    [SerializeField] GameObject BatButton;

    [SerializeField] GameObject AxeImage;
    [SerializeField] GameObject AxeButton;

    [SerializeField] GameObject GunImage;
    [SerializeField] GameObject GunButton;

    [SerializeField] GameObject CrossbowImage;
    [SerializeField] GameObject CrossbowButton;

    //AMMO
    [SerializeField] GameObject BulletsClip1lmage;
    [SerializeField] GameObject BulletsClip1Button;

    [SerializeField] GameObject BulletsClip2lmage;
    [SerializeField] GameObject BulletsClip2Button;

    [SerializeField] GameObject BulletsClip3lmage;
    [SerializeField] GameObject BulletsClip3Button;

    [SerializeField] GameObject BulletsClip4lmage;
    [SerializeField] GameObject BulletsClip4Button;

    //Arrows
    [SerializeField] GameObject ArrowImage;
    [SerializeField] GameObject ArrowButton;


    //Keys
    [SerializeField] GameObject CabinKey;
    [SerializeField] GameObject HouseKey;
    [SerializeField] GameObject RoomKey;


    // Start is called before the first frame update
    void Start()
    {
        InventoryMenu.gameObject.SetActive(false);
        InventoryActive = false;
        Cursor.visible = false;
        MyPlayer = GetComponent<AudioSource>();
     



        //APPLE
        AppleImage1.gameObject.SetActive(false);
        AppleButton1.gameObject.SetActive(false);

        AppleImage2.gameObject.SetActive(false);
        AppleButton2.gameObject.SetActive(false);

        AppleImage3.gameObject.SetActive(false);
        AppleButton3.gameObject.SetActive(false);

        AppleImage4.gameObject.SetActive(false);
        AppleButton4.gameObject.SetActive(false);

        AppleImage5.gameObject.SetActive(false);
        AppleButton5.gameObject.SetActive(false);

        AppleImage6.gameObject.SetActive(false);
        AppleButton6.gameObject.SetActive(false);

        //BATTERY
        BatteryImage1.gameObject.SetActive(false);
        BatteryButton1.gameObject.SetActive(false);

        BatteryImage2.gameObject.SetActive(false);
        BatteryButton2.gameObject.SetActive(false);

        BatteryImage3.gameObject.SetActive(false);
        BatteryButton3.gameObject.SetActive(false);

        BatteryImage4.gameObject.SetActive(false);
        BatteryButton4.gameObject.SetActive(false);

        //Weapom
        KnifeImage.gameObject.SetActive(false);
        KnifeButton.gameObject.SetActive(false);

        BatImage.gameObject.SetActive(false);
        BatButton.gameObject.SetActive(false);

        AxeImage.gameObject.SetActive(false);
        AxeButton.gameObject.SetActive(false);

        GunImage.gameObject.SetActive(false);
        GunButton.gameObject.SetActive(false);

        CrossbowImage.gameObject.SetActive(false);
        CrossbowButton.gameObject.SetActive(false);

        //AMMO
        BulletsClip1lmage.gameObject.SetActive(false);
        BulletsClip1Button.gameObject.SetActive(false);

        BulletsClip2lmage.gameObject.SetActive(false);
        BulletsClip2Button.gameObject.SetActive(false);

        BulletsClip3lmage.gameObject.SetActive(false);
        BulletsClip3Button.gameObject.SetActive(false);

        BulletsClip4lmage.gameObject.SetActive(false);
        BulletsClip4Button.gameObject.SetActive(false);

        //Arrows
        ArrowImage.gameObject.SetActive(false);
        ArrowButton.gameObject.SetActive(false);

        //Key
        CabinKey.gameObject.SetActive(false);
        HouseKey.gameObject.SetActive(false);
        RoomKey.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //INPUT I OPEN INVENTORY
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryActive == false)
            {
                InventoryMenu.gameObject.SetActive(true);
                InventoryActive = true;
                Time.timeScale = 0f;
                Cursor.visible = true;
            }
            else if (InventoryActive == true)
            {
                InventoryMenu.gameObject.SetActive(false);
                InventoryActive = false;
                Time.timeScale = 1f;
                Cursor.visible = false;
            }

        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (InventoryActive == true)
            {
                InventoryMenu.gameObject.SetActive(false);
                InventoryActive = false;
                Time.timeScale = 1f;
                Cursor.visible = false;
            }
        }

        CheckInventory();
        CheckWeapons();
        CheckKeys();
        CheckAmmo();
        
    }

    void CheckKeys()
    {
        if (SaveScript.CabinKey == true)
        {
            CabinKey.gameObject.SetActive(true);
        }
        if (SaveScript.HouseKey == true)
        {
            HouseKey.gameObject.SetActive(true);
        }
        if (SaveScript.RoomKey == true)
        {
            RoomKey.gameObject.SetActive(true);
        }
    }

    void CheckAmmo()
    {
        if (SaveScript.BulletClips == 0)
        {
            BulletsClip1lmage.gameObject.SetActive(false);
            BulletsClip1Button.gameObject.SetActive(false);

            BulletsClip2lmage.gameObject.SetActive(false);
            BulletsClip2Button.gameObject.SetActive(false);

            BulletsClip3lmage.gameObject.SetActive(false);
            BulletsClip3Button.gameObject.SetActive(false);

            BulletsClip4lmage.gameObject.SetActive(false);
            BulletsClip4Button.gameObject.SetActive(false);

        }

        if (SaveScript.BulletClips == 1)
        {
            BulletsClip1lmage.gameObject.SetActive(true);
            BulletsClip1Button.gameObject.SetActive(true);

            BulletsClip2lmage.gameObject.SetActive(false);
            BulletsClip2Button.gameObject.SetActive(false);

            BulletsClip3lmage.gameObject.SetActive(false);
            BulletsClip3Button.gameObject.SetActive(false);

            BulletsClip4lmage.gameObject.SetActive(false);
            BulletsClip4Button.gameObject.SetActive(false);

        }

        if (SaveScript.BulletClips == 2)
        {
            BulletsClip1lmage.gameObject.SetActive(true);
            BulletsClip1Button.gameObject.SetActive(false);

            BulletsClip2lmage.gameObject.SetActive(true);
            BulletsClip2Button.gameObject.SetActive(true);

            BulletsClip3lmage.gameObject.SetActive(false);
            BulletsClip3Button.gameObject.SetActive(false);

            BulletsClip4lmage.gameObject.SetActive(false);
            BulletsClip4Button.gameObject.SetActive(false);

        }

        if (SaveScript.BulletClips == 3)
        {
            BulletsClip1lmage.gameObject.SetActive(true);
            BulletsClip1Button.gameObject.SetActive(false);

            BulletsClip2lmage.gameObject.SetActive(true);
            BulletsClip2Button.gameObject.SetActive(false);

            BulletsClip3lmage.gameObject.SetActive(true);
            BulletsClip3Button.gameObject.SetActive(true);

            BulletsClip4lmage.gameObject.SetActive(false);
            BulletsClip4Button.gameObject.SetActive(false);

        }

        if (SaveScript.BulletClips == 4)
        {
            BulletsClip1lmage.gameObject.SetActive(true);
            BulletsClip1Button.gameObject.SetActive(false);

            BulletsClip2lmage.gameObject.SetActive(true);
            BulletsClip2Button.gameObject.SetActive(false);

            BulletsClip3lmage.gameObject.SetActive(true);
            BulletsClip3Button.gameObject.SetActive(false);

            BulletsClip4lmage.gameObject.SetActive(true);
            BulletsClip4Button.gameObject.SetActive(true);
        }

        if (SaveScript.ArrowRefill == false)
        {
            ArrowImage.gameObject.SetActive(false);
            ArrowButton.gameObject.SetActive(false);
        }

        if (SaveScript.ArrowRefill == true)
        {
            ArrowImage.gameObject.SetActive(true);
            ArrowButton.gameObject.SetActive(true);
        }
    }




    void CheckInventory()
    {         
        //APPLE
        if (SaveScript.Apples == 0)
        {

            AppleImage1.gameObject.SetActive(false);
            AppleButton1.gameObject.SetActive(false);

            AppleImage2.gameObject.SetActive(false);
            AppleButton2.gameObject.SetActive(false);

            AppleImage3.gameObject.SetActive(false);
            AppleButton3.gameObject.SetActive(false);

            AppleImage4.gameObject.SetActive(false);
            AppleButton4.gameObject.SetActive(false);

            AppleImage5.gameObject.SetActive(false);
            AppleButton5.gameObject.SetActive(false);

            AppleImage6.gameObject.SetActive(false);
            AppleButton6.gameObject.SetActive(false);

        }

        if (SaveScript.Apples == 1)
        {

            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);

            AppleImage2.gameObject.SetActive(false);
            AppleButton2.gameObject.SetActive(false);

            AppleImage3.gameObject.SetActive(false);
            AppleButton3.gameObject.SetActive(false);

            AppleImage4.gameObject.SetActive(false);
            AppleButton4.gameObject.SetActive(false);

            AppleImage5.gameObject.SetActive(false);
            AppleButton5.gameObject.SetActive(false);

            AppleImage6.gameObject.SetActive(false);
            AppleButton6.gameObject.SetActive(false);
        }
        
        //apple 2
        if (SaveScript.Apples == 2)
        {

            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);

            AppleImage2.gameObject.SetActive(true);
            AppleButton2.gameObject.SetActive(true);

            AppleImage3.gameObject.SetActive(false);
            AppleButton3.gameObject.SetActive(false);

            AppleImage4.gameObject.SetActive(false);
            AppleButton4.gameObject.SetActive(false);

            AppleImage5.gameObject.SetActive(false);
            AppleButton5.gameObject.SetActive(false);

            AppleImage6.gameObject.SetActive(false);
            AppleButton6.gameObject.SetActive(false);
        }

        if (SaveScript.Apples == 3)
        {

            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);

            AppleImage2.gameObject.SetActive(true);
            AppleButton2.gameObject.SetActive(true);

            AppleImage3.gameObject.SetActive(true);
            AppleButton3.gameObject.SetActive(true);

            AppleImage4.gameObject.SetActive(false);
            AppleButton4.gameObject.SetActive(false);

            AppleImage5.gameObject.SetActive(false);
            AppleButton5.gameObject.SetActive(false);

            AppleImage6.gameObject.SetActive(false);
            AppleButton6.gameObject.SetActive(false);
        }

        if (SaveScript.Apples == 4)
        {

            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);

            AppleImage2.gameObject.SetActive(true);
            AppleButton2.gameObject.SetActive(true);

            AppleImage3.gameObject.SetActive(true);
            AppleButton3.gameObject.SetActive(true);

            AppleImage4.gameObject.SetActive(true);
            AppleButton4.gameObject.SetActive(true);

            AppleImage5.gameObject.SetActive(false);
            AppleButton5.gameObject.SetActive(false);

            AppleImage6.gameObject.SetActive(false);
            AppleButton6.gameObject.SetActive(false);
        }

        if (SaveScript.Apples == 5)
        {

            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);

            AppleImage2.gameObject.SetActive(true);
            AppleButton2.gameObject.SetActive(true);

            AppleImage3.gameObject.SetActive(true);
            AppleButton3.gameObject.SetActive(true);

            AppleImage4.gameObject.SetActive(true);
            AppleButton4.gameObject.SetActive(true);

            AppleImage5.gameObject.SetActive(true);
            AppleButton5.gameObject.SetActive(true);

            AppleImage6.gameObject.SetActive(false);
            AppleButton6.gameObject.SetActive(false);
        }

        if (SaveScript.Apples == 6)
        {

            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);

            AppleImage2.gameObject.SetActive(true);
            AppleButton2.gameObject.SetActive(true);

            AppleImage3.gameObject.SetActive(true);
            AppleButton3.gameObject.SetActive(true);

            AppleImage4.gameObject.SetActive(true);
            AppleButton4.gameObject.SetActive(true);

            AppleImage5.gameObject.SetActive(true);
            AppleButton5.gameObject.SetActive(true);

            AppleImage6.gameObject.SetActive(true);
            AppleButton6.gameObject.SetActive(true);
        }
        //Batteries
        if (SaveScript.Batteries == 0)
        {
            BatteryImage1.gameObject.SetActive(false);
            BatteryButton1.gameObject.SetActive(false);

            BatteryImage2.gameObject.SetActive(false);
            BatteryButton2.gameObject.SetActive(false);

            BatteryImage3.gameObject.SetActive(false);
            BatteryButton3.gameObject.SetActive(false);

            BatteryImage4.gameObject.SetActive(false);
            BatteryButton4.gameObject.SetActive(false);
        }

        if (SaveScript.Batteries == 1)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(true);

            BatteryImage2.gameObject.SetActive(false);
            BatteryButton2.gameObject.SetActive(false);

            BatteryImage3.gameObject.SetActive(false);
            BatteryButton3.gameObject.SetActive(false);

            BatteryImage4.gameObject.SetActive(false);
            BatteryButton4.gameObject.SetActive(false);
        }
        if (SaveScript.Batteries == 2)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(true);

            BatteryImage2.gameObject.SetActive(true);
            BatteryButton2.gameObject.SetActive(true);

            BatteryImage3.gameObject.SetActive(false);
            BatteryButton3.gameObject.SetActive(false);

            BatteryImage4.gameObject.SetActive(false);
            BatteryButton4.gameObject.SetActive(false);
        }
        if (SaveScript.Batteries == 3)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(true);

            BatteryImage2.gameObject.SetActive(true);
            BatteryButton2.gameObject.SetActive(true);

            BatteryImage3.gameObject.SetActive(true);
            BatteryButton3.gameObject.SetActive(true);

            BatteryImage4.gameObject.SetActive(false);
            BatteryButton4.gameObject.SetActive(false);
        }
        if (SaveScript.Batteries == 4)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(true);

            BatteryImage2.gameObject.SetActive(true);
            BatteryButton2.gameObject.SetActive(true);

            BatteryImage3.gameObject.SetActive(true);
            BatteryButton3.gameObject.SetActive(true);

            BatteryImage4.gameObject.SetActive(true);
            BatteryButton4.gameObject.SetActive(true);

        }
    }



    void CheckWeapons()
    { 
        if(SaveScript.knife == true)
        {
            KnifeImage.gameObject.SetActive(true);
            KnifeButton.gameObject.SetActive(true);
        }

        if(SaveScript.Bat == true)
        {
            BatImage.gameObject.SetActive(true);
            BatButton.gameObject.SetActive(true);
        }

        if(SaveScript.Axe == true)
        {
            AxeImage.gameObject.SetActive(true);
            AxeButton.gameObject.SetActive(true);
        }

        if(SaveScript.Gun == true)
        {
            GunImage.gameObject.SetActive(true);
            GunButton.gameObject.SetActive(true);
        }

        if(SaveScript.Crossbow == true)
        {
            CrossbowImage.gameObject.SetActive(true);
            CrossbowButton.gameObject.SetActive(true);
        }
    }

    //Health 
    public void HealthUpdate()
    {
        if(SaveScript.PlayerHealth < 100)
        {
            SaveScript.PlayerHealth += 10;
            SaveScript.HealthChanged = true;
            SaveScript.Apples -= 1;
            MyPlayer.clip = AppleBite;
            MyPlayer.Play();
        }

        if(SaveScript.PlayerHealth > 100)
        {
            SaveScript.PlayerHealth = 100;
        }
    }


    //Buarry power
    public void BatteryUpdate()
    {
        SaveScript.BatteryRefill = true;
        SaveScript.Batteries -= 1;
        SaveScript.BatteryPower += 1;

        MyPlayer.clip = BatteryChange;
        MyPlayer.Play();
    }

    //using knife
    public void AssignKnife()
    {
        PlayerArms.gameObject.SetActive(true);
        Knife.gameObject.SetActive(true);
        MyPlayer.clip = WeaponChange;
        MyPlayer.Play();
        Anim.SetBool("Melee", true);
    }

    //using bat
    public void AssignBat()
    {
        PlayerArms.gameObject.SetActive(true);
        Bat.gameObject.SetActive(true);
        MyPlayer.clip = WeaponChange;
        MyPlayer.Play();
        //animation using bat when melee true;
        Anim.SetBool("Melee", true);
    }
    //using axe
    public void AssignAxe()
    {
        PlayerArms.gameObject.SetActive(true);
        Axe.gameObject.SetActive(true);
        MyPlayer.clip = WeaponChange;
        MyPlayer.Play();
        //animation using axe when melee equal flase
        Anim.SetBool("Melee", true);
    }

    public void AssignGun()
    {
        PlayerArms.gameObject.SetActive(true);
        Gun.gameObject.SetActive(true);
        MyPlayer.clip = Gunshot;
        MyPlayer.Play();
        //animation using gun when melee equal true;
        Anim.SetBool("Melee", false);
    }

    public void AssignCrossbow()
    {
        PlayerArms.gameObject.SetActive(true);
        Crossbow.gameObject.SetActive(true);
        MyPlayer.clip = Arrowshot;
        MyPlayer.Play();
        //animtion using crossbow when melee equal false;
        Anim.SetBool("Melee", false);

    }


    //weapon off
    public void WeaponOff()
    {
        Bat.gameObject.SetActive(false);
        Axe.gameObject.SetActive(false);
        Knife.gameObject.SetActive(false);
        Gun.gameObject.SetActive(false);
        Crossbow.gameObject.SetActive(false);
    }
}


