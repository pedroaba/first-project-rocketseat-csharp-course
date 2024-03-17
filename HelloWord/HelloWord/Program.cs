using HelloWord.Test;

namespace HelloWord;

class Progam
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.TurnOn();
        myCar.TurnOff();

        Cookie myCookie = new Cookie();
        myCookie.Temperature();
    }
}