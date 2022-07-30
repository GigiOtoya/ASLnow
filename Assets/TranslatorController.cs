using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TranslatorController : MonoBehaviour
{
    public Text translateFromText;
    public Text translateToText;
    public Text englishInput;
    public TextMeshProUGUI aslSignsInput;
    public TextMeshProUGUI translationOutputText;

    public GameObject aslKeyboardPanel;
    public GameObject signsInputText;
    public GameObject englishInputText;
    public GameObject aslKeyboardButton;

    public GameObject inputPanel;
    public GameObject outPanel;

    string currentASLSigns = null;
    string currentASLTranslation = null;
    string currentEnglishText = null;

    public void openTranslatorPanel() {

        translateFromText.text = "English";
        translateToText.text = "ASL";

        signsInputText.SetActive(false);
        englishInputText.SetActive(true);
        aslKeyboardPanel.SetActive(false);
        aslKeyboardButton.SetActive(false);

        inputPanel.GetComponent<Image>().color = new Color32(65,170,245,255);
        outPanel.GetComponent<Image>().color = new Color32(255,255,255,255);

    }

    public void openASLKeyboard() {
        aslKeyboardPanel.SetActive(true);
        aslKeyboardButton.SetActive(false);
    }

    public void switchTranslation() {

        if(translateFromText.text == "English") {
            translateFromText.text = "ASL";
            translateToText.text = "English";

            signsInputText.SetActive(true);
            englishInputText.SetActive(false);
            aslKeyboardPanel.SetActive(false);
            aslKeyboardButton.SetActive(true);

            inputPanel.GetComponent<Image>().color = new Color32(255,255,255,255);
            outPanel.GetComponent<Image>().color = new Color32(65,170,245,255);
        }
        else if(translateFromText.text == "ASL") {

            translateFromText.text = "English";
            translateToText.text = "ASL";

            signsInputText.SetActive(false);
            englishInputText.SetActive(true);
            aslKeyboardPanel.SetActive(false);
            aslKeyboardButton.SetActive(false);

            inputPanel.GetComponent<Image>().color = new Color32(65,170,245,255);
            outPanel.GetComponent<Image>().color = new Color32(255,255,255,255);

        }

        englishInput.text = "";
        aslSignsInput.text = "";
        translationOutputText.text = "";
    }

    string englishToASL = null;
    // Update is called once per frame
    void Update()
    {
        if(translateFromText.text == "English") {
            if(currentEnglishText != englishInput.text.ToString()) {

                currentEnglishText = englishInput.text.ToString();
                englishToASL = null;
                char ch;
                foreach(char c in currentEnglishText)
                {
                    ch = Char.ToLower(c);
                    switch (ch)
                    {
                        case 'a':
                            englishToASL += "<sprite name=" + "sign_a" + ">";
                            break;
                        case 'b':
                            englishToASL += "<sprite name=" + "sign_b" + ">";
                            break;
                        case 'c':
                            englishToASL += "<sprite name=" + "sign_c" + ">";
                            break;
                        case 'd':
                            englishToASL += "<sprite name=" + "sign_d" + ">";
                            break;
                        case 'e':
                            englishToASL += "<sprite name=" + "sign_e" + ">";
                            break;
                        case 'f':
                            englishToASL += "<sprite name=" + "sign_f" + ">";
                            break;
                        case 'g':
                            englishToASL += "<sprite name=" + "sign_g" + ">";
                            break;
                        case 'h':
                            englishToASL += "<sprite name=" + "sign_h" + ">";
                            break;
                        case 'i':
                            englishToASL += "<sprite name=" + "sign_i" + ">";
                            break;
                        case 'j':
                            englishToASL += "<sprite name=" + "sign_j" + ">";
                            break;
                        case 'k':
                            englishToASL += "<sprite name=" + "sign_k" + ">";
                            break;
                        case 'l':
                            englishToASL += "<sprite name=" + "sign_l" + ">";
                            break;
                        case 'm':
                            englishToASL += "<sprite name=" + "sign_m" + ">";
                            break;
                        case 'n':
                            englishToASL += "<sprite name=" + "sign_n" + ">";
                            break;
                        case 'o':
                            englishToASL += "<sprite name=" + "sign_o" + ">";
                            break;
                        case 'p':
                            englishToASL += "<sprite name=" + "sign_p" + ">";
                            break;
                        case 'q':
                            englishToASL += "<sprite name=" + "sign_q" + ">";
                            break;
                        case 'r':
                            englishToASL += "<sprite name=" + "sign_r" + ">";
                            break;
                        case 's':
                            englishToASL += "<sprite name=" + "sign_s" + ">";
                            break;
                        case 't':
                            englishToASL += "<sprite name=" + "sign_t" + ">";
                            break;
                        case 'u':
                            englishToASL += "<sprite name=" + "sign_u" + ">";
                            break;
                        case 'v':
                            englishToASL += "<sprite name=" + "sign_v" + ">";
                            break;
                        case 'w':
                            englishToASL += "<sprite name=" + "sign_w" + ">";
                            break;
                        case 'x':
                            englishToASL += "<sprite name=" + "sign_x" + ">";
                            break;
                        case 'y':
                            englishToASL += "<sprite name=" + "sign_y" + ">";
                            break;
                        case 'z':
                            englishToASL += "<sprite name=" + "sign_z" + ">";
                            break;
                        
                        case '0':
                            englishToASL += "<sprite name=" + "sign_0" + ">";
                            break;
                        case '1':
                            englishToASL += "<sprite name=" + "sign_1" + ">";
                            break;
                        case '2':
                            englishToASL += "<sprite name=" + "sign_2" + ">";
                            break;
                        case '3':
                            englishToASL += "<sprite name=" + "sign_3" + ">";
                            break;
                        case '4':
                            englishToASL += "<sprite name=" + "sign_4" + ">";
                            break;
                        case '5':
                            englishToASL += "<sprite name=" + "sign_5" + ">";
                            break;
                        case '6':
                            englishToASL += "<sprite name=" + "sign_6" + ">";
                            break;
                        case '7':
                            englishToASL += "<sprite name=" + "sign_7" + ">";
                            break;
                        case '8':
                            englishToASL += "<sprite name=" + "sign_8" + ">"; 
                            break;
                        case '9':
                            englishToASL += "<sprite name=" + "sign_9" + ">";
                            break;

       
                        case '?':
                            englishToASL += "?";
                            break;
                        case '!':
                            englishToASL += "!";
                            break;
                        default:
                            if(Char.IsWhiteSpace(c)) {
                                englishToASL += "_";
                            }
                            break;
                    }
                }
                translationOutputText.text = englishToASL;
            }
        }
    }

    public void inputSign(string signName) {

        switch (signName)
        {
            case "sign_a":
                currentASLTranslation += "a";
                break;
            case "sign_b":
                currentASLTranslation += "b";
                break;
            case "sign_c":
                currentASLTranslation += "c";
                break;
            case "sign_d":
                currentASLTranslation += "d";
                break;
            case "sign_e":
                currentASLTranslation += "e";
                break;
            case "sign_f":
                currentASLTranslation += "f";
                break;
            case "sign_g":
                currentASLTranslation += "g";
                break;
            case "sign_h":
                currentASLTranslation += "h";
                break;
            case "sign_i":
                currentASLTranslation += "i";
                break;
            case "sign_j":
                currentASLTranslation += "j";
                break;
            case "sign_k":
                currentASLTranslation += "k";
                break;
            case "sign_l":
                currentASLTranslation += "l";
                break;
            case "sign_m":
                currentASLTranslation += "m";
                break;
            case "sign_n":
                currentASLTranslation += "n";
                break;
            case "sign_o":
                currentASLTranslation += "o";
                break;
            case "sign_p":
                currentASLTranslation += "p";
                break;
            case "sign_q":
                currentASLTranslation += "q";
                break;
            case "sign_r":
                currentASLTranslation += "r";
                break;
            case "sign_s":
                currentASLTranslation += "s";
                break;
            case "sign_t":
                currentASLTranslation += "t";
                break;
            case "sign_u":
                currentASLTranslation += "u";
                break;
            case "sign_v":
                currentASLTranslation += "v";
                break;
            case "sign_w":
                currentASLTranslation += "w";
                break;
            case "sign_x":
                currentASLTranslation += "x";
                break;
            case "sign_y":
                currentASLTranslation += "y";
                break;
            case "sign_z":
                currentASLTranslation += "z";
                break;
            
            case "sign_0":
                currentASLTranslation += "0";
                break;
            case "sign_1":
                currentASLTranslation += "1";
                break;
            case "sign_2":
                currentASLTranslation += "2";
                break;
            case "sign_3":
                currentASLTranslation += "3";
                break;
            case "sign_4":
                currentASLTranslation += "4";
                break;
            case "sign_5":
                currentASLTranslation += "5";
                break;
            case "sign_6":
                currentASLTranslation += "6";
                break;
            case "sign_7":
                currentASLTranslation += "7";
                break;
            case "sign_8":
                currentASLTranslation += "8";
                break;
            case "sign_9":
                currentASLTranslation += "9";
                break;

            case "space":
                currentASLTranslation += " ";
                break;
            case "?":
                currentASLTranslation += "?";
                break;
            case "!":
                currentASLTranslation += "!";
                break;
        }

        if(signName == "space") {
            currentASLSigns += " ";
        }
        else if(signName == "?") {
            currentASLSigns += "?";
        }
        else if(signName == "!") {
            currentASLSigns += "!";
        }
        else {
            currentASLSigns += "<sprite name=" + signName + ">";
        }

        aslSignsInput.text = currentASLSigns;

    }

    public void translateASLSigns() {
        translationOutputText.text = currentASLTranslation;
        aslKeyboardPanel.SetActive(false);
        aslKeyboardButton.SetActive(true);
    }
}
