using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float speedcam;
    public Camera cam;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    [SerializeField]
    private float SpeedBullet;
    [SerializeField]
    private float TimeBullet;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (!isLocalPlayer)
        {
            return;
        }
        cam.enabled = true;

        MoviPlayer();
        
}

    //Control Player
    void MoviPlayer()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speedcam;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }

    
    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    
    [Command]
    void CmdFire()
    {
        // Create Bullet
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Speed Bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * SpeedBullet;

        NetworkServer.Spawn(bullet);
        
        Destroy(bullet, TimeBullet);
    }


}
