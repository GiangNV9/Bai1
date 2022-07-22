using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTapOOP2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BaseItem baseItem = new BaseItem("88", 10);
        Item item = new Item("44", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class BaseItem
    {
        public string id;
        public int unlocked;

        public BaseItem()
        {
            Debug.Log("Cha khong tham so");
        }
         public BaseItem(string id)
        {
            this.id = id;
            Debug.Log("Cha 1 tham so string ");
        }

        public BaseItem(int unlocked)
        {
            this.unlocked = unlocked;
            Debug.Log("Cha 1 tham so int");
        }

        public BaseItem(string id, int unlocked)
        {
            this.id = id;
            this.unlocked = unlocked;
            Debug.Log("Cha 2 tham so");
        }

    }

    public class Item : BaseItem
    {
        public string stat;
        public int amount;

        public Item(string stat, int amount) : base(stat, amount)
        {
            this.stat = stat;
            this.amount = amount;
            Debug.Log("Con 2 tham so");
        }

        public Item(string stat) : base(stat)
        {
            this.stat = stat;
            Debug.Log("Con 1 tham so string");
        }

        public Item(int amount) : base(amount)
        {
            this.amount = amount;
            Debug.Log("Con 1 tham so int");
        }
    }
}
