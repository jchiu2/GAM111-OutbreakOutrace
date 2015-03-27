using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    public PlayerCar Player;

    GameController Game = new GameController();

	// Use this for initialization
	void Start () {
        Player = Game.CreateNewPlayer();
	
	}
	
	// Update is called once per frame
	void Update () {

        DoPlayerMovement();
	
	}

    void DoPlayerMovement()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            
            Accelerate();

        }

        else
        {
            Deccelerate();
        }

        Player.PlayerPos.x += Player.PlayerSpeed;

        this.transform.position = Player.PlayerPos;

    }

    void Accelerate()
    {

        print("Accelerating");

        Player.PlayerSpeed = Player.PlayerSpeed += Time.deltaTime; 
    }
    
    void Deccelerate()
    {
        if(Player.PlayerSpeed > 0)
        {
            print("Decelerating");

            Player.PlayerSpeed -= Time.deltaTime;
        }
        
    }

}
