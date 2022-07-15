using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiTapMang : MonoBehaviour
{
    int [] arr1 = {1, 2, 4, 2, 6, 1, 7, 8, 6, 5};
    int[,] arr2 =
    {
        {1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
        {7, 3, 1, 9, 1, 8, 6, 10, 11, 17},
        {10, 21, 1, 3, 5, 9, 2, 4, 12, 18}
    };

    // Start is called before the first frame update
    void Start()
    {
        BTMang();
        Debug.Log(BTMangTVGT());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BTMang()
    {
        string str1 = "", str2 = "";
        int sum1 = 0, sumpr1 = 1;
        for (int i = 0; i < arr1.Length; i++)
        {
            sum1 += arr1[i];
            sumpr1 *= arr1[i];
            if (arr1[i] % 2 == 0) str1 += arr1[i] + " ";
            else str2 += arr1[i] + " ";
        }
        Debug.Log($"Cac so chan trong mang 1 chieu la {str1}");
        Debug.Log($"Cac so le trong mang 1 chieu la {str2}");
        Debug.Log($"Tong cac so trong mang 1 chieu la {sum1}");
        Debug.Log($"Tich cac so trong mang 1 chieu la {sumpr1}");

        string str3 = "", str4 = "";
        int sum2 = 0; 
        long sumpr2 = 1;
        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                sum2 += arr2[j, k];
                sumpr2 *= arr2[j, k];
                if (arr2[j, k] % 2 == 0) str3 += arr2[j, k] + " ";
                else str4 += arr2[j, k] + " ";
            }
        };
        Debug.Log($"Cac so chan trong mang 2 chieu la {str3}");
        Debug.Log($"Cac so le trong mang 2 chieu la {str4}");
        Debug.Log($"Tong cac so trong mang 2 chieu la {sum2}");
        Debug.Log($"Tich cac so trong mang 2 chieu la {sumpr2}");
    }

    string BTMangTVGT()
    {
        string ketQua, str1 = "", str2 = "";
        int sum1 = 0, sumpr1 = 1;
        for (int i = 0; i < arr1.Length; i++)
        {
            sum1 += arr1[i];
            sumpr1 *= arr1[i];
            if (arr1[i] % 2 == 0) str1 += arr1[i] + " ";
            else str2 += arr1[i] + " ";
        }

        string str3 = "", str4 = "";
        int sum2 = 0;
        long sumpr2 = 1;
        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                sum2 += arr2[j, k];
                sumpr2 *= arr2[j, k];
                if (arr2[j, k] % 2 == 0) str3 += arr2[j, k] + " ";
                else str4 += arr2[j, k] + " ";
            }
        }
        ketQua = $"Cac so chan trong mang 1 chieu la { str1}\n" +
            $"Cac so le trong mang 1 chieu la {str2}\n" +
            $"Tong cac so trong mang 1 chieu la {sum1}\n" +
            $"Tich cac so trong mang 1 chieu la {sumpr1}\n" +
            $"Cac so chan trong mang 2 chieu la { str3}\n" +
            $"Cac so le trong mang 2 chieu la {str4}\n" +
            $"Tong cac so trong mang 2 chieu la {sum2}\n" +
            $"Tich cac so trong mang 2 chieu la { sumpr2}";
        return ketQua;
    }

}
