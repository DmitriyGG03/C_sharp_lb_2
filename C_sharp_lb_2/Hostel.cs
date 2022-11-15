using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostels;

public class Hostel
{
    private int roomsNumber;
    private int studentAmount;
    private int stuffNumber;

    public int ID { get; set; }
    public string universityName { get; set; }
    public string hostelAddress { get; set; }
    public int StuffNumber 
    { 
        get => stuffNumber; 
        set
        {
            if (value > 1 && value < 1000) roomsNumber = value;
            else throw new Exception("Incorrect number of employees");
        } 
    }
    public int RoomsNumber
    {
        get { return roomsNumber; }
        set
        {
            if (value > 1 && value < 1000) roomsNumber = value;
            else throw new Exception("Incorrect number of rooms");
        }
    }
    public int StudentAmount 
    { 
        get => studentAmount; 
        set
        {
            if(value <= (RoomsNumber * 3)) studentAmount = value;
            else throw new Exception("The number of students exceeds the number of places in the hostel");
        }
    }
    public double hostelProfit { get; set; }

    public Hostel(int id, string universityName, string hostelAddress, int StuffNumber, int RoomsNumber)
    {

    }


}
