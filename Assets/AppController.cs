using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{

    public GameObject homePanel;
    public GameObject menuPanel;
    public GameObject aslPanel;
    public GameObject categoryPanel;
    public GameObject translatorPanel;
    private GameObject currentPanel;

    // Categories Characters
    public GameObject emotions_character;
    public GameObject expressions_character;
    public GameObject family_character;

    private Animator animator;

    // ASL Category Panel
    public Text categoryTittle;
    public Text currentSignName;

    private string[] currentASLCategory;

    // Emotions Category list
    public string[] emotions_category;

    // Expressions Category list
    public string[] expressions_category;

    // Family Category list
    public string[] family_category;

    // Current animation playing
    private string current_anim = null;

    // Start is called before the first frame update
    void Start() {
        currentPanel = homePanel;

        emotions_category = new string[] {
            "Bad",
            "Calm",
            "Determined",
            "Kind",
            "Mad",
            "Overwhelmed",
            "Sad"
        };

        expressions_category = new string[] {
            "Enjoyment",
            "I Don't Understand",
            "I Understand",
            "I want",
            "I'll help you"
        };

        family_category = new string[] {
            "Family",
            "Father",
            "Mother",
            "Parents",
            "Siblings"
        };

    }

    public void playAnimation(string anim_name) {

        // if null then first anim to play then skip
        if(current_anim != null) {
            animator.SetBool(current_anim, false);
        }
        current_anim = anim_name;
        animator.SetBool(anim_name, true);
    }

    public void openMenu() {
        closeCurrentPanel();
        currentPanel = menuPanel;
        openCurrentPanel();
    }

    public void openASLPanel() {
        closeCurrentPanel();
        currentPanel = aslPanel;
        openCurrentPanel();

        emotions_character.SetActive(false);
        expressions_character.SetActive(false);
        family_character.SetActive(false);
    }

    public void openCategory(string categoryName) {
        closeCurrentPanel();
        currentPanel = categoryPanel;
        openCurrentPanel();

        if(categoryName == "Emotions") {
            currentASLCategory = emotions_category;
            categoryTittle.text = "Emotions";

            emotions_character.SetActive(true);
            expressions_character.SetActive(false);
            family_character.SetActive(false);

            animator = emotions_character.GetComponent<Animator>();
        } 
        else if(categoryName == "Expressions") {
            currentASLCategory = expressions_category;
            categoryTittle.text = "Expressions";
            
            emotions_character.SetActive(false);
            expressions_character.SetActive(true);
            family_character.SetActive(false);

            animator = expressions_character.GetComponent<Animator>();
        }
        else if(categoryName == "Family") {
            currentASLCategory = family_category;
            categoryTittle.text = "Family";

            emotions_character.SetActive(false);
            expressions_character.SetActive(false);
            family_character.SetActive(true);

            animator = family_character.GetComponent<Animator>();
        }

        currentSignName.text = currentASLCategory[0];
        current_anim = currentASLCategory[0];

    }

    public void playNextAnimation() {
        int currentSignIndex = System.Array.IndexOf(currentASLCategory, current_anim);
        if(currentSignIndex < (currentASLCategory.Length-1)) {
            playAnimation(currentASLCategory[currentSignIndex+1]);
            currentSignName.text = currentASLCategory[currentSignIndex+1];
        }
    }

    public void playPreviousAnimation() {
        int currentSignIndex = System.Array.IndexOf(currentASLCategory, current_anim);
        if(currentSignIndex <= (currentASLCategory.Length-1) && currentSignIndex > 0) {
            playAnimation(currentASLCategory[currentSignIndex-1]);
            currentSignName.text = currentASLCategory[currentSignIndex-1];
        }
    }

    public void openTranslator() {
        closeCurrentPanel();
        currentPanel = translatorPanel;
        openCurrentPanel();
    }

    public void closeCurrentPanel() {
        if (currentPanel != null) {  
            currentPanel.SetActive(false);  
        }  
    }

    public void openCurrentPanel() {
        if (currentPanel != null) {  
            currentPanel.SetActive(true);  
        }  
    }
}