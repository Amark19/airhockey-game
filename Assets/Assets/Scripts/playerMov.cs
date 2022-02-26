using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    //  public List<playerMov> Players = new List<playerMov>();
     Rigidbody2D rb;

    public Collider2D PlayerCollider { get; private set; }

    public PlayerController Controller;

    public int? LockedFingerID { get; set; }

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        PlayerCollider = GetComponent<Collider2D>();

    }

    public void MoveToPosition(Vector2 position)
    {
        
        GetComponent<Rigidbody2D>().MovePosition(position);
    }
    private void OnEnable()
    {
        Controller.Players.Add(this);
    }
    // private void OnDisable()
    // {
    //     Controller.Players.Remove(this);
    // }

}
