using UnityEngine;
using Decorator;

public class Debugger : MonoBehaviour
{
    [SerializeField] private HotDogSO classicHotDogSO;
    [SerializeField] private HotDogSO cesarHotDogSO;
    [SerializeField] private HotDogSO meatHotDogSO;
    [SerializeField] private HotDogSO cucumberSO;
    [SerializeField] private HotDogSO onionSO;

    void Start()
    {
        ClassicHotDog hotdog1 = new ClassicHotDog(classicHotDogSO.Name, classicHotDogSO.Cost, classicHotDogSO.Weight);
        CucumberDecorator cdecorator1 = new CucumberDecorator(cucumberSO.Name, cucumberSO.Cost, cucumberSO.Weight, hotdog1);
        OnionDecorator odecorator1 = new OnionDecorator(onionSO.Name, onionSO.Cost, onionSO.Weight, hotdog1);

        
        CesarHotDog hotdog2 = new CesarHotDog(cesarHotDogSO.Name, cesarHotDogSO.Cost, cesarHotDogSO.Weight);
        CucumberDecorator cdecorator2 = new CucumberDecorator(cucumberSO.Name, cucumberSO.Cost, cucumberSO.Weight, hotdog2);
        OnionDecorator odecorator2 = new OnionDecorator(onionSO.Name, onionSO.Cost, onionSO.Weight, hotdog2);

        
        CesarHotDog hotdog3 = new CesarHotDog(meatHotDogSO.Name, meatHotDogSO.Cost, meatHotDogSO.Weight);
        CucumberDecorator cdecorator3 = new CucumberDecorator(cucumberSO.Name, cucumberSO.Cost, cucumberSO.Weight, hotdog3);
        OnionDecorator odecorator3 = new OnionDecorator(onionSO.Name, onionSO.Cost, onionSO.Weight, hotdog3);

        
        Debug.Log($"{hotdog1.Name} ({hotdog1.GetWeight()}р) - {hotdog1.GetCost()}р." +
            $"\nДополнительная информация::" +
            $"\n{hotdog1.Name} {cdecorator1.Name} ({cdecorator1.GetWeight()}р) - {cdecorator1.GetCost()}р." +
            $"\n{hotdog1.Name} {odecorator1.Name} ({odecorator1.GetWeight()}р) - {odecorator1.GetCost()}р.");

        
        Debug.Log($"{hotdog2.Name} ({hotdog2.GetWeight()}р) - {hotdog2.GetCost()}р." +
            $"\nДополнительная информация:" +
            $"\n{hotdog2.Name} {cdecorator2.Name} ({cdecorator2.GetWeight()}р) - {cdecorator2.GetCost()}р." +
            $"\n{hotdog2.Name} {odecorator2.Name} ({odecorator2.GetWeight()}р) - {odecorator2.GetCost()}р.");

        
        Debug.Log($"{hotdog3.Name} ({hotdog3.GetWeight()}р) - {hotdog3.GetCost()}р." +
            $"\nДополнительная информация:" +
            $"\n{hotdog3.Name} {cdecorator3.Name} ({cdecorator3.GetWeight()}р) - {cdecorator3.GetCost()}р." +
            $"\n{hotdog3.Name} {odecorator3.Name} ({odecorator3.GetWeight()}р) - {odecorator3.GetCost()}р.");
    }
}