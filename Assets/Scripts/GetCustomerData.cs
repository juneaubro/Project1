using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GetCustomerData : MonoBehaviour {
    private List<Customers> customers = new List<Customers>();
    private void Start() {
        GetCustomerDataFromFile();
        DisplayCustomerArray();
    }
    private void GetCustomerDataFromFile() {
        string[] lines = System.IO.File.ReadAllLines(@".\Assets\Data.csv").Skip(1).ToArray();
        string[] formattedData = new string[lines.Count()];
        foreach (string line in lines) {
            formattedData = line.Split(',');
            customers.Add(new Customers(
                System.Int32.Parse(formattedData[0]),
                System.Double.Parse(formattedData[1]),
                System.Double.Parse(formattedData[2])
                ));
        }
    }
    private Customers[] customerArray() {
        Customers[] array = new Customers[customers.Count];
        for(int i = 0; i < customers.Count; i++) {
            array[i] = customers[i];
        }
        return array;
    }
    private void DisplayCustomerArray() {
        for (int i = 0; i < customerArray().Count(); i++) {
            print(customerArray()[i]);
        }
    }
}
