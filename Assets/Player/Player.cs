using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTS;

public class Player : MonoBehaviour
{
    public string username;
    public bool isHuman;

    public Hud hud;

    public WorldObject SelectedObject { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        hud = GetComponentInChildren<Hud>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
