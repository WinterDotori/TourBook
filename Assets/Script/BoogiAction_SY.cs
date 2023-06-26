using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoogiAction_SY : MonoBehaviour
{
    [SerializeField] private SpeechBubbleText_SY speechText = null;
    [SerializeField] private GameObject languageSelectButton = null;
    public string language = "";                // 언어 버튼 클릭 시 설정된다.
    private bool isPickLanguage = false;
    public int textIndex = 0;
    public bool isClickNextButton = false;
    // public bool isReset

    public Animator BoogiAni = null;

    private void Awake()
    {
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "언어를 선택하세요.\n(Choose a Language)";
    }

    private void Update()
    {
        // LookPlayer();

        if (!isPickLanguage && (language == "KOR" || language == "ENG"))
        { 
            if (languageSelectButton.activeSelf) languageSelectButton.SetActive(false);
            if (speechText.gameObject.GetComponent<TextMeshProUGUI>().text == "언어를 선택하세요.\n(Choose a Language)")
            {
                speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "";
                speechText.gameObject.SetActive(false);
                isPickLanguage = true;
            }
        }


    }

    private void OnTriggerEnter(Collider other)         // 말풍선 오브젝트 켜기, 대사 설정
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.name == "BBB")
        {
            if (textIndex != 0) textIndex = 0;       // 이거 안들어오는데...;;;; 
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
            case "부산월드엑스포조형물":
                break;
            case "달팽이톡":
                break;
            case "안녕광안리조형물":
                break;
            case "좌수영어방놀이":
                break;
            case "어방축제입구":
                break;
            case "소망등태마거리":
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        if (speechText.gameObject.activeSelf) speechText.gameObject.SetActive(false);
    }

    private void LookPlayer()                           // 플레이어를 바라보는 시선처리(-)
    {
    }
}
