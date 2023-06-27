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

    public GameObject SpeechBubble = null;
    [SerializeField] private GameObject nextButton = null;
    [SerializeField] private GameObject player = null;

    private void Awake()
    {
        if (!player) player = GameObject.FindWithTag("Player");
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "언어를 선택하세요.\n(Choose a Language)";
        if (nextButton.activeSelf) nextButton.SetActive(false);
        if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
    }

    private void Update()
    {
        LookPlayer();

        if (!isPickLanguage && (language == "KOR" || language == "ENG"))
        { 
            if (languageSelectButton.activeSelf) languageSelectButton.SetActive(false);
            if (speechText.gameObject.GetComponent<TextMeshProUGUI>().text == "언어를 선택하세요.\n(Choose a Language)")
            {
                if (SpeechBubble.activeSelf) SpeechBubble.SetActive(false);
                isPickLanguage = true;
            }
        }


    }

    private void OnTriggerEnter(Collider other)         // 말풍선 오브젝트 켜기, 대사 설정
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
                        speechText.PlayAnim(textIndex);
                        textIndex++;
                    } 

                    if (isClickNextButton)
                    {
                        isClickNextButton = false;
                        speechText.PlayTyping(textIndex);
                        speechText.PlayAnim(textIndex);
                        textIndex++;
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

        if (SpeechBubble.activeSelf) SpeechBubble.SetActive(false);
        if (textIndex != 0) textIndex = 0;
    }

    private void LookPlayer()
    {
        Vector3 dir = transform.position - player.transform.position;
        dir.y = 0;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 3f);

    }
}
