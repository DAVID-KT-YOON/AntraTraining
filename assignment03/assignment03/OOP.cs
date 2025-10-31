using System.Drawing;

namespace assignment03;

using System;

public interface IPersonService
{
    int GetAge();                         
    decimal GetSalary();                  
    List<string> GetAddresses();          
    void AddAddress(string address);
}

public interface IStudentService : IPersonService
{
    double GetGPA();                      
}

public interface IInstructorService : IPersonService
{
    int GetYearsOfExperience();
    bool IsHeadOfDepartment();
}
public interface ICourseService
{
    string GetCourseName();
}
//abstration
public abstract class Person : IPersonService
{
    public string FirstName
    {
        get; set;
    }

    public string LastName
    {
        get; set; 
    }

    public DateTime DateOfBirth
    {
        get; set; 
    }

    private decimal _baseSalary;
    public decimal BaseSalary
    {
        get
        {
            return _baseSalary;
        } 
        set
        {
            _baseSalary = value;
        }
    }

    private readonly List<string> _addresses = new List<string>();

    protected Person(string firstName, string lastName, DateTime dob, decimal baseSalary)
    {
        FirstName    = firstName;
        LastName     = lastName;
        DateOfBirth  = dob;
        BaseSalary   = baseSalary; 
    }


    public int GetAge()
    {
        var today = DateTime.Today;
        return today.Year - DateOfBirth.Year;

    }
    
    public virtual decimal GetSalary()
    {
        return BaseSalary;
    }

    public List<string> GetAddresses()
    {
        return new List<string>(_addresses);
    }

    public void AddAddress(string address)
    {
        if (!string.IsNullOrWhiteSpace(address))
            _addresses.Add(address);
    }
}

public  class Instructor : Person, IInstructorService
{
    public string DepartmentName;
    public bool HeadOfDepartment;
    public DateTime JoinDate;
    
    public Instructor(
        string firstName,
        string lastName,
        DateTime dob,
        decimal baseSalary,
        string departmentName,
        bool isHeadOfDepartment,
        DateTime joinDate
    ): base(firstName, lastName, dob, baseSalary) {
        
        this.DepartmentName = departmentName;
        this.HeadOfDepartment = isHeadOfDepartment;
        this.JoinDate = joinDate;
    }
    public int GetYearsOfExperience()
    {
        DateTime today = DateTime.Today;
        int years = today.Year - JoinDate.Year;
        if (JoinDate.Date > today.AddYears(-years))
        {
            years = years - 1;
        }
        if (years < 0)
        {
            years = 0;
        }
        return years;
    }
    public bool IsHeadOfDepartment()
    {
        return HeadOfDepartment;
    }
    public override decimal GetSalary()
    {
        int years = GetYearsOfExperience();
        decimal bonusPerYear = 1000m;
        decimal bonus = years * bonusPerYear;

        if (HeadOfDepartment)
        {
            bonus = bonus + 5000m;
        }
        return BaseSalary + bonus;
    }
}

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;
    
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = 255; 
    }
    public int GetRed() { return red; }
    public int GetGreen() { return green; }
    public int GetBlue() { return blue; }
    public int GetAlpha() { return alpha; }
    
    public void SetRed(int red) { this.red = red; }
    public void SetGreen(int green) { this.green = green; }
    public void SetBlue(int blue) { this.blue = blue; }
    public void SetAlpha(int alpha) { this.alpha = alpha; }
    
    public int GetGrayScale()
    {
        return (red + green + blue) / 3;
    }
}

public class Ball
{
    private int size;
    private Color color;
    private int thrownCount;

    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.thrownCount = 0;
    }
    public void Pop()
    {
        size = 0;
    }
    public void Throw()
    {
        if (size > 0)
        {
            thrownCount++;
        }
    }
    public int GetThrownCount()
    {
        return thrownCount;
    }
}
