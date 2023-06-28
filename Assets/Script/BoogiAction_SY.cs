using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoogiAction_SY : MonoBehaviour
{
    [SerializeField] private SpeechBubbleText_SY speechText = null;
    [SerializeField] private GameObject languageSelectButton = null;
    [SerializeField] private GameObject nextButton = null;
    public GameObject SpeechBubble = null;
    [SerializeField] private GameObject player = null;
    
    public string language = "";
    private bool isPickLanguage = false;
    public int textIndex = 0;
    public bool isClickNextButton = false;

    

    private void Awake()
    {
        if (!player) player = GameObject.FindWithTag("Player");
        speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "�� �����ϼ���.\n(Choose a Language)";
        if (nextButton.activeSelf) nextButton.SetActive(false);
        if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
    }

    private void Update()
    {
        LookPlayer();

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

    public void PlayerOnTriggerEnter(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.tag == "TouristAttraction")
        {

            if (!SpeechBubble.activeSelf) SpeechBubble.SetActive(true);
            speechText.gameObject.GetComponent<TextMeshProUGUI>().text = "";
            if (!nextButton.activeSelf) nextButton.SetActive(true);
            if (textIndex != 0) textIndex = 0;
            speechText.SetNpcTalkAni(language, other.gameObject.name);
        }
    }

    public void PlayerOnTriggerStay(Collider other)
    {
        if (language != "KOR" && language != "ENG") return;

        if (other.gameObject.tag == "TouristAttraction")       // ������� �±� ���(-)
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
    }

    public void PlayerOnTriggerExit(Collider other)
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

    private void ByeBoogi()
    { 

    }

    private void HelloBoogi()
    {

    }
}
