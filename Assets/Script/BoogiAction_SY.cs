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
    // public bool isReset

    public Animator BoogiAni = null;

    private void Awake()
    {
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "�� �����ϼ���.\n(Choose a Language)";
    }

    private void Update()
    {
        // LookPlayer();

        if (!isPickLanguage && (language == "KOR" || language == "ENG"))
        { 
            if (languageSelectButton.activeSelf) languageSelectButton.SetActive(false);
            if (speechText.gameObject.GetComponent<TextMeshProUGUI>().text == "�� �����ϼ���.\n(Choose a Language)")
            {
                speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "";
                speechText.gameObject.SetActive(false);
                isPickLanguage = true;
            }
        }


    }

    private void OnTriggerEnter(Collider other)         // ��ǳ�� ������Ʈ �ѱ�, ��� ����
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.name == "BBB")
        {
            if (textIndex != 0) textIndex = 0;       // �̰� �ȵ����µ�...;;;; 
            speechText.gameObject.SetActive(true);
            speechText.SetNpcTalkAni(language, other.gameObject.name);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        Debug.Log(other.gameObject.name);

        switch (other.gameObject.name)
        {
            case "BBB":
                {
                    if (textIndex > speechText.npcTexts.Count)
                    {
                        if (speechText.gameObject.activeSelf) speechText.gameObject.SetActive(false);
                    } 

                    if (isClickNextButton)
                    {
                        speechText.PlayTyping(textIndex);
                        textIndex++;
                        isClickNextButton = false;
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

    private void OnTriggerExit(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        if (speechText.gameObject.activeSelf) speechText.gameObject.SetActive(false);
    }

    private void LookPlayer()                           // �÷��̾ �ٶ󺸴� �ü�ó��(-)
    {
    }
}
