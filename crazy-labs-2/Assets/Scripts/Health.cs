using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public AudioSource dmgSound;
    public GameObject getHitScreenImage;

    public int health;
    public int healthNumb;

    public Image[] hearts;
    public Sprite redHeart;
    public Sprite grayHeart;

    private void Start()
    {
        dmgSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {

            if (health > healthNumb)
            {
                health = healthNumb;
            }

            if (i < health)
            {
                hearts[i].sprite = redHeart;
            } else
            {
                hearts[i].sprite = grayHeart;
            }


            if (i < healthNumb)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }


            if (getHitScreenImage != null)
            {
                if (getHitScreenImage.GetComponent<Image>().color.a > 0)
                {
                    var color = getHitScreenImage.GetComponent<Image>().color;
                    color.a -= 0.01f;

                    getHitScreenImage.GetComponent<Image>().color = color;
                }
            }



        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")             
        {
            collision.gameObject.SetActive(false);
            health = health - 1;
            dmgSound.Play();
            damageBlink();
            Debug.Log("HIT");

            if (health == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    private void damageBlink()
    {
        var color = getHitScreenImage.GetComponent<Image>().color;
        color.a = 1f;

        getHitScreenImage.GetComponent<Image>().color = color;
    }
}