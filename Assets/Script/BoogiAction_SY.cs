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

    private void Start()
    {
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "언어를 선택하세요.\n(Choose a Language)";
    }

    private void Update()
    {
        LookPlayer();

        if (language == "KOR" || language == "ENG")
        { 
            languageSelectButton.SetActive(false);
            isPickLanguage = true;
            if (speechText.gameObject.GetComponent<TextMeshProUGUI>().text == "언어를 선택하세요.\n(Choose a Language)")
            {
                speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "";
                speechText.gameObject.SetActive(false);
            }
        }

        // if (isPickLanguage && )
    }

    private void OnTriggerEnter(Collider other)         // 말풍선 오브젝트 켜기, 대사 설정
    {
        if (other.gameObject.name == "부기" || other.gameObject.name == "부산월드엑스포조형물" ||
            other.gameObject.name == "달팽이톡" || other.gameObject.name == "안녕광안리조형물" ||
            other.gameObject.name == "좌수영어방놀이" || other.gameObject.name == "어방축제입구" ||
            other.gameObject.name == "소망등태마거리")
        {
            if (!speechText.gameObject.activeSelf) speechText.gameObject.SetActive(true);
            speechText.SetNpcText(language, other.gameObject.name);
        }
    }

    private void OnTriggerStay(Collider other)          // 
    {
        switch (other.gameObject.name)
        {
            case "부기":
                {
                    if (!speechText.isTalking && isClickNextButton)
                    {
                        speechText.PlayTyping(textIndex);
                        textIndex++;
                        // PlayAni 함수를 사용해서 대사마다 애니메이션 설정필요(-)
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

    private void LookPlayer()                           // 플레이어를 바라보는 시선처리(-)
    {
    }

    public void PlayAni(string _animeName)              // 애니메이션 명을 넣으면 해당 애니가 시행되는 함수 (-)
    {
        switch (_animeName)
        {
            case "":
                break;
        }
    }
}
