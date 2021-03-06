﻿/*  Script: PCSettings.cs
    Author: Zackary Hoyt

    Description:
    Contains and manages the settings which define various player-related activities.
    E.g., movement speeds, mouse-sensitivity, etc.
*/

using UnityEngine;
using System.Collections;

public class PCSettings : MonoBehaviour
{
    public static PCSettings pcSettings;
    void Awake()
    {
        pcSettings = this;
    }

    //  Player Collider Layer
    public LayerMask ignoredCollisionsLM = 16128; //  used to set what the player can/cannot collide with
    //  Renderer Layer
    public LayerMask fadingObjectsLM = 6144;
    //  Interaction Layer
    public LayerMask interactableObjectsLM = 2048; //  used to filter-out non-interactable objects for raycasting

    public Vector3 spawnPoint = new Vector3(24, 1, 10);
    public Quaternion spawnRotation = new Quaternion();
    //  Player Controller Settings
    public bool canControlPlayer = true;
    //  Player Movement Settings
    public float speed = 5f,
                 accel = 25f;
    public bool instantDirChange = true;   //  instantly move in a new direction, or slow to a stop first
    bool _altitudeSoftLock = false; //  left/right and for/back movement cannot be translated into vertical movement
    public bool walkMode
    {
        get {
            return _altitudeSoftLock;
        }
        set {
            _altitudeSoftLock = GetComponent<Rigidbody>().useGravity = value;
            Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Level"), !value);
        }
    }


    //  Mouse Look Settings
    public Vector2 lookSensitivity = new Vector2(2, 2);
    public float yRotationLimit = 80;

    #region Abilities
    public float energyRegenRate = 5;

    //  Interact Settings
    public float interactReach = 5,
                 interactCD = 1f,
                 breakHoldDist = 3f,
                 pickupCost_Light = 10,
                 pickupCost_Medium = 20,
                 pickupCost_Heavy = 30;

    //  Blast Settings
    public float blastForce = 800,
                 blastLength = 8,
                 blastAngle = 30,
                 blastCD = 1f,
                 blastDecay = 0.4f,
                 blastCost = 45;
    #endregion

    //  Object Fade Settings
    public float dist_a1 = 2;

    public void reset()
    {
        transform.position = spawnPoint;
        transform.rotation = spawnRotation;

        walkMode = false;
    }
}