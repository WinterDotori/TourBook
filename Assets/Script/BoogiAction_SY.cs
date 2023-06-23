using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoogiAction_SY : MonoBehaviour
{
    [SerializeField] private SpeechBubbleText_SY speechText = null;
    [SerializeField] private GameObject languageSelectButton = null;
    public string language = "";                // ��� ��ư Ŭ�� �� �����ȴ�.
    private bool isPickLanguage = false;
    public int textIndex = 0;
    public bool isClickNextButton = false;

    private void Start()
    {
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "�� �����ϼ���.\n(Choose a Language)";
    }

    private void Update()
    {
        LookPlayer();

        if (language == "KOR" || language == "ENG")
        { 
            languageSelectButton.SetActive(false);
            isPickLanguage = true;
            if (speechText.gameObject.GetComponent<TextMeshProUGUI>().text == "�� �����ϼ���.\n(Choose a Language)")
            {
                speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "";
                speechText.gameObject.SetActive(false);
            }
        }

        // if (isPickLanguage && )
    }

    private void OnTriggerEnter(Collider other)         // ��ǳ�� ������Ʈ �ѱ�, ��� ����
    {
        if (other.gameObject.name == "�α�" || other.gameObject.name == "�λ���忢����������" ||
            other.gameObject.name == "��������" || other.gameObject.name == "�ȳ籤�ȸ�������" ||
            other.gameObject.name == "�¼���������" || other.gameObject.name == "��������Ա�" ||
            other.gameObject.name == "�Ҹ����¸��Ÿ�")
        {
            if (!speechText.gameObject.activeSelf) speechText.gameObject.SetActive(true);
            speechText.SetNpcText(language, other.gameObject.name);
        }
    }

    private void OnTriggerStay(Collider other)          // 
    {
        switch (other.gameObject.name)
        {
            case "�α�":
                {
                    if (!speechText.isTalking && isClickNextButton)
                    {
                        speechText.PlayTyping(textIndex);
                        textIndex++;
                        // PlayAni �Լ��� ����ؼ� ��縶�� �ִϸ��̼� �����ʿ�(-)
                    }
                }
                break;
            case "�λ���忢����������":
                break;
            case "��������":
                break;
            case "�ȳ籤�ȸ�������":
                break;
            case "�¼���������":
                break;
            case "��������Ա�":
                break;
            case "�Ҹ����¸��Ÿ�":
                break;
        }
    }

    private void LookPlayer()                           // �÷��̾ �ٶ󺸴� �ü�ó��(-)
    {
    }

    public void PlayAni(string _animeName)              // �ִϸ��̼� ���� ������ �ش� �ִϰ� ����Ǵ� �Լ� (-)
    {
        switch (_animeName)
        {
            case "":
                break;
        }
    }
}
