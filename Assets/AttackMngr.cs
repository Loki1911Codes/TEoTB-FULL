using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
//IMPORTANT: THIS CODE IS NOT WORKING PROPERLY AND IS UNDER DEVOLOPEMENT
public class AttackMngr : MonoBehaviour
{
    public Transform objectTransform;
    public Transform Player;
    public Transform Hitbox;
    public float distance;
    public float sensitivity = 0.5f;
    
    public bool canDealDamage = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
        Debug.Log(canDealDamage);
        float distance = UnityEngine.Vector3.Distance(Player.position, Hitbox.position);
    }

    private void FollowMouse()
    {
        UnityEngine.Vector3 mousePos = Input.mousePosition;
        UnityEngine.Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        worldMousePos.z = 0;
        transform.position = UnityEngine.Vector3.Lerp(transform.position, worldMousePos, sensitivity * Time.deltaTime);
    }

    public void AttackE()
    {
        if (distance <= 20f)
        {
            canDealDamage = true;
            
        }
        else{
            canDealDamage = false;
        }
    }
}
