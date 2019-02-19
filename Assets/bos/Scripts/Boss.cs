using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour {

    public int health;
    public int damage;
    private float timeBtwDamage = 1.5f;
    public bool over;
    public GUIStyle style2;
    public Texture img;

    public Animator camAnim;
    public Slider healthBar;
    private Animator anim;
    public bool isDead;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        if (health <= 25) {
            anim.SetTrigger("stageTwo");
        }

        if (health <= 0) {
            anim.SetTrigger("death");
            Invoke("End",2.5f);
        }

        // give the player some time to recover before taking more damage !
        if (timeBtwDamage > 0) {
            timeBtwDamage -= Time.deltaTime;
        }

        healthBar.value = health;
    }
    public void End() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Final");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // deal the player damage ! 
        if (other.CompareTag("Player") && isDead == false) {
            if (timeBtwDamage <= 0) {
                camAnim.SetTrigger("shake");
                //other.GetComponent<Player>().health -= damage;
                UnityEngine.SceneManagement.SceneManager.LoadScene("Fail");
                over = true;
                
            }
        }
       
    }

    void OnGUI()
    {
        if (over)
        {
            GUI.Label(new Rect(Screen.width * 0.3f, Screen.height * 0.45f, Screen.width * 0.75f, Screen.height * 0.25f), "Game Over !", style2);
            if (GUI.Button(new Rect(Screen.width * 0.48f, Screen.height * 0.55f, 50, 50f), img))
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1;
            }
        }
    }

}
