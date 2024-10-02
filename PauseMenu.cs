using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    // Start is called before the first frame update

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject myText;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        int num = UnityEngine.Random.Range(0, 19);
        pauseMenuUI.SetActive(true);
        switch (num)
        {
            case 0:
                myText.GetComponent<Text>().text = "Use comments with # to explain your code. It’s a good habit to leave notes for yourself or others to understand what each part of your code does.";
                break;
            case 1:
                myText.GetComponent<Text>().text = "Handle errors with try and except. This lets you catch mistakes in your code without crashing the program, like if the user enters something unexpected.";
                break;
                case 2:
                myText.GetComponent<Text>().text = "Use else to do something when if isn’t true. else helps you handle the situation when none of the if or elif conditions are met.";
                break;
                case 3:
                myText.GetComponent<Text>().text = "Combine conditions using and or or. You can check multiple conditions in an if statement by using and or or, like if x > 3 and y < 5:.";
                break;
                case 4:
                myText.GetComponent<Text>().text = "Check if two things are the same with ==. Use == in conditions to compare values, like if x == 5: to see if x is equal to 5.";
                break;
                case 5:
                myText.GetComponent<Text>().text = "Use break to stop a loop early. Sometimes you want to stop a loop before it finishes, and break is a handy way to do this.";
                break;
                case 6:
                myText.GetComponent<Text>().text = "while loops keep running as long as a condition is true. For example, while x < 10: keeps running the code inside until x reaches 10.";
                break;
                case 7:
                myText.GetComponent<Text>().text = "Use return in a function to get a result. After a function finishes its work, return lets you send back a value";
                break;
                case 8:
                myText.GetComponent<Text>().text = "Create reusable code with functions: def my_function():. Functions let you organize your code into blocks that you can call whenever you need them.";
                break;
                case 9:
                myText.GetComponent<Text>().text = "Use elif to add more conditions after if. You can check multiple conditions using elif, like if x == 1:, elif x == 2:.";
                break;
                case 10:
                myText.GetComponent<Text>().text = "Use len() to find out how many items are in a list. It’s helpful to know how many elements are in a list when you need to loop through them.";
                break;
                case 11:
                myText.GetComponent<Text>().text = "Access items in a list using their index, like my_list[0]. The first item in a list starts at index 0, not 1.";
                break;
                case 12:
                myText.GetComponent<Text>().text = "A list is like a collection of items: my_list = [1, 2, 3]. You can store multiple values in a list and access them later.";
                break;
                case 13:
                myText.GetComponent<Text>().text = "Ask the user for input with input(). You can interact with the user by asking them questions and using their responses in your code.";
                break;
                case 14:
                myText.GetComponent<Text>().text = "Loops like for i in range(5): repeat actions. This is useful when you want to do something multiple times, like printing numbers from 0 to 4.";
                break;
                case 15:
                myText.GetComponent<Text>().text = "Use if statements to make decisions. For example, if x > 3: checks if a number is greater than 3 and runs code based on that condition.";
                break;
                case 16:
                myText.GetComponent<Text>().text = "You can add numbers or strings with +. Use + to do math or join words together, like \"Hello\" + \" World\".";
                break;
                case 17:
                myText.GetComponent<Text>().text = "Put text in quotes to make a string: \"Hello, World!\". Strings are used to store and work with text in your program.";
                break;
                case 18:
                myText.GetComponent<Text>().text = "Store data in variables like x = 5. Variables hold values you can reuse and change, making your code more flexible.";
                break;
                case 19:
                myText.GetComponent<Text>().text = "Use print() to see what’s happening in your code. It helps you understand what your program is doing by showing the output in the console.";
                break;
                default: break;
        }
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
