using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public GameObject visual001, visual002, visual003, visual004, visual005, visual006, visual007, visual008;
    



    void Update()
    {
        if (displayingQuestion == false)
       
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 8); //upper limit has to be 1 + the number of input
            if (questionNumber == 1)
            {
              
                QuestionDisplay.newQuestion = "Match the event to the correct description.";
                QuestionDisplay.newA = "Family vacation";
                QuestionDisplay.newB = "Garba";
                QuestionDisplay.newC = "Sister's birthday";
                QuestionDisplay.newD = "Picnic with friends";
                visual001.SetActive(true);
                actualAnswer = "B";
            }

            if(questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Match the event to the correct description.";
                QuestionDisplay.newA = "College graduation";
                QuestionDisplay.newB = "My wedding";
                QuestionDisplay.newC = "Kids first day at school";
                QuestionDisplay.newD = "Sister's birthday";
                visual002.SetActive(true);
                actualAnswer = "D";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Who is this?";
                QuestionDisplay.newA = "Me";
                QuestionDisplay.newB = "Mom";
                QuestionDisplay.newC = "Cat";
                QuestionDisplay.newD = "Sister";
                visual003.SetActive(true);
                actualAnswer = "C";
            }


            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Match the event to the picture";
                QuestionDisplay.newA = "Wedding anniversary";
                QuestionDisplay.newB = "My high school graduation";
                QuestionDisplay.newC = "My neighbor's potluck";
                QuestionDisplay.newD = "Spouse's birthday";
                visual004.SetActive(true);
                actualAnswer = "B";
            }

            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Match the event to the picture";
                QuestionDisplay.newA = "Friend's Birthday";
                QuestionDisplay.newB = "College Party";
                QuestionDisplay.newC = "My neighbor's potluck";
                QuestionDisplay.newD = "First Day of School";
                visual005.SetActive(true);
                actualAnswer = "D";
            }

            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Match the event to the picture";
                QuestionDisplay.newA = "Orchestra Concert";
                QuestionDisplay.newB = "Friend's Birthday";
                QuestionDisplay.newC = "My neighbor's potluck";
                QuestionDisplay.newD = "First Day of School";
                visual006.SetActive(true);
                actualAnswer = "A";
            }


            if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Match the event to the picture";
                QuestionDisplay.newA = "Friend's Birthday";
                QuestionDisplay.newB = "Vacation to France";
                QuestionDisplay.newC = "My neighbor's potluck";
                QuestionDisplay.newD = "First Day of School";
                visual007.SetActive(true);
                actualAnswer = "B";
            }

            if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "What is this Dog's Name";
                QuestionDisplay.newA = "Max";
                QuestionDisplay.newB = "Coco";
                QuestionDisplay.newC = "Gracie";
                QuestionDisplay.newD = "Sadie";
                visual008.SetActive(true);
                actualAnswer = "C";
            }


    // all of the questions are above this line

    QuestionDisplay.pleaseUpdate = false;
        }
    }
}
