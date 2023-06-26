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

    public GameObject SpeechBubble = null;
    [SerializeField] private GameObject nextButton = null;

    private void Awake()
    {
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "�� �����ϼ���.\n(Choose a Language)";
        if (nextButton.activeSelf) nextButton.SetActive(false);
        if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
    }

    private void Update()
    {
        // LookPlayer();

        if (!isPickLanguage && (language == "KOR" || language == "ENG"))
        { 
            if (languageSelectButton.activeSelf) languageSelectButton.SetActive(false);
            if (speechText.gameObject.GetComponent<TextMeshProUGUI>().text == "�� �����ϼ���.\n(Choose a Language)")
            {
                if (SpeechBubble.activeSelf) SpeechBubble.SetActive(false);
                isPickLanguage = true;
            }
        }


    }

    private void OnTriggerEnter(Collider other)         // ��ǳ�� ������Ʈ �ѱ�, ��� ����
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.name == "BBB")
        {
            if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
            speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "";
            if (!nextButton.activeSelf) nextButton.SetActive(true);
            if (textIndex != 0) textIndex = 0;
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
                    if (!isClickNextButton && textIndex == 0)
                    {
                        if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
                        speechText.PlayTyping(textIndex);
                        textIndex++;
                    } 

                    if (isClickNextButton)
                    {
                        isClickNextButton = false;
                        speechText.PlayTyping(textIndex);
                        speechText.PlayAnim(other.gameObject.name, textIndex);
                        textIndex++;
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

        if (SpeechBubble.activeSelf) SpeechBubble.SetActive(false);
        if (textIndex != 0) textIndex = 0;
    }

    private void LookPlayer()                           // �÷��̾ �ٶ󺸴� �ü�ó��(-)
    {
    }
}
