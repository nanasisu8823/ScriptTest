using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss

{
    private int MP = 53;
    private int hp = 100;
    private int power = 25;
    
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");

    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic(int needMP)
    {


        if (MP >= needMP)

        {

            MP -= needMP;
            Debug.Log("魔法攻撃をした。残りMPは" + MP);
        }

        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        
    }

    public void Magic2()
    {
        if (MP>=5)
        {
            MP -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + MP);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }

    }

    public void LOG(string name)
    {
        
        {
            Debug.Log(name);

        }
        
      

    }


}





    public class boss : MonoBehaviour
    {

    

    // Start is called before the first frame update
    void Start()
        {
            Boss lastboss = new Boss();
                
           for(int i = 0; i < 11; i++)
            {
        
                       lastboss.Magic(5);            
            }

       
        lastboss.LOG("hattori");
    }

     



        // Update is called once per frame
        void Update()
        {

        }
    }
