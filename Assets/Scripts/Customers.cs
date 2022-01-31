using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customers {
    private int customerNumber_;
    private double interarrivalTime_;
    private double serviceTime_;
    public int CustomerNumber {get;set;}
    public double InterarrivalTime { get; set; }
    public double ServiceTime { get; set; }
    public override string ToString() {
        return $"Customer #: {CustomerNumber}, Interarrival Time (min): {InterarrivalTime}, Service Time (min): {ServiceTime}";
    }
    public Customers(int customerNumber,double interarrivalTime,double serviceTime) {
        CustomerNumber = customerNumber;
        InterarrivalTime = interarrivalTime;
        ServiceTime = serviceTime;
    }
}
