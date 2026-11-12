using Unity.Burst.CompilerServices;
using UnityEngine;

public class print_message : MonoBehaviour
{
    /// <summary>
    /// prints a message
    /// </summary>
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hi, new unity Dev!");
        string title = "my favorite games are:";
        string a = "Platypus hunt";
        string b = "The buildinator!";
        string c = "Train Simulator";
        print(title+"\n"+a+"\n"+b+"\n"+c);
    }
}
