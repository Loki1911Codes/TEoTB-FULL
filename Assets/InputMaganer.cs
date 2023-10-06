using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMaganer : MonoBehaviour
{
    public AttackMngr atkM;
    public float dps = 3;
    public float damage = 5;


    // Start is called before the first frame update
    void Start()
    {
        atkM = GameObject.FindGameObjectWithTag("AtkMng").GetComponent<AttackMngr>();
    }

    

    // Update is called once per frame
    void Update()
    {
        InputCheck();
    }

    private void InputCheck()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
           //Attack
            atkM.AttackE();
           
        }else{
            atkM.canDealDamage = false;
        }
        if (Input.GetMouseButtonDown(1) == true)
        {
            //Defend
            Debug.Log("Defend");
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //Inventory
            
        }
    }


}
