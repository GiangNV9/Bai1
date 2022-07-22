using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTapOOP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PC pc = new PC("TrungQuoc", 8, "I3");
        pc.KhoiDong();
        pc.TatMay();
        pc.EpXung();
        pc.TruyenNhanDuLieu();
        PC.diaChiWifi = "88888";
        Debug.Log(PC.diaChiWifi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class PC
    {
        public string casePC;
        public string mainBoard;
        public int ram;
        public string cpu;
        public string nguon;
        public string tanNhiet;
        public string fan;

        public static string diaChiWifi;
        public static float tocDoWifi;
        public static string chuSoHuu;

        public PC(string casePC, int ram,string cpu)
        {
            this.casePC = casePC;
            this.ram = ram;
            this.cpu = cpu;
            Debug.Log($"Thong so case va ram : {casePC}, {ram}, {cpu}");
        }

        ~PC()
        {

        }

        public void KhoiDong()
        {
            Debug.Log("Khoi dong");
        }

        public void TatMay()
        {
            Debug.Log("Tat may");
        }

        public void EpXung()
        {
            Debug.Log("Ep xung");
        }

        public void TruyenNhanDuLieu()
        {
            Debug.Log("Truyen nhan du lieu");
        }
    }
}
