using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

public class Facade
{
    private Subsystem1 _subsystem1;
    private Subsystem2 _subsystem2;

    public Facade()
    {
        _subsystem1 = new Subsystem1();
        _subsystem2 = new Subsystem2();
    }

    public void Operation1()
    {
        _subsystem1.Operation1();
        _subsystem2.Operation1();
    }

    public void Operation2()
    {
        _subsystem1.Operation2();
        _subsystem2.Operation2();
    }
}
