using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueManager : MonoBehaviour
{
    public MathManager manager;
    public GameObject selectCard = null;

    public int value;
    public int reserveValue;

    void Start()
    {
        StartCoroutine(getValue());
    }

    IEnumerator getValue()
    {
        yield return new WaitForSeconds(0.1f);
        switch (selectCard.name)
        {
            case "first":
                {
                    value = manager.firstNumber;
                    break;
                }
            case "second":
                {
                    value = manager.secondNumber;
                    break;
                }
            case "sum":
                {
                    value = manager.sum;
                    break;
                }
        }
    }

    // ������ �� ���� �޴� �Լ�
    public void ReceiveValue(int detectedValue)
    {
        reserveValue = detectedValue;
        // ������ ���� ���� ó�� ���� �ۼ�
        Debug.Log("Received value: " + reserveValue);
    }
}