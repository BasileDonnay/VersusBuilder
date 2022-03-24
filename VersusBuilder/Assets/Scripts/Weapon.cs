using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject pistol;
    public GameObject automatic;
    public GameObject sniper;
    public GameObject bow;
    private int gunSelect = 0;
    private List<string> inventory = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        inventory.Add("Pistol");
    }

    // Update is called once per frame
    void Update()
    {
        GunSelection();
    }

    void GunSelection ()
    {
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") == -1)
        {
            gunSelect++;
            if (gunSelect >= inventory.Count)
            {
                gunSelect = 0;
            }

            ChangeActiveGun();
        }
    }

    void ChangeActiveGun()
    {
        if (inventory[gunSelect] == "Pistol")
        {
            pistol.SetActive(true);
            automatic.SetActive(false);
            sniper.SetActive(false);
            bow.SetActive(false);
        }
        if (inventory[gunSelect] == "Automatic")
        {
            pistol.SetActive(false);
            automatic.SetActive(true);
            sniper.SetActive(false);
            bow.SetActive(false);
        }
        if (inventory[gunSelect] == "Sniper")
        {
            pistol.SetActive(false);
            automatic.SetActive(false);
            sniper.SetActive(true);
            bow.SetActive(false);
        }
        if (inventory[gunSelect] == "Bow")
        {
            pistol.SetActive(false);
            automatic.SetActive(false);
            sniper.SetActive(false);
            bow.SetActive(true);
        }
    }

    public void AddGunToInventory(string gun)
    {
        if (inventory.IndexOf(gun) > 0)
        {
            
        } else
        {
            inventory.Add(gun);
        }
    }
}
