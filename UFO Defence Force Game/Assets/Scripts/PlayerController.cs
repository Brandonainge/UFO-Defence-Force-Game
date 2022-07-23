using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource playerAudio;
    public float horizontalInput;
    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;
    public GameObject lazerBolt;

    public GameManager gameManager;
    public AudioClip fireSound;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference GameManager script on GameManager object
    }


    // Update is called once per frame
    void Update()
    {
        // Set Horizontal Input to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keeps player within bounds 
        // Left Side Wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
         // Right Side Wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // if space bar is presssed it will fire lazerbolt
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            playerAudio.PlayOneShot(fireSound, 1.0f);
            // creates laserbolt at the blaster transform position maintaining the objects rotation.
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }

}
