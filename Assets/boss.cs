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
        Debug.Log(this.power + "�̃_���[�W��^����");

    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }

    public void Magic(int needMP)
    {


        if (MP >= needMP)

        {

            MP -= needMP;
            Debug.Log("���@�U���������B�c��MP��" + MP);
        }

        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
        
    }

    public void Magic2()
    {
        if (MP>=5)
        {
            MP -= 5;
            Debug.Log("���@�U���������B�c��MP��" + MP);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
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
