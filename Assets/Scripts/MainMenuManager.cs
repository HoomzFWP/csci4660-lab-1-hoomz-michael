using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private Button startButton;
    [SerializeField] private Button openCreditsButton;
    [SerializeField] private Button closeCreditsButton;
    [SerializeField] private Button platformerButton;
    [SerializeField] private Button ThreeDSpawnButton;
    [SerializeField] private GameObject creditsUI;

    void Start()
    {

        openCreditsButton.onClick.AddListener(
            () => {
                creditsUI.SetActive(true);
            });


        closeCreditsButton.onClick.AddListener(
            () => {
                creditsUI.SetActive(false);
            });


        startButton.onClick.AddListener(
            () => {
                LoadingScreen.LoadScene("gun");
            });

        platformerButton.onClick.AddListener(
            () => {
            LoadingScreen.LoadScene("NotQuitePlatformer");
        });

        ThreeDSpawnButton.onClick.AddListener(
            () => {
            LoadingScreen.LoadScene("3DSpawn");
        });
    }
}