using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox : MonoBehaviour {

    public int numberOfCoins;

    public Transform wallHitBox;

    private bool wallHit;

    public float wallHitHeight;
    public float wallHitWidth;

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);
    }
}

    //public Text countText;



    //void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp"))
         {
             other.gameObject.SetActive(false);
             count = count + 1;
             SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count;
    }

    private void OnColisionEnter2D(Collision2D collision)
    {
       if (collision.collider.tag == "Player")
       {
            Debug.Log("MONEYYY");
            SetCountText;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(wallHitBox.position, new Vector3(wallHitWidth, wallHitHeight, 1));
    }
