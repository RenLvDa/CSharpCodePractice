using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIEnumerable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Garage test = new Garage();
        foreach(Car c in test)
        {
            Debug.Log(c.PetName);
        }
    }

    public class Car
    {
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        public Car() { }
        public Car(string name,int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
    }

    public class Garage:IEnumerable
    {
        private Car[] carArray = new Car[4];
        public Garage()
        {
            carArray[0] = new Car("Tom", 30);
            carArray[1] = new Car("Alice", 55);
            carArray[2] = new Car("Bob", 30);
            carArray[3] = new Car("Zippy", 40);
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }


}
