using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillBarController : MonoBehaviour
{
    public Image imageCooldownA;
    public Image imageCooldownZ;
    public Image imageCooldownE;
    public Image imageCooldownR;
    public PlayerController player;
    bool isCooldownA;
    bool isCooldownZ;
    bool isCooldownE;
    bool isCooldownR;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a") & (player.target != null))
        {
            isCooldownA = true;
        }

        if (isCooldownA)
        {
            imageCooldownA.fillAmount += 1 / player.spell1.cooldown * Time.deltaTime;

            if (imageCooldownA.fillAmount >= 1)
            {
                imageCooldownA.fillAmount = 0;
                isCooldownA = false;

            }
        }

        if (Input.GetKeyDown("z") & (player.target != null))
        {
            isCooldownZ = true;
        }

        if (isCooldownZ)
        {
            imageCooldownZ.fillAmount += 1 / player.spell2.cooldown * Time.deltaTime;

            if (imageCooldownZ.fillAmount >= 1)
            {
                imageCooldownZ.fillAmount = 0;
                isCooldownZ = false;

            }
        }

        if (Input.GetKeyDown("e") & (player.target != null))
        {
            isCooldownE = true;
        }

        if (isCooldownE)
        {
            imageCooldownE.fillAmount += 1 / player.spell3.cooldown * Time.deltaTime;

            if (imageCooldownE.fillAmount >= 1)
            {
                imageCooldownE.fillAmount = 0;
                isCooldownE = false;

            }
        }

        if (Input.GetKeyDown("r") & (player.target != null))
        {
            isCooldownR = true;
        }

        if (isCooldownR)
        {
            imageCooldownR.fillAmount += 1 / player.spell4.cooldown * Time.deltaTime;

            if (imageCooldownR.fillAmount >= 1)
            {
                imageCooldownR.fillAmount = 0;
                isCooldownR = false;

            }
        }
    }
}
