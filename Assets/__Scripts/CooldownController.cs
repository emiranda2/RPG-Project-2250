using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownController : MonoBehaviour
{

    public Image attackCooldown;
    public float cooldown = 5;
    public static bool isCooldown = false;
    public GameObject attackTimerUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W))
        {
            Cooldown();
        }
        Timer();
    }

    //Controls the punch timer fill
    void Timer()
    {
        if (isCooldown)
        {
            attackCooldown.fillAmount += 1 / cooldown * Time.deltaTime;

            if (attackCooldown.fillAmount >= 1)
            {
                attackCooldown.fillAmount = 0;
                Attack();
            }
        }
    }

    //When character can't attack this deactivates timer and cooldown
    void Cooldown()
    {
        attackTimerUI.SetActive(true);
        isCooldown = true;
    }

    //When the character can attack this deactivates the timer and cooldown
    void Attack()
    {
        attackTimerUI.SetActive(false);
        isCooldown = false;
    }
}

